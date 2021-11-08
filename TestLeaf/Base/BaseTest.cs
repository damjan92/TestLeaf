using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TestLeaf.Base
{

    public class BaseTest
    {

		public static IWebDriver Driver;

		

        [OneTimeSetUp]
        public static void Prepare()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            Driver = new ChromeDriver(chromeOptions);
        }

        [SetUp]
		public void Setup()
		{
			Driver.Navigate().GoToUrl("http://www.leafground.com/");
			Driver.Manage().Window.Maximize();
			//ChromeOptions chromeOptions = new ChromeOptions();
			//Driver = new ChromeDriver(chromeOptions);
		}

        /*[TearDown]
        public void Assertion()
        {
            Assert.Pass();
        }*/

        [OneTimeTearDown]
        public static void Clean()
        {
            Driver.Close();
        }
    }
}
