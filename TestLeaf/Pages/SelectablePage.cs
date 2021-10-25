using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestLeaf.Pages
{
    class SelectablePage : DriverHelper
    {
        IWebElement SelectableClk => Driver.FindElement(By.CssSelector("a[href='pages/selectable.html']"));

        IWebElement StartLocation => Driver.FindElement(By.CssSelector("div[id='content'] li:nth-child(1)"));

        CustomMethods customMethods = new CustomMethods();

        public void Selecting()
        {
            Actions actions = new Actions(Driver);
            actions.ClickAndHold(StartLocation).MoveByOffset(0, 200).Release()
                .Build()
                .Perform();
        }

        public void PerformSelectablePage()
        {
            customMethods.Click(SelectableClk);
            Selecting();
        }
    }
}
