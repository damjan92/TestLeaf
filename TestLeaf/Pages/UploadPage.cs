using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Threading;
using TestLeaf.Helpers;
using TestLeaf.Base;

namespace TestLeaf.Pages
{
	class UploadPage : BasePage
	{
		IWebElement UploadClk => Driver.FindElement(By.CssSelector("a[href='pages/upload.html']"));
		IWebElement browse => Driver.FindElement(By.CssSelector("input[name='filename']"));

        public UploadPage(IWebDriver Driver) : base(Driver)
        {
        }

        public void Uploading()
        {
			string FileLocation = @"C:\Users\DamjanDosen\Downloads\testleaf.xlsx";

			CustomMethods.EnterText(browse, FileLocation);
		}

		public void PerformUploadPage()
        {
			CustomMethods.Click(UploadClk);
			Uploading();
			Thread.Sleep(500);
		}
	}
}
