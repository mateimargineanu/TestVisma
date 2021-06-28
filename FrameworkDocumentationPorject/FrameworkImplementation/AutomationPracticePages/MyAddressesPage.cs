using FrameworkImplementation.Utilities;
using OpenQA.Selenium;

namespace FrameworkImplementation.AutomationPracticePages
{
    public class MyAddressesPage : BasePage
    {
        private By MyAddressesTitle = By.XPath("//*[@id='center_column']//*[contains(text(), 'My addresses')]");
        private By AddressFirstName => By.XPath("//*[contains(@class,'col-sm-6 address')]//li[2]/span[1]");
        private By AddressLastName => By.XPath("//*[contains(@class,'col-sm-6 address')]//li[2]/span[2]");
        private By AddressLineOne => By.XPath("//*[contains(@class,'col-sm-6 address')]//span[contains(@class, 'address_address1')]");
        private By AddressCity => By.XPath("//*[contains(@class,'col-sm-6 address')]//li[5]/span[1]");
        private By AddressState = By.XPath("//*[contains(@class,'col-sm-6 address')]//li[5]/span[2]");
        private By AddressZipCode = By.XPath("//*[contains(@class,'col-sm-6 address')]//li[5]/span[3]");
        private By AddressCountry = By.XPath("//*[contains(@class,'col-sm-6 address')]//li[6]/span[1]");
        private By MobilePhoneNumber=> By.XPath("//*[contains(@class,'col-sm-6 address')]//span[contains(@class, 'address_phone_mobile')]");

        public void WaitForPageToBeLoaded() => WaitUtils.WaitForElementVisible(MyAddressesTitle);
        public string GetAddressFirstName() => WaitUtils.WaitForAndGetElement(AddressFirstName).Text;
        public string GetAddressLastName() => WaitUtils.WaitForAndGetElement(AddressLastName).Text;
        public string GetAddressLineOne() => WaitUtils.WaitForAndGetElement(AddressLineOne).Text;
        public string GetAddressCity() => WaitUtils.WaitForAndGetElement(AddressCity).Text;
        public string GetAddressState() => WaitUtils.WaitForAndGetElement(AddressState).Text;
        public string GetAddressZipCode() => WaitUtils.WaitForAndGetElement(AddressZipCode).Text;
        public string GetAddressCountry() => WaitUtils.WaitForAndGetElement(AddressCountry).Text;
        public string GetMobilePhoneNumber() => WaitUtils.WaitForAndGetElement(MobilePhoneNumber).Text;
    }
}
