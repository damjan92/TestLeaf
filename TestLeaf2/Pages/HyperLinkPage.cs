using TestLeaf.Helpers;
using OpenQA.Selenium;
using TestLeaf.Base;

namespace TestLeaf.Pages
{
    class HyperLinkPage : BasePage
    {
        public HyperLinkPage(IWebDriver driver) : base(driver)
        {
			Driver = driver;
        }

        IWebElement HyperLinkClk => Driver.FindElement(By.XPath("//a[@href='pages/Link.html']"));
        IWebElement Homepagelnk => Driver.FindElement(By.XPath("//div[@id='contentblock']//div[1]//div[1]//div[1]//a[1]"));
		IWebElement HeaderTag => Driver.FindElement(By.TagName("h1"));
		IWebElement DestinationLnk => Driver.FindElement(By.PartialLinkText("Find where am suppos"));
		IWebElement IsBroken => Driver.FindElement(By.CssSelector("a[href='error.html']"));
		IWebElement HttpStatus => Driver.FindElement(By.TagName("h1"));


		public bool HomePageLink()
		{
			CustomMethods.Click(HyperLinkClk);
			CustomMethods.Click(Homepagelnk);
			if (HeaderTag.Displayed)
			{
				LogUtil.Log("Home page link works");
				Driver.Navigate().Back();
				return true;
			}
			else
			{
				LogUtil.Log("HomePage link doesnt work");
				CustomMethods.TakeScreenshot(Homepagelnk);
				return false;
			}
		}

		public string CheckDestination()
        {
			CustomMethods.Click(HyperLinkClk);
			CustomMethods.Click(DestinationLnk);
			string dest = Driver.Url;
			LogUtil.Log("URL is: " + dest);
			Driver.Navigate().Back();
			return dest;
		}

		public bool CheckAvailability()
        {
			CustomMethods.Click(HyperLinkClk);
			CustomMethods.Click(IsBroken);
			if (HttpStatus.Text.Contains("404"))
            {
				LogUtil.Log("Site is not available, msg is 404");
				Driver.Navigate().Back();
				return false;
            } 
			else
            {
				LogUtil.Log("Site is available");
				return true;
			}
        }
		
	}
}
