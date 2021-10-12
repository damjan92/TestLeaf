﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using TestLeaf.Helpers;

namespace TestLeaf.Pages
{
	class TablePage : DriverHelper
	{
		IWebElement Tableclick => Driver.FindElement(By.XPath("//a[@href='pages/table.html']"));
		IList<IWebElement> tableRows => Driver.FindElements(By.TagName("tr"));
		IList<IWebElement> tableCols => Driver.FindElements(By.TagName("th"));
		IWebElement valueTd => Driver.FindElement(By.XPath("//tbody/tr[3]/td[2]"));
		IList<IWebElement> valueCols => Driver.FindElements(By.CssSelector("tbody tr td:nth-child(2)"));


		CustomMethods customMethods = new CustomMethods();

		public void NumOfRows()
		{
			Console.WriteLine("Numbers of rows: " + tableRows.Count);
		}

		public void NumOfCols()
		{
			Console.WriteLine("Numbers of collumns: " + tableCols.Count);
		}

		public string GetTheProgress()
		{
			Console.WriteLine("The value is: " + valueTd.Text);
			return valueTd.Text;
		}

		public void CompletedProgress()
		{
			foreach (IWebElement items in valueCols)
			{
				if (items.Text.Contains("100"))
				{
					Console.WriteLine(items.Text);
				}
			}
		}

		public void PerformTablePage()
		{
			customMethods.Click(Tableclick);
			NumOfRows();
			NumOfCols();
			GetTheProgress();
			CompletedProgress();
		}
	}
}
