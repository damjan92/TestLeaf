using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.IO;
using TestLeaf.Base;

namespace TestLeaf.Pages
{
	class DownloadPage : BasePage
	{
        public DownloadPage(IWebDriver Driver) : base(Driver)
        {
        }

        IWebElement DownloadClk => Driver.FindElement(By.CssSelector("a[href='pages/download.html']"));
		IWebElement XlxDownload => Driver.FindElement(By.LinkText("Download Excel"));


		public void VerifyFileDownload()
		{
			string expectedPath = @"C:\Users\DamjanDosen\Downloads\testleaf.xlsx";
			bool IsFileExist = false;

			ChromeOptions chromeOptions = new ChromeOptions();
			chromeOptions.AddUserProfilePreference("download.default_directory", @"c:\downloads");

			CustomMethods.Click(XlxDownload);
			WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
			wait.Until<bool>(x => IsFileExist = File.Exists(expectedPath));

			if (File.Exists(expectedPath) == true)
			{
				LogUtil.Log("File are downloaded");
			} else
			{
				LogUtil.Log("File are not downloaded");
			}
		}

		public void PerfromDownloadPage()
		{
			CustomMethods.Click(DownloadClk);
			VerifyFileDownload();
		}
	}
}
