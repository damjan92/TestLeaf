using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TestLeaf.Helpers;

namespace TestLeaf.Pages
{
	class CheckboxPage : DriverHelper
	{
		IWebElement clickCheckbox => Driver.FindElement(By.XPath("//a[@href='pages/checkbox.html']"));
		IWebElement selectJava => Driver.FindElement(By.XPath
			("//div[normalize-space()='Java']//input[@type='checkbox']"));
		IWebElement selectVB => Driver.FindElement(By.XPath
			("//div[normalize-space()='VB']//input[@type='checkbox']"));
		IWebElement IsSeleneiumSlctd => Driver.FindElement(By.XPath
			("//div[normalize-space()='Selenium']//input[@type='checkbox']"));
		IWebElement deselectCb => Driver.FindElement(By.XPath
			("//div[normalize-space()='I am Selected']//input[@type='checkbox']"));
		IWebElement optionOne => Driver.FindElement(By.XPath
			("//div[normalize-space()='Option 1']//input[@type='checkbox']"));
	

        CustomMethods customMethods = new CustomMethods();
		CustomLogger customLogger = new CustomLogger();

		public void SelectLng()
		{
			customMethods.Click(selectJava);
			customMethods.Click(selectVB);
			customLogger.LogInfo("Languages are selected");
		}

		public bool IsSelected()
		{
			if(IsSeleneiumSlctd.Selected == true)
			{
				customLogger.LogInfo("Checkbox is selected");
				return true;
			}
			else
			{
				customLogger.LogWarn("Checkbox is not selected");
				return false;
			}
		}

		public bool Deselect()
        {
			if (deselectCb.Selected == true)
            {
				customLogger.LogInfo("Checkbox is already selected");
				return true;
            }
			else
            {
				customLogger.LogWarn("Checkbox is not selected, Click!");
				customMethods.Click(deselectCb);
				return false;
			}
        }

		public void SelectAll()
        {
			//ToDo
		}

		public void PerformCheckBoxPage()
		{
			customMethods.Click(clickCheckbox);
			SelectLng();
			IsSelected();
			Deselect();
		}
	}
}
