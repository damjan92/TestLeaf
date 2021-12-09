using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
	[TestFixture]
	class TestCheckBoxPage : BaseTest
	{
		[Test]
		public void TestSelectLng()
		{
			CheckboxPage checkboxPage = new CheckboxPage(Driver);
			var result = checkboxPage.SelectLng();
			Assert.IsTrue(result);
		}

		[Test]
		public void TestIsSelected()
		{
			CheckboxPage checkboxPage = new CheckboxPage(Driver);
			var result = checkboxPage.IsSelected();
			Assert.IsTrue(result);
		}

		[Test] 
		public void TestDeselect()
		{
			CheckboxPage checkboxPage = new CheckboxPage(Driver);
			var result = checkboxPage.Deselect();
			Assert.IsTrue(result);
		}
    }
}
