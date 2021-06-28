using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System.Linq;

namespace FrameworkImplementation
{
    public static class Browser1
    {
        public static IWebDriver webDriver = new FirefoxDriver(@"C:\geckodriver");
        
        public static void Goto(string url)
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Url = url;
        }
     
        public static void SwitchToLastWindow() => webDriver.SwitchTo().Window(webDriver.WindowHandles.Last());

        public static void CloseBrowser()
        {
            webDriver.Quit();
        }
    }
}