using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Helpers;
using TestLeaf.Pages;
using TestLeaf.Base;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestAletsPage : BaseTest
    {
        
        [Test]
        public void AlertTest ()
        {
            AlertsPage alertsPage = new AlertsPage(Driver);
            alertsPage.PerformAlertPage();
        }
    }
}
