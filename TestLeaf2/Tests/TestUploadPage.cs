using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestUploadPage : BaseTest
    {
        [Test]
        public void TestUpload()
        {
            UploadPage uploadPage = new UploadPage(Driver);
            uploadPage.PerformUploadPage();
        }
    }
}
