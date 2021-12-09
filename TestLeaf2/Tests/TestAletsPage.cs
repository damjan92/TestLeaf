using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Helpers;
using TestLeaf.Pages;
using TestLeaf.Base;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestAletsPage : BaseTest
    {

		[Test]
		public void TestClickOnAlertBox()
		{
			AlertsPage alertsPage = new AlertsPage(Driver);
			var result = alertsPage.ClickAlertBox();
			Assert.IsTrue(result);
		}

		[Test]
		public void TestConfirmBox()
		{
			AlertsPage alertsPage = new AlertsPage(Driver);
			var result = alertsPage.ConfirmBox();
			Assert.IsTrue(result,"Alert did not accepted or appear");
		}

		[Test]
		public void TestPromptBox()
		{
			AlertsPage alertsPage = new AlertsPage(Driver);
			var results = alertsPage.PromptBox();
			Assert.IsTrue(results, "Wrong credentials");
		}
		
		[Test]
		public void TestGetAlertText()
		{
			AlertsPage alertsPage = new AlertsPage(Driver);
			var result = alertsPage.GetAlerTText();
			Assert.AreSame("Hello \n How are you doing today?", result, "Returned wrong text");
		}
	}
}
