using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestSortablePage : BaseTest
    {
        [Test]
        public void TestSortFirstItem()
        {
            SortablePage sortablePage = new SortablePage(Driver);
            var result = sortablePage.SortTheFirstItem();
			Assert.Multiple(() =>
			{
				Assert.AreEqual(0, result.FirstLocationByX);
				Assert.AreEqual(100, result.FirstLocationByY);
			});
        }

		[Test]
		public void TestSortSecondItem()
		{
			SortablePage sortablePage = new SortablePage(Driver);
			var result = sortablePage.SortTheSecondItem();
			Assert.Multiple(() =>
			{
				Assert.AreEqual(0, result.SecondLocationByX);
				Assert.AreEqual(-50, result.SecondLocationByY);
			});
		}
    }
}
