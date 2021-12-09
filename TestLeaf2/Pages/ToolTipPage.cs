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

        IWebElement GetLocation => Driver.FindElement(By.CssSelector("#age"));

        public ToolTipPage(IWebDriver driver) : base(driver)
        {
			Driver = driver;
        }

        public string Hover()
        {
			CustomMethods.Click(ToolTipClk);

			Actions actions = new Actions(Driver);

            actions.MoveToElement(GetLocation).SendKeys("Age").Build().Perform();

			return CustomMethods.GetText(GetLocation);
        }

        
    }
}
