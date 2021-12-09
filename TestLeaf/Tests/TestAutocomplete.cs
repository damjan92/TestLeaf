﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestLeaf.Base;
using TestLeaf.Pages;

namespace TestLeaf.Tests
{
	[TestFixture]
	class TestAutocompletePage : BaseTest
	{
		[Test]
		public void TestAutocomplete()
		{
			AutocompletePage autocompletePage = new AutocompletePage(Driver);
			autocompletePage.PerformAutocompletePage();
		}
	}
}
