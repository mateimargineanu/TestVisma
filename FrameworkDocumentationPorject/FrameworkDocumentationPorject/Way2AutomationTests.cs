using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using FrameworkImplementation;
using FrameworkImplementation.Utilities;
using FluentAssertions.Execution;
using FrameworkImplementation.Way2automation;

namespace FrameworkDocumentationPorject
{
    [TestClass]
    public class Way2AutomationTests 
    {
        public HomePage HomePage = new HomePage();
        public Way2AutomationPracticePage Way2AutomationPracticePage = new Way2AutomationPracticePage();
        public DatePickerPage DatePickerPage = new DatePickerPage();


        [DoNotParallelize]
        [TestMethod]
        public void Way2AutomationDatePickerTest()
        {
            DateTime today = DateTime.Today;
            HomePage.GotoHomePage();
            HomePage.ClickEnterTestingWebsite();
            Way2AutomationPracticePage.ClickDatePicker();
            DatePickerPage.ClickFormatDateTab();
            DatePickerPage.SelectCurrentDate(today);
            DatePickerPage.SelectFormatOption("ISO 8601 - yy-mm-dd");
            var expectedDate = today.ToString("yyyy-MM-dd");
            DatePickerPage.GetSelectedDate().ToString().Should().Match(expectedDate);
        }

        [TestCleanup]
        public void Cleanup()
        {
            Browser2.CloseBrowser();
        }
    }
}
