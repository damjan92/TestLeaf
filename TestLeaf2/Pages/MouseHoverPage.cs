using OpenQA.Selenium;
using TestLeaf.Helpers;
using OpenQA.Selenium.Interactions;
using TestLeaf.Base;

namespace TestLeaf.Pages
{
	enum TypeOfServices
	{
		Selenium,
		RPA,
		WebServices,
		None
	}

	class MouseHoverPage : BasePage
	{

		IWebElement HoverClk => Driver.FindElement(By.CssSelector("a[href='pages/mouseOver.html']"));
		IWebElement HoverLocation => Driver.FindElement(By.CssSelector(".btnMouse"));
		IWebElement HiddenMenuSelenium => Driver.FindElement(By.LinkText("Selenium"));

		public MouseHoverPage(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}

		public TypeOfServices Hovering()
		{
			CustomMethods.Click(HoverClk);
			Actions actions = new Actions(Driver);
			actions.MoveToElement(HoverLocation)
				.Build()
				.Perform();

            CustomMethods.Click(HiddenMenuSelenium);
            var alert = Driver.SwitchTo().Alert();
           
			if (alert.Text.Contains("Selenium"))
            {
				LogUtil.Log("You selected selenium");
				alert.Accept();
				return TypeOfServices.Selenium;
            } else
            {
				LogUtil.Log("You did not selected selenium");
				alert.Accept();
				return TypeOfServices.None;
            }
			
		}
	}
}
