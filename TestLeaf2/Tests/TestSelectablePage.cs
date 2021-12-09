using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestSelectablePage : BaseTest
    {
        [Test]
        public void TestSelectable()
        {
            SelectablePage selectablePage = new SelectablePage(Driver);
			var result = selectablePage.Selecting();
			Assert.Multiple(() => 
			{
				Assert.AreEqual(0, result.LocationX, "Location by X doesnt match");
				Assert.AreEqual(200, result.LocationY, "Location by Y doesnt match");
			});
        }
    }
}
