using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace FrameworkImplementation.Utilities
{
    public class WaitUtils
    {
        private readonly TimeSpan _timeout; 
        private readonly TimeSpan _pollingInterval;
        private readonly TimeSpan _initialSleep;
        private readonly IWebDriver _driver;
        public WaitUtils(IWebDriver driver)
        {
            _driver = driver;
            _pollingInterval = new TimeSpan(0, 0, 1);
            _initialSleep = new TimeSpan(0, 0, 1);
            _timeout = new TimeSpan(0, 1, 0);
        }
        public TResult WaitUntil<TResult>(Func<IWebDriver, TResult> condition, params Type[] ignoreExceptionTypes)
        {
            Thread.Sleep(_initialSleep);

            var webDriverWait = new WebDriverWait(_driver, _timeout);
            webDriverWait.PollingInterval = _pollingInterval;
            webDriverWait.IgnoreExceptionTypes(ignoreExceptionTypes);

            return webDriverWait.Until(condition);
        }

        public void WaitForAndSendKeys(By locator, string keys) => WaitForAndSendKeys(() => _driver.FindElement(locator), keys);
        public void WaitForAndSendKeys(Func<IWebElement> getElement, string keys)
        {
            WaitUntil(driver =>
            {
                var element = getElement();
                element.Clear();
                element.SendKeys(keys);
                return true;
            });
        }

        public void WaitForAndClick(By locator) => WaitForAndClick(() => _driver.FindElement(locator));

        public void WaitForAndClick(Func<IWebElement> getElement)
        {
            WaitUntil(_ =>
            {
                getElement().Click();
                return true;
            });
        }

        public void WaitForElementVisible(By locator) => WaitForElementVisible(() => _driver.FindElement(locator));

        public void WaitForElementVisible(Func<IWebElement> getElement)
        {
            WaitUntil(_ =>
            {
                var element = getElement();
                return element != null && element.Displayed;
            });
        }

        public IWebElement WaitForAndGetElement(By locator) => WaitForAndGetElement(() => _driver.FindElement(locator));

        public IWebElement WaitForAndGetElement(Func<IWebElement> getElement) => WaitUntil(_ => getElement());
        public SelectElement WaitForAndGetSelectElement(By locator) => WaitForAndGetSelectElement(() => _driver.FindElement(locator));

        public SelectElement WaitForAndGetSelectElement(Func<IWebElement> getElement)
        {
            var element = WaitForAndGetElement(getElement);
            return new SelectElement(element);
        }
    }
}
