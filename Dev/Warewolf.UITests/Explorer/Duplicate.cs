﻿using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// ReSharper disable InconsistentNaming

namespace Warewolf.UITests
{
    [CodedUITest]
    public class DuplicateExplorerResource
    {
        [TestMethod]
        [TestCategory("Explorer")]
        public void DuplicateResource_ThenAddsNewItemItem()
        {
            UIMap.Filter_Explorer("Hello World");
            UIMap.Duplicate_FirstResource_FromContextMenu();
            UIMap.Enter_Duplicate_workflow_name("Duplicated_HelloWorld");
            UIMap.Click_Duplicate_From_Duplicate_Dialog();
        }
        
        [TestMethod]
        [TestCategory("Explorer")]
        public void DuplicateResource_ThenAddsNewFolderItem()
        {
            UIMap.Filter_Explorer("Examples");
            UIMap.Duplicate_FirstResource_FromContextMenu();
            UIMap.Enter_Duplicate_workflow_name("Duplicated_ExamplesFolder");
            UIMap.Click_Duplicate_From_Duplicate_Dialog();
        }
        
        #region Additional test attributes

        [TestInitialize]
        public void MyTestInitialize()
        {
            UIMap.SetPlaybackSettings();
            UIMap.AssertStudioIsRunning();
        }

        UIMap UIMap
        {
            get
            {
                if (_UIMap == null)
                {
                    _UIMap = new UIMap();
                }

                return _UIMap;
            }
        }

        private UIMap _UIMap;

        #endregion
    }
}