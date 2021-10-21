using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestLeaf.Helpers;
using TestLeaf.Pages;

namespace TestLeaf
{
	public class Tests : DriverHelper
	{
		[SetUp]
		public void Setup()
		{
			ChromeOptions chromeOptions = new ChromeOptions();
			Driver = new ChromeDriver(chromeOptions);
			Driver.Navigate().GoToUrl("http://www.leafground.com/");
			Driver.Manage().Window.Maximize();
		}

		//TODO Fix the getText method
		[Test]
		public void Edit()
		{
			EditPage editPage = new EditPage();
			editPage.PerformEditPage("email@email", "appende text");
			Assert.Pass();
		}

		[Test]
		public void Button()
        {
			ButtonPage buttonPage = new ButtonPage();
			buttonPage.PerformButtonPage();
			Assert.Pass();
		}

		[Test]
		public void HyperLinks()
        {
			HyperLinkPage hyperLinkPage = new HyperLinkPage();
			hyperLinkPage.PerformHyperLink();
			Assert.Pass();
        }

		[Test]
		public void ImagePage()
		{
			ImagePage imagePage = new ImagePage();
			imagePage.PerformImagePage();
			Assert.Pass();
		}

		[Test]
		public void DropDown()
        {
			DropdownPage dropdownPage = new DropdownPage();
			dropdownPage.PerformDropdownPage();
			Assert.Pass();
		}

		[Test]
		public void RadioButton()
        {
			RadioButtonPage radioButton = new RadioButtonPage();
			radioButton.PerformRadioButtonPage();
			Assert.Pass();
		}

		[Test]
		public void CheckBox()
        {
			CheckboxPage checkbox = new CheckboxPage();
			checkbox.PerformCheckBoxPage();
			Assert.Pass();
		}

		[Test]
		public void Table()
        {
			TablePage tablePage = new TablePage();
			tablePage.PerformTablePage();
        }

		[Test]
		public void Alert()
        {
			AlertsPage alertsPage = new AlertsPage();
			alertsPage.PerformAlertPage();
			Assert.Pass();
        }

		[Test]
		public void IFrame()
        {
			IFramePage framePage = new IFramePage();
			framePage.PerformIFramePage();
			Assert.Pass();
        }
		
		[Test]
		public void Window()
        {
			WindowPage windowPage = new WindowPage();
			windowPage.PerformWindowPage();
			Assert.Pass();
        }

		[Test]
		public void Calendar()
        {
			CalendarPage calendarPage = new CalendarPage();
			calendarPage.PerformCalendarPage();
			Assert.Pass();
        }

		[Test]
		public void Drag()
        {
			DragPage dragPage = new DragPage();
			dragPage.PerformDragPage();
			Assert.Pass();
        }

		[Test]
		public void Drop()
        {
			DropPage dropPage = new DropPage();
			dropPage.PerformDropPage();
			Assert.Pass();
        }

		[Test]
		public void Selectable()
        {
			SelectablePage selectablePage = new SelectablePage();
			selectablePage.PerformSelectablePage();
			Assert.Pass();
        }

		[Test]
		public void Sortable()
        {
			SortablePage sortablePage = new SortablePage();
			sortablePage.PerformSortablePage();
			Assert.Pass();
        }

		[Test]
		public void AutoComplete()
        {
			AutocompletePage autocompletePage = new AutocompletePage();
			autocompletePage.PerformAutocompletePage();
        }

		[Test]
		public void Download()
        {
			DownloadPage downloadPage = new DownloadPage();
			downloadPage.PerfromDownloadPage();
			Assert.Pass();
        }

		[Test]
		public void Upload()
		{
			UploadPage uploadPage = new UploadPage();
			uploadPage.PerformUploadPage();	
		}

		[Test]
		public void ToolTip()
        {
			ToolTipPage toolTip = new ToolTipPage();
			toolTip.PerformToolTipPage();
        }

		[Test]
		public void WaitTo()
        {
			WaitMethods waitToDisappear = new WaitMethods();
            waitToDisappear.PerformWaitToDisappear();
            waitToDisappear.PerformWaitToAppear();
            waitToDisappear.PerformWaitForChange();
        }

		[TearDown]
		public void Clean()
        {
			Driver.Quit();
        }
	}
}