using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestRadioButtonPage : BaseTest
    {
        [Test]
        public void TestRadioButton()
        {
            RadioButtonPage radioButtonPage = new RadioButtonPage(Driver);
            radioButtonPage.PerformRadioButtonPage();
        }
    }
}
