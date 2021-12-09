using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestTablePage : BaseTest
    {
        [Test]
        public void TestNumOfRows()
        {
            TablePage tablePage = new TablePage(Driver);
            var result = tablePage.NumOfRows();
			Assert.AreEqual(5, result);
        }

		[Test]
		public void TestNumOfCols()
		{
			TablePage tablePage = new TablePage(Driver);
			var result = tablePage.NumOfCols();
			Assert.AreEqual(6, result);
		}

		[Test]
		public void TestGetTheProgress()
		{
			TablePage tablePage = new TablePage(Driver);
			var result = tablePage.GetTheProgress();
			Assert.AreEqual("80%", result);
		}
	}
}
