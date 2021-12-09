using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestDownloadPage : BaseTest
    {
        [Test]
        public void TestDownload()
        {
            DownloadPage downloadPage = new DownloadPage(Driver);
            var result = downloadPage.VerifyFileDownload();
			Assert.IsTrue(result);
        }
    }
}
