using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Threading;
using TestLeaf.Helpers;
using OpenQA.Selenium.Interactions;

namespace TestLeaf.Pages
{
    class ToolTipPage : DriverHelper
    {
        IWebElement ToolTipClk => Driver.FindElement(By.CssSelector("a[href = 'pages/tooltip.html']"));

        IWebElement getLocation => Driver.FindElement(By.CssSelector("#age"));

        CustomMethods customMethods = new CustomMethods();

       public void Hover()
        {
           
            Actions actions = new Actions(Driver);

            actions.MoveToElement(getLocation).Build().Perform();
        }

        public void PerformToolTipPage()
        {
            customMethods.Click(ToolTipClk);
            Hover();
            Thread.Sleep(1000);
        }
    }
}
