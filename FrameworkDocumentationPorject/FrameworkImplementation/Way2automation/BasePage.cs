using FrameworkImplementation.Utilities;
using OpenQA.Selenium;

namespace FrameworkImplementation.Way2automation
{
    public class BasePage
    {
        public IWebDriver Driver;
        public WaitUtils WaitUtils;

        public BasePage()
        {
            Driver = Browser2.webDriver;
            WaitUtils = new WaitUtils(Driver);
        }
    }
}
