using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TestLeaf.Base;

namespace TestLeaf.Pages
{
    class SelectablePage : BasePage
    {
        IWebElement SelectableClk => Driver.FindElement(By.CssSelector("a[href='pages/selectable.html']"));

        IWebElement StartLocation => Driver.FindElement(By.CssSelector("div[id='content'] li:nth-child(1)"));

        public SelectablePage(IWebDriver Driver) : base(Driver)
        {
        }

        public void Selecting()
        {
            Actions actions = new Actions(Driver);
            actions.ClickAndHold(StartLocation).MoveByOffset(0, 200).Release()
                .Build()
                .Perform();
        }

        public void PerformSelectablePage()
        {
            CustomMethods.Click(SelectableClk);
            Selecting();
        }
    }
}
