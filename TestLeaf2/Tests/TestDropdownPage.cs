using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
	[TestFixture]
	class TestDropdownPage : BaseTest
	{
		[Test]
		public void TestSelectElementByIndex()
		{
			DropdownPage dropdownPage = new DropdownPage(Driver);
			var result = dropdownPage.SelectElementByIndex();
			Assert.AreEqual("Selenium", result, "Returned wrong text");
		}

		[Test]
		public void TestSelectElementByText()
		{
			DropdownPage dropdownPage = new DropdownPage(Driver);
			var result = dropdownPage.SelectElementByText();
			Assert.AreEqual("Selenium", result, "Returned wrong text");
		}

		[Test]
		public void TestSelectByValue()
		{
			DropdownPage dropdownPage = new DropdownPage(Driver);
			var result = dropdownPage.SelectElementByValue();
			Assert.AreEqual("Appium", result, "Returned wrong text");
		}

		[Test]
		public void TestAmountOfOptions()
		{
			DropdownPage dropdownPage = new DropdownPage(Driver);
			var result = dropdownPage.AmountOfOption();
			Assert.AreEqual(5, result, "Incorrect number of option");
		}

		[Test]
		public void TestEnterTextInField()
		{
			DropdownPage dropdownPage = new DropdownPage(Driver);
			var result = dropdownPage.EnterTextInField();

		}

	}
}
