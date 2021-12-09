using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TestLeaf.Tests
{
	[TestFixture]
	class TestEditPage : BaseTest
	{

		[Test]
		public void TestEnterTextInField()
		{
			EditPage editPage = new EditPage(Driver);
			var result = editPage.EnterTextInField("text");
			Assert.AreEqual("text", result, "Doesnt match");
		}

		[Test]
		public void TestAppendTextInField()
		{
			EditPage editPage = new EditPage(Driver);
			var result = editPage.AppendTextInField("appended text");
			Assert.AreEqual("Append appended text", result, "Doesnt match");
		}

		[Test]
		public void TestGetDefaultText()
		{
			EditPage editPage = new EditPage(Driver);
			var result = editPage.GetDefaultText();
			Assert.AreEqual("TestLeaf", result, "Returned inncorrect text");
		}

		[Test]
		public void TestClearTextFromField()
		{
			EditPage editPage = new EditPage(Driver);
			var result = editPage.ClearTextFromField();
			Assert.IsTrue(result);
		}

		[Test]
		public void TestIsFieldEnable()
		{
			EditPage editPage = new EditPage(Driver);
			var result = editPage.IsFieldEnabled();
			Assert.IsFalse(result);
		}

	}
}
