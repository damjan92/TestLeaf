using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
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
            calendarPage.PerformCalendarPage();
        }
    }
}
