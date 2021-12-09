using System.Collections.Generic;
using OpenQA.Selenium;
using TestLeaf.Base;
using TestLeaf.Helpers;

namespace TestLeaf.Pages
{
	class TablePage : BasePage
	{
		IWebElement Tableclick => Driver.FindElement(By.XPath("//a[@href='pages/table.html']"));
		IList<IWebElement> TableRows => Driver.FindElements(By.TagName("tr"));
		IList<IWebElement> TableCols => Driver.FindElements(By.TagName("th"));
		IWebElement ValueTd => Driver.FindElement(By.XPath("//tbody/tr[3]/td[2]"));
		IList<IWebElement> ValueCols => Driver.FindElements(By.CssSelector("tbody tr td:nth-child(2)"));

        public TablePage(IWebDriver driver) : base(driver)
        {
			Driver = driver;
        }

        public int NumOfRows()
		{
			CustomMethods.Click(Tableclick);
			LogUtil.Log("Numbers of rows: " + TableRows.Count);
			return TableRows.Count;
		}

		public int NumOfCols()
		{
			CustomMethods.Click(Tableclick);
			LogUtil.Log("Numbers of collumns: " + TableCols.Count);
			return TableCols.Count;
		}

		public string GetTheProgress()
		{
			CustomMethods.Click(Tableclick);
			LogUtil.Log("The value is: " + CustomMethods.GetText(ValueTd));
			return ValueTd.Text;
		}

		public string CompletedProgress()
		{
			CustomMethods.Click(Tableclick);
			foreach (IWebElement items in ValueCols)
			{
				if (items.Text.Contains("100"))
				{
					return CustomMethods.GetText(items);
				}
			}
			return null;
		}

	}
}
