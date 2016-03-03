﻿using System;
using System.Activities.Presentation.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Dev2.Common.Common;
using Dev2.Common.Interfaces.Core.DynamicServices;
using Dev2.Common.Interfaces.DB;
using Dev2.Common.Interfaces.ServerProxyLayer;
using Dev2.Common.Interfaces.ToolBase;
using Dev2.Studio.Core.Activities.Utils;
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable ExplicitCallerInfoArgument
// ReSharper disable UnusedMember.Global

namespace Dev2.Activities.Designers2.Core.Source
{
    public class DatabaseSourceRegion : ISourceToolRegion<IDbSource>
    {
        private double _minHeight;
        private double _currentHeight;
        private bool _isVisible;
        private double _maxHeight;
        private const double BaseHeight = 25;
        private IDbSource _selectedSource;
        private ICollection<IDbSource> _sources;
        private readonly ModelItem _modelItem;
        readonly Dictionary<Guid, IList<IToolRegion>> _previousRegions = new Dictionary<Guid, IList<IToolRegion>>();
        private Guid _sourceId;
        private Action _sourceChangedAction;
        private double _labelWidth;

        public DatabaseSourceRegion(IDbServiceModel model, ModelItem modelItem,enSourceType type)
        {
            LabelWidth = 46;
            ToolRegionName = "DatabaseSourceRegion";
            SetInitialValues();
            Dependants = new List<IToolRegion>();
            NewSourceCommand = new Microsoft.Practices.Prism.Commands.DelegateCommand(model.CreateNewSource);
            EditSourceCommand = new Microsoft.Practices.Prism.Commands.DelegateCommand(() => model.EditSource(SelectedSource), CanEditSource);
            var sources = model.RetrieveSources().OrderBy(source => source.Name);
            Sources = sources.Where(source => source != null && source.Type == type).ToObservableCollection();
            IsVisible = true;
            _modelItem = modelItem;
            SourceId = modelItem.GetProperty<Guid>("SourceId");
            if (SourceId != Guid.Empty)
            {
                SelectedSource = Sources.FirstOrDefault(source => source.Id == SourceId);
            }
        }

        private void SetInitialValues()
        {
            MinHeight = BaseHeight;
            MaxHeight = BaseHeight;
            CurrentHeight = BaseHeight;
            IsVisible = true;
        }

        public DatabaseSourceRegion()
        {
            SetInitialValues();
        }

        Guid SourceId
        {
            get
            {
                return _sourceId;
            }
            set
            {
                _sourceId = value;
                if (_modelItem != null)
                {
                    _modelItem.SetProperty("SourceId", value);
                }
            }
        }

        public bool CanEditSource()
        {
            return SelectedSource != null;
        }

        public ICommand EditSourceCommand { get; set; }

        public ICommand NewSourceCommand { get; set; }
        public Action SourceChangedAction
        {
            get
            {
                return _sourceChangedAction??(()=>{});
            }
            set
            {
                _sourceChangedAction = value;
            }
        }
        public event SomethingChanged SomethingChanged;
        public double LabelWidth
        {
            get
            {
                return _labelWidth;
            }
            set
            {
                _labelWidth = value;
                OnPropertyChanged();
            }
        }

        #region Implementation of IToolRegion

        public string ToolRegionName { get; set; }
        public double MinHeight
        {
            get
            {
                return _minHeight;
            }
            set
            {
                _minHeight = value;
                OnPropertyChanged();
            }
        }
        public double CurrentHeight
        {
            get
            {
                return _currentHeight;
            }
            set
            {
                _currentHeight = value;
                OnPropertyChanged();
            }
        }
        public bool IsVisible
        {
            get
            {
                return _isVisible;
            }
            set
            {
                _isVisible = value;
                OnPropertyChanged();
            }
        }
        public double MaxHeight
        {
            get
            {
                return _maxHeight;
            }
            set
            {
                _maxHeight = value;
                OnPropertyChanged();
            }
        }
        public event HeightChanged HeightChanged;
        public IList<IToolRegion> Dependants { get; set; }

        public IToolRegion CloneRegion()
        {
            return new DatabaseSourceRegion
            {
                MaxHeight = MaxHeight,
                MinHeight = MinHeight,
                IsVisible = IsVisible,
                SelectedSource = SelectedSource,
                CurrentHeight = CurrentHeight
            };
        }

        public void RestoreRegion(IToolRegion toRestore)
        {
            var region = toRestore as DatabaseSourceRegion;
            if (region != null)
            {
                MaxHeight = region.MaxHeight;
                SelectedSource = region.SelectedSource;
                MinHeight = region.MinHeight;
                CurrentHeight = region.CurrentHeight;
                IsVisible = region.IsVisible;
            }
        }

        #endregion

        #region Implementation of ISourceToolRegion<IDbSource>

        public IDbSource SelectedSource
        {
            get
            {
                return _selectedSource;
            }
            set
            {
                if (!Equals(value, _selectedSource) && _selectedSource != null)
                {
                    if (!String.IsNullOrEmpty(_selectedSource.DbName))
                        StorePreviousValues(_selectedSource.Id);
                }

                if (IsAPreviousValue(value) && _selectedSource != null)
                {
                    RestorePreviousValues(value);
                    SetSelectedSource(value);
                }
                else
                {
                    SetSelectedSource(value);
                    SourceChangedAction();
                    OnSomethingChanged(this);
                }
                var delegateCommand = EditSourceCommand as Microsoft.Practices.Prism.Commands.DelegateCommand;
                if (delegateCommand != null)
                {
                    delegateCommand.RaiseCanExecuteChanged();
                }
            }
        }

        private void SetSelectedSource(IDbSource value)
        {
            if (value != null)
            {
                _selectedSource = value;
                SavedSource = value;
                SourceId = value.Id;
            }

            OnHeightChanged(this);
            OnPropertyChanged("SelectedSource");
        }

        private void StorePreviousValues(Guid id)
        {
            _previousRegions.Remove(id);
            _previousRegions[id] = new List<IToolRegion>(Dependants.Select(a => a.CloneRegion()));
        }

        private void RestorePreviousValues(IDbSource value)
        {
            var toRestore = _previousRegions[value.Id];
            foreach (var toolRegion in Dependants.Zip(toRestore, (a, b) => new Tuple<IToolRegion, IToolRegion>(a, b)))
            {
                toolRegion.Item1.RestoreRegion(toolRegion.Item2);
            }
        }

        private bool IsAPreviousValue(IDbSource value)
        {
            return _previousRegions.Keys.Any(a => a == value.Id);
        }

        public ICollection<IDbSource> Sources
        {
            get
            {
                return _sources;
            }
            set
            {
                _sources = value;
                OnPropertyChanged();
            }
        }

        public IList<string> Errors
        {
            get
            {
                return SelectedSource == null ? new List<string> { "Invalid Source Selected" } : new List<string>();
            }
        }

        public IDbSource SavedSource
        {
            get
            {
                return _modelItem.GetProperty<IDbSource>("SavedSource");
            }
            set
            {
                _modelItem.SetProperty("SavedSource", value);
            }
        }

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected virtual void OnHeightChanged(IToolRegion args)
        {
            var handler = HeightChanged;
            if (handler != null)
            {
                handler(this, args);
            }
        }

        protected virtual void OnSomethingChanged(IToolRegion args)
        {
            var handler = SomethingChanged;
            if (handler != null)
            {
                handler(this, args);
            }
        }
    }
}