﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using TestLeaf.Helpers;

namespace TestLeaf.Pages
{
	class RadioButtonPage : DriverHelper
	{
		IWebElement radioButtonIcn => Driver.FindElement(By.CssSelector("a[href='pages/radio.html']"));
		IWebElement yesOption => Driver.FindElement(By.CssSelector("#yes"));
		IWebElement defaultBtn => Driver.FindElement(By.XPath("//div[@id='contentblock']//div[2]//div[1]//div[1]"));
		IWebElement uncheckedBtn => Driver.FindElement(By.XPath("//label[normalize-space()='Unchecked']"));
		IWebElement AgeButtons => Driver.FindElement(By.XPath("//div[@id='contentblock']//div[3]//div[1]//div[1]"));
		IWebElement firstValue => Driver.FindElement(By.CssSelector("input[value='0'][name='age']"));
		IWebElement secondValue => Driver.FindElement(By.XPath("//input[2]"));
		IWebElement thirdValue => Driver.FindElement(By.XPath("//input[@value='2']"));

		CustomMethods customMethods = new CustomMethods();

		public void DefaultBtn()
        {
			if (defaultBtn.Text.Contains("Checked"))
            {
                Console.WriteLine("Check button is already clicked");
            } else
            {
                Console.WriteLine("Uncheck button is unchecked");
				customMethods.Click(uncheckedBtn);
            }
        }

		public void AgeChecker()
        {
			if (AgeButtons.Text.Contains("21"))
			{
                Console.WriteLine("My group age is clicked");
            }
			else if (AgeButtons.Text.Contains("20"))
            {
				customMethods.Click(firstValue);
                Console.WriteLine("1-20 group age is selected");
            }
			else
            {
				customMethods.Click(thirdValue);
				Console.WriteLine("Above 40 group age is selected");
			}
        }

		public void PerformRadioButtonPage()
		{
			customMethods.Click(radioButtonIcn);
			customMethods.Click(yesOption);
			DefaultBtn();
			AgeChecker();
			Thread.Sleep(1500);
		}
	}
}
