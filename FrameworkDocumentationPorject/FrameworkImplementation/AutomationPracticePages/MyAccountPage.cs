using FrameworkImplementation.Utilities;
using OpenQA.Selenium;

namespace FrameworkImplementation.AutomationPracticePages
{
    public class MyAccountPage : BasePage
    {
        private By MyAccountTitle = By.XPath("//*[@id='center_column']//*[contains(text(), 'My account')]");
        private By MyAddressesButton = By.XPath("//a/span[contains(text(),'My addresses')]");
       
        public bool ConfirmPage()
        {
            return Driver.Title == "My account - My Store";
        }
        public void WaitForPageToBeLoaded() => WaitUtils.WaitForElementVisible(MyAccountTitle);
        public void ClickOnMyAddresses() => WaitUtils.WaitForAndClick(MyAddressesButton);
    }
}