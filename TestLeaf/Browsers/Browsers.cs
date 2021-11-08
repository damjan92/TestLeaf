using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestLeaf.Browsers
{
    class Browsers
    {
        public Browsers(IWebDriver Driver, string browser)
        {
            Driver = Driver;
            browser = browser;
        }

        public void getBrowser()
        {

        }
    }
}
