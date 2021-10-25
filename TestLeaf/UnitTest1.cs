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
		public void TestEdit()
		{
			EditPage editPage = new EditPage();
			editPage.PerformEditPage("email@email", "appende text");
			Assert.Pass();
		}

		[Test]
		public void TestButton()
        {
			ButtonPage buttonPage = new ButtonPage();
			buttonPage.PerformButtonPage();
			Assert.Pass();
		}

		[Test]
		public void TestHyperLinks()
        {
			HyperLinkPage hyperLinkPage = new HyperLinkPage();
			hyperLinkPage.PerformHyperLink();
			Assert.Pass();
        }

		[Test]
		public void TestImagePage()
		{
			ImagePage imagePage = new ImagePage();
			imagePage.PerformImagePage();
			Assert.Pass();
		}

		[Test]
		public void TestDropDown()
        {
			DropdownPage dropdownPage = new DropdownPage();
			dropdownPage.PerformDropdownPage();
			Assert.Pass();
		}

		[Test]
		public void TestRadioButton()
        {
			RadioButtonPage radioButton = new RadioButtonPage();
			radioButton.PerformRadioButtonPage();
			Assert.Pass();
		}

		[Test]
		public void TestCheckBox()
        {
			CheckboxPage checkbox = new CheckboxPage();
			checkbox.PerformCheckBoxPage();
			Assert.Pass();
		}

		[Test]
		public void TestTable()
        {
			TablePage tablePage = new TablePage();
			tablePage.PerformTablePage();
        }

		[Test]
		public void TestAlert()
        {
			AlertsPage alertsPage = new AlertsPage();
			alertsPage.PerformAlertPage();
			Assert.Pass();
        }

		[Test]
		public void TestIFrame()
        {
			IFramePage framePage = new IFramePage();
			framePage.PerformIFramePage();
			Assert.Pass();
        }
		
		[Test]
		public void TestWindow()
        {
			WindowPage windowPage = new WindowPage();
			windowPage.PerformWindowPage();
			Assert.Pass();
        }

		[Test]
		public void TestCalendar()
        {
			CalendarPage calendarPage = new CalendarPage();
			calendarPage.PerformCalendarPage();
			Assert.Pass();
        }

		[Test]
		public void TestDrag()
        {
			DragPage dragPage = new DragPage();
			dragPage.PerformDragPage();
			Assert.Pass();
        }

		[Test]
		public void TestDrop()
        {
			DropPage dropPage = new DropPage();
			dropPage.PerformDropPage();
			Assert.Pass();
        }

		[Test]
		public void TestSelectable()
        {
			SelectablePage selectablePage = new SelectablePage();
			selectablePage.PerformSelectablePage();
			Assert.Pass();
        }

		[Test]
		public void TestSortable()
        {
			SortablePage sortablePage = new SortablePage();
			sortablePage.PerformSortablePage();
			Assert.Pass();
        }

		[Test]
		public void TestAutoComplete()
        {
			AutocompletePage autocompletePage = new AutocompletePage();
			autocompletePage.PerformAutocompletePage();
        }

		[Test]
		public void TestDownload()
        {
			DownloadPage downloadPage = new DownloadPage();
			downloadPage.PerfromDownloadPage();
			Assert.Pass();
        }

		[Test]
		public void TestUpload()
		{
			UploadPage uploadPage = new UploadPage();
			uploadPage.PerformUploadPage();	
		}

		[Test]
		public void TestToolTip()
        {
			ToolTipPage toolTip = new ToolTipPage();
			toolTip.PerformToolTipPage();
        }

		[Test]
		public void TestWaitTo()
        {
			WaitMethods waitToDisappear = new WaitMethods();
            waitToDisappear.PerformWaitToDisappear();
            waitToDisappear.PerformWaitToAppear();
            waitToDisappear.PerformWaitForChange();
            waitToDisappear.PerformWaitForAlert();
        }

		[Test]
		public void TestMouseHover()
        {
			MouseHoverPage mouseHover = new MouseHoverPage();
			mouseHover.PerformHover();
        }

		[Test]
		public void TestWebTable()
        {
			WebTablePage webTable = new WebTablePage();
			webTable.PerformWebTeblePage();
        }

		[TearDown]
		public void Clean()
        {
			Driver.Quit();
        }
	}
}