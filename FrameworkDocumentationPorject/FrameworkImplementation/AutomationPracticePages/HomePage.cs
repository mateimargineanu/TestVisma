using FrameworkImplementation.Utilities;
using OpenQA.Selenium;

namespace FrameworkImplementation.AutomationPracticePages
{
    public class HomePage : BasePage 
    {
        private string url= "http://automationpractice.com/index.php";
        

        private By SignInButton =>By.XPath("//a[@title='Log in to your customer account']");
        private By SignOutButton => By.XPath("//a[@title='Log me out']");
        private By PageLogo => By.XPath("//*[@id='header_logo']/a/img");

     
        public void GotoHomePage()
        {
            Browser1.Goto(url);
            WaitUtils.WaitForElementVisible(PageLogo);
        }

        public void LoginAndRegPage()
        {
            WaitUtils.WaitForAndClick(() => Driver.FindElement(SignInButton));
        }

        public void SignOut()
        {
        WaitUtils.WaitForAndClick(() => Driver.FindElement(SignOutButton));
        }
    }
}