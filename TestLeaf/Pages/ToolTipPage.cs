using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Threading;
using TestLeaf.Helpers;
using OpenQA.Selenium.Interactions;
using TestLeaf.Base;

namespace TestLeaf.Pages
{
    class ToolTipPage : BasePage
    {
        IWebElement ToolTipClk => Driver.FindElement(By.CssSelector("a[href = 'pages/tooltip.html']"));

        IWebElement getLocation => Driver.FindElement(By.CssSelector("#age"));

        public ToolTipPage(IWebDriver Driver) : base(Driver)
        {
        }

        public void Hover()
        {
           
            Actions actions = new Actions(Driver);

            actions.MoveToElement(getLocation).Build().Perform();
        }

        public void PerformToolTipPage()
        {
            CustomMethods.Click(ToolTipClk);
            Hover();
            Thread.Sleep(1000);
        }
    }
}
