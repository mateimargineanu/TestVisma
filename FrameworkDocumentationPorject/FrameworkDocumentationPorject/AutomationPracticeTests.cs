using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using FrameworkImplementation;
using FrameworkImplementation.Utilities;
using FluentAssertions.Execution;
using FrameworkImplementation.AutomationPracticePages;

namespace FrameworkDocumentationPorject
{
    [TestClass]
    public class AutomationPracticeTests
    {

        public HomePage HomePage = new HomePage();
        public LoginAndRegPage LoginAndRegPage = new LoginAndRegPage();
        public MyAccountPage MyAccountPage = new MyAccountPage();
        public MyAddressesPage MyAddressesPage = new MyAddressesPage();

        [TestMethod]
        public void AutomationPracticeCreateAccountTest()
        {
            HomePage.GotoHomePage();
            HomePage.LoginAndRegPage();
            LoginAndRegPage.CreateNewAccount("matei.margineanu"+StringUtils.RandomString()+".@gmail.com");
            LoginAndRegPage.SetTitle("Mr.");
            LoginAndRegPage.SetCustomerFirstName("CustomerFirstName");
            LoginAndRegPage.SetCustomerLastName("CustomerLastName");
            LoginAndRegPage.SetPassword("Password1");
            LoginAndRegPage.SetAddressFirstName("AddressFirstName");
            LoginAndRegPage.SetAddressLastName("AddressLastName");
            LoginAndRegPage.SetAddressLineOne("Street address, P.O. Box, Company name etc");
            LoginAndRegPage.SetCity("City");
            LoginAndRegPage.SetState("Georgia");
            LoginAndRegPage.SetZipCode("12345");
            LoginAndRegPage.SetMobilePhone("0745123456");
            LoginAndRegPage.SetCountry("United States");
            LoginAndRegPage.ClickRegisterButton();
            MyAccountPage.WaitForPageToBeLoaded();
            MyAccountPage.ClickOnMyAddresses();
            using (new AssertionScope())
            {
                MyAddressesPage.GetAddressFirstName().Trim().Should().Match("AddressFirstName");
                MyAddressesPage.GetAddressLastName().Trim().Should().Match("AddressLastName");
                MyAddressesPage.GetAddressLineOne().Trim().Should().Match("Street address, P.O. Box, Company name etc".Trim());
                MyAddressesPage.GetAddressCity().Trim().Should().Match("City,");
                MyAddressesPage.GetAddressState().Trim().Should().Match("Georgia");
                MyAddressesPage.GetAddressZipCode().Trim().Should().Match("12345");
                MyAddressesPage.GetAddressCountry().Trim().Should().Match("United States".Trim());
                MyAddressesPage.GetMobilePhoneNumber().Trim().Should().Match("0745123456");
            }
                System.Threading.Thread.Sleep(5000);
        }

        [TestCleanup]
        public void Cleanup()
        {
            Browser1.CloseBrowser();
        }
    }
}
