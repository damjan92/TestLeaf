using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Helpers;
using OpenQA.Selenium;
using System.Threading;

namespace TestLeaf.Pages
{
    class DropdownPage : DriverHelper
    {
        IWebElement dropdownIcon => Driver.FindElement(By.CssSelector("a[href='pages/Dropdown.html']"));
        IWebElement firstDropdown => Driver.FindElement(By.CssSelector("#dropdown1"));
        IWebElement secondDropdown => Driver.FindElement(By.CssSelector("select[name='dropdown2']"));
        IWebElement thirdDropdown => Driver.FindElement(By.CssSelector("#dropdown3"));
        IWebElement sumOfOption => Driver.FindElement(By.CssSelector(".dropdown"));
        IWebElement sendKeysDdm => Driver.FindElement(By.XPath("//div[5]//select[1]"));
        IWebElement dropdownOneClick => Driver.FindElement(By.XPath("//div[6]//select[1]//option[4]"));

        CustomMethods customMethods = new CustomMethods();

       
        public void PerformDropdownPage()
        {
            customMethods.Click(dropdownIcon);
            customMethods.SelectElementByIndex(firstDropdown, 1);
            customMethods.SelectElementByText(secondDropdown, "Selenium");
            customMethods.SelectElementByValue(thirdDropdown, "2");
            customMethods.AmountOfOption(sumOfOption);
            customMethods.EnterText(sendKeysDdm, "Appium");
            //customMethods.SelectElementByValue(dropdownOneClick, "3");
            Thread.Sleep(2000);
        }
    }
}
