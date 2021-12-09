using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;
using NUnit.Framework;

namespace TestLeaf.Tests
{
    [TestFixture]
    class TestWaitMethodsPage : BaseTest
    {
        [Test]
        public void TestWaitMethods()
        {
            WaitMethods waitMethods = new WaitMethods(Driver);
            waitMethods.PerformWaitForAlert();
            waitMethods.PerformWaitForChange();
            waitMethods.PerformWaitToAppear();
            waitMethods.PerformWaitToDisappear();
        }
    }
}
