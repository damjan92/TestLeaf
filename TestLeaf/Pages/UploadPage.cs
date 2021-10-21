using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Threading;
using TestLeaf.Helpers;


namespace TestLeaf.Pages
{
	class UploadPage : DriverHelper
	{
		IWebElement UploadClk => Driver.FindElement(By.CssSelector("a[href='pages/upload.html']"));
		IWebElement browse => Driver.FindElement(By.CssSelector("input[name='filename']"));

		CustomMethods customMethods = new CustomMethods();

		public void Uploading()
        {
			string FileLocation = @"C:\Users\DamjanDosen\Downloads\testleaf.xlsx";

			customMethods.EnterText(browse, FileLocation);
		}

		public void PerformUploadPage()
        {
			customMethods.Click(UploadClk);
			Uploading();
			Thread.Sleep(500);
		}
	}
}
