using System;
using FrameworkImplementation.Utilities;
using OpenQA.Selenium;

namespace FrameworkImplementation.AutomationPracticePages
{
    public class LoginAndRegPage : BasePage
    {
        private By LoginEmailField => By.XPath("//input[@id='email']");
        private By SignUpEmailField => By.XPath("//*[@id='email_create']");
        private By PasswordField => By.Id("passwd");
        private By AuthenticationSection => By.XPath("//*[@id='center_column']/h1[contains(text(), 'Authentication')]");
        private By SignUpButton => By.XPath("//*[@id='SubmitCreate']/span");
        private By PersonalInformationSection => By.XPath("//*[@id='account-creation_form']//h3[contains(text(), 'Your personal information')]");
        private By CustomerFirstNameInputField => By.Id("customer_firstname");
        private By CustomerLastNameInputField => By.Id("customer_lastname");
        private By AddressFirstNameInputField => By.Id("firstname");
        private By AddressLastNameInputField => By.Id("lastname");
        private By CityInputField => By.Id("city");
        private By StateDropDown = By.Id("id_state");
        private By ZipCodeInputField = By.Id("postcode");
        private By CountryDropDown = By.Id("id_country");
        private By MobilePhoneNumberInputField => By.Id("phone_mobile");
        private By RegisterButton => By.Id("submitAccount");
        private Func<int, By> Title = genderID => By.XPath($"//input[@id='id_gender{genderID}']");
        private Func<int, By> AddressLine = lineNumber => By.Id($"address{lineNumber}");

        public void Login(string username, string password)
        {
            WaitUtils.WaitForElementVisible(AuthenticationSection);
            WaitUtils.WaitForAndSendKeys(LoginEmailField,username);
            WaitUtils.WaitForAndSendKeys(PasswordField, password);
        }

        public void CreateNewAccount(string email)
        {
            WaitUtils.WaitForAndSendKeys(SignUpEmailField, email);
            WaitUtils.WaitForAndClick(SignUpButton);
            WaitForPageToBeLoaded();
        }
        public void WaitForPageToBeLoaded() => WaitUtils.WaitForElementVisible(PersonalInformationSection);
        public void SetTitle(string title)
        {
            switch(title)
            {
                case "Mr.":
                    WaitUtils.WaitForAndClick(Title(1));
                    break;
                case "Mrs.":
                    WaitUtils.WaitForAndClick(Title(2));
                    break;
                default:
                    throw new ArgumentException($"Unsupported value '{title}'. Available options are 'Mr.' and 'Mrs.'");
            }
        }
        public void SetCustomerFirstName(string firstName) => WaitUtils.WaitForAndSendKeys(CustomerFirstNameInputField, firstName);
        public void SetCustomerLastName(string lastName) => WaitUtils.WaitForAndSendKeys(CustomerLastNameInputField, lastName);
        public void SetPassword(string password) => WaitUtils.WaitForAndSendKeys(PasswordField, password);
        public void SetAddressFirstName(string firstName) => WaitUtils.WaitForAndSendKeys(AddressFirstNameInputField, firstName);
        public void SetAddressLastName(string lastName) => WaitUtils.WaitForAndSendKeys(AddressLastNameInputField, lastName);
        public void SetAddressLineOne(string address) => WaitUtils.WaitForAndSendKeys(AddressLine(1), address);
        public void SetCity(string city) => WaitUtils.WaitForAndSendKeys(CityInputField, city);
        public void SetState(string state) => WaitUtils.WaitForAndGetSelectElement(StateDropDown).SelectByText(state);
        public void SetCountry(string country) => WaitUtils.WaitForAndGetSelectElement(CountryDropDown).SelectByText(country);
        public void SetMobilePhone(string phoneNumber) => WaitUtils.WaitForAndSendKeys(MobilePhoneNumberInputField, phoneNumber);
        public void ClickRegisterButton() => WaitUtils.WaitForAndClick(RegisterButton);
        public void SetZipCode(string zipCode) => WaitUtils.WaitForAndSendKeys(ZipCodeInputField, zipCode);
    }
}