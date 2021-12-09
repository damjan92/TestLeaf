using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using TestLeaf.Base;
using TestLeaf.Helpers;

namespace TestLeaf.Pages
{
	class RadioButtonPage : BasePage
	{
		IWebElement radioButtonIcn => Driver.FindElement(By.CssSelector("a[href='pages/radio.html']"));
		IWebElement yesOption => Driver.FindElement(By.CssSelector("#yes"));
		IWebElement defaultBtn => Driver.FindElement(By.XPath("//div[@id='contentblock']//div[2]//div[1]//div[1]"));
		IWebElement uncheckedBtn => Driver.FindElement(By.XPath("//label[normalize-space()='Unchecked']"));
		IWebElement AgeButtons => Driver.FindElement(By.XPath("//div[@id='contentblock']//div[3]//div[1]//div[1]"));
		IWebElement firstValue => Driver.FindElement(By.CssSelector("input[value='0'][name='age']"));
		IWebElement secondValue => Driver.FindElement(By.XPath("//input[2]"));
		IWebElement thirdValue => Driver.FindElement(By.XPath("//input[@value='2']"));


        public RadioButtonPage(IWebDriver Driver) : base(Driver)
        {
        }

        public void DefaultBtn()
        {
			if (defaultBtn.Text.Contains("Checked"))
            {
				LogUtil.Log("Check button is already clicked");
            } else
            {
				LogUtil.Log("Uncheck button is unchecked");
				CustomMethods.Click(uncheckedBtn);
            }
        }

		public void AgeChecker()
        {
			if (AgeButtons.Text.Contains("21"))
			{
				LogUtil.Log("My group age is clicked");
            }
			else if (AgeButtons.Text.Contains("20"))
            {
				CustomMethods.Click(firstValue);
				LogUtil.Log("1-20 group age is selected");
            }
			else
            {
				CustomMethods.Click(thirdValue);
				LogUtil.Log("Above 40 group age is selected");
			}
        }

		public void PerformRadioButtonPage()
		{
			CustomMethods.Click(radioButtonIcn);
			CustomMethods.Click(yesOption);
			DefaultBtn();
			AgeChecker();
		}
	}
}
