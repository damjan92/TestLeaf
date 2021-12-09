using OpenQA.Selenium;
using TestLeaf.Base;
using TestLeaf.Helpers;

namespace TestLeaf.Pages
{
	class ImagePage : BasePage
	{
		IWebElement HeaderTag => Driver.FindElement(By.TagName("h1"));
		IWebElement ImageLnk => Driver.FindElement(By.CssSelector("a[href='pages/Image.html']"));
		IWebElement ImageIcn => Driver.FindElement(By.CssSelector("img[src='../images/home.png']"));
		IWebElement BrokenImg => Driver.FindElement(By.CssSelector("img[src='../images/abcd.jpg']"));
		IWebElement KeyboardImg => Driver.FindElement(By.XPath("//img[@src='../images/keyboard.png']"));

        public ImagePage(IWebDriver driver) : base(driver)
        {
			Driver = driver;
		}

        public bool HomePageImg()
		{
			CustomMethods.Click(ImageLnk);
			CustomMethods.Click(ImageIcn);
			if (HeaderTag.Displayed)
			{
				LogUtil.Log("Home page Image works");
				Driver.Navigate().Back();
				return true;
			}
			else
			{
				LogUtil.Log("HomePage Image doesnt work");
				return false;
			}
		}

		public bool IsImageLinkWorks()
		{
			CustomMethods.Click(ImageLnk);
			return CustomMethods.IsLinkWorks(BrokenImg, HeaderTag);
		}

		public void ImageKeyboardActions()
		{
			CustomMethods.Click(ImageLnk);
			CustomMethods.KeyboardActions(KeyboardImg, Driver);
		}

	}
}
