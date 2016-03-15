﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Dev2.Activities.DropBox2016.UploadActivity;
using Dropbox.Api;
using Dropbox.Api.Files;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Dev2.Tests.Activities.ActivityTests.DropBox2016.Upload
{
    [TestClass]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class DropBoxUploadTests
    {
        private Mock<IDropBoxUpload> CreateDropboxUploadMock()
        {
            var mock = new Mock<IDropBoxUpload>();
            var fileMetadata = new FileMetadata();
            mock.Setup(expression)
                 .Returns(fileMetadata);
            return mock;
        }
        

        [TestMethod]
        [Owner("Nkosinathi Sangweni")]
        public void CreateDropBoxActivity_GivenIsNew_ShouldNotBeNull()
        {
            //---------------Set up test pack-------------------
            var dropBoxUpload = CreateDropboxUploadMock().Object;
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            //---------------Test Result -----------------------
            Assert.IsNotNull(dropBoxUpload);
        }

        readonly Expression<Func<IDropBoxUpload, FileMetadata>> expression = upload => upload.ExecuteTask(It.IsAny<DropboxClient>());
        [TestMethod]
        [Owner("Nkosinathi Sangweni")]
        public void ExecuteTask_GivenDropBoxUpload_ShouldReturnFileMetadata()
        {
            //---------------Set up test pack-------------------
            var dropBoxUpload = CreateDropboxUploadMock();
            //---------------Assert Precondition----------------
            Assert.IsNotNull(dropBoxUpload);
            //---------------Execute Test ----------------------
            //---------------Test Result -----------------------
            dropBoxUpload.Object.ExecuteTask(It.IsAny<DropboxClient>());
            dropBoxUpload.Verify(expression);
        }
        
        [TestMethod]
        [Owner("Nkosinathi Sangweni")]
        public void CreateNewDropboxUpload_GivenParameters_ShouldBeValid()
        {
            //---------------Set up test pack-------------------
            var dropBoxUpload = new DropBoxUpload(WriteMode.Add.Instance, "random.txt", "random.txt");
            //---------------Assert Precondition----------------
            Assert.IsNotNull(dropBoxUpload);
            //---------------Execute Test ----------------------
            dropBoxUpload.Validate();
            //---------------Test Result -----------------------
            Assert.IsTrue(dropBoxUpload.IsValid);
        }
        [TestMethod]
        [Owner("Nkosinathi Sangweni")]
        public void CreateNewDropboxUpload_GivenMissingWriteMode_ShouldBeInValid()
        {
            //---------------Set up test pack-------------------
            var dropBoxUpload = new DropBoxUpload(null, "random.txt", "random.txt");
            //---------------Assert Precondition----------------
            Assert.IsNotNull(dropBoxUpload);
            //---------------Execute Test ----------------------
            dropBoxUpload.Validate();
            //---------------Test Result -----------------------
            Assert.IsFalse(dropBoxUpload.IsValid);
        }  
        [TestMethod]
        [Owner("Nkosinathi Sangweni")]
        public void CreateNewDropboxUpload_GivenMissingFromPath_ShouldBeInValid()
        {
            //---------------Set up test pack-------------------
            var dropBoxUpload = new DropBoxUpload(null, "random.txt", "");
            //---------------Assert Precondition----------------
            Assert.IsNotNull(dropBoxUpload);
            //---------------Execute Test ----------------------
            dropBoxUpload.Validate();
            //---------------Test Result -----------------------
            Assert.IsFalse(dropBoxUpload.IsValid);
        } 
        
        [TestMethod]
        [Owner("Nkosinathi Sangweni")]
        public void CreateNewDropboxUpload_GivenMissingToPath_ShouldBeInValid()
        {
            //---------------Set up test pack-------------------
            var dropBoxUpload = new DropBoxUpload(null, "", "random.txt");
            //---------------Assert Precondition----------------
            Assert.IsNotNull(dropBoxUpload);
            //---------------Execute Test ----------------------
            dropBoxUpload.Validate();
            //---------------Test Result -----------------------
            Assert.IsFalse(dropBoxUpload.IsValid);
        } 
        
        [TestMethod]
        [Owner("Nkosinathi Sangweni")]
        public void CreateNewDropboxUpload_GivenInvalidThenExecute_ShouldReturnNull()
        {
            //---------------Set up test pack-------------------
            var dropBoxUpload = new DropBoxUpload(null, "", "random.txt");
            //---------------Assert Precondition----------------
            Assert.IsNotNull(dropBoxUpload);
            //---------------Execute Test ----------------------
            var metadata = dropBoxUpload.ExecuteTask(It.IsAny<DropboxClient>());
            //---------------Test Result -----------------------
            Assert.IsNull(metadata);
        }

       
    }
}