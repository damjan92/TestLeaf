using NUnit.Framework;
using TestLeaf.Base;
using TestLeaf.Pages;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestCalendarPage : BaseTest
    {
        [Test]
        public void TestCalendar()
        {
            CalendarPage calendarPage = new CalendarPage(Driver);
            var result = calendarPage.SelectTheDate();
			Assert.AreEqual("12/10/2021", result);
        }
    }
}
