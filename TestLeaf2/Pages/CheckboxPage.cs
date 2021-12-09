using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TestLeaf.Base;
using TestLeaf.Helpers;

namespace TestLeaf.Pages
{
	class CheckboxPage : BasePage
	{
		public CheckboxPage(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}

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
	


		public bool SelectLng()
		{
			CustomMethods.Click(clickCheckbox);
			CustomMethods.Click(selectJava);
			CustomMethods.Click(selectVB);
			if (selectVB.Selected == true)
			{
				LogUtil.Log("Languages are selected");
				return true;
			}
			else
			{
				LogUtil.Log("Checkbox is not selected");
				return false;
			}
		}

		public bool IsSelected()
		{
			CustomMethods.Click(clickCheckbox);
			if (IsSeleneiumSlctd.Selected == true)
			{
				LogUtil.Log("Checkbox is selected");
				return true;
			}
			else
			{
				LogUtil.Log("Checkbox is not selected");
				return false;
			}
		}

		public bool Deselect()
		{
			CustomMethods.Click(clickCheckbox);
			if (deselectCb.Selected == true)
			{
				LogUtil.Log("Checkbox is already selected");
				return true;
			}
			else
			{
				LogUtil.Log("Checkbox is not selected, Click!");
				CustomMethods.Click(deselectCb);
				return false;
			}
		}

		public void SelectAll()
		{
			//ToDo
		}

		public void PerformCheckBoxPage()
		{
			CustomMethods.Click(clickCheckbox);
			SelectLng();
			IsSelected();
			Deselect();
		}
	}
}
