using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestToolTipPage : BaseTest
    {
        [Test]
        public void TestToolTip()
        {
            ToolTipPage toolTipPage = new ToolTipPage(Driver);
            var result = toolTipPage.Hover();
			Assert.AreEqual("Age", result, "Arent equal");
        }
    }
}
