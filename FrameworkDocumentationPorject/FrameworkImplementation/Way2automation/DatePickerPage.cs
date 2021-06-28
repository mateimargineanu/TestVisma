using OpenQA.Selenium;
using System;

namespace FrameworkImplementation.Way2automation
{
    public class DatePickerPage : BasePage
    {

        private readonly By _formatDateTab = By.XPath(".//a[contains(text(), 'Format date')]");
        private readonly By _dateInputField = By.Id("datepicker");
        private readonly By _formatDateFrameLocator = By.XPath(".//*[@id='example-1-tab-4']//iframe");
        private readonly By _formatOptionsDropDown = By.Id("format");
        private Func<int, By> DayLocator = day => By.XPath($".//*[contains(@class,'ui-datepicker-calendar')]//a[contains(text(),'{day}')]");

        public void ClickFormatDateTab()
        {
            WaitUtils.WaitForAndClick(_formatDateTab);
            Driver.SwitchTo().Frame(WaitUtils.WaitForAndGetElement(_formatDateFrameLocator));
        }
        public void SelectCurrentDate(DateTime date)
        {
            WaitUtils.WaitForAndClick(_dateInputField);
            WaitUtils.WaitForAndClick(DayLocator(date.Day));
        }
        public void SelectFormatOption(string option) => WaitUtils.WaitForAndGetSelectElement(_formatOptionsDropDown).SelectByText(option);
        public string GetSelectedDate() => WaitUtils.WaitForAndGetElement(_dateInputField).GetAttribute("value");

    }
}
