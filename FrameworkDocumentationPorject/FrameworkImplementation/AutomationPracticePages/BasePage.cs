using FrameworkImplementation.Utilities;
using OpenQA.Selenium;

namespace FrameworkImplementation.AutomationPracticePages
{
    public class BasePage
    {
        public IWebDriver Driver;
        public WaitUtils WaitUtils;

        public BasePage()
        {
            Driver = Browser1.webDriver;
            WaitUtils = new WaitUtils(Driver);
        }
    }
}
