using OpenQA.Selenium;

namespace FrameworkImplementation.Way2automation
{
    public class Way2AutomationPracticePage : BasePage
    {
        private By DatePicker => By.XPath("*//a[@href = 'datepicker.php']/figure/img");

        public void ClickDatePicker()
        {
            WaitUtils.WaitForAndClick(DatePicker);
            Browser2.SwitchToLastWindow();
        }
    }
}
