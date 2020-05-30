using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;

namespace BBCTest.pages
{
   public class BBCSignInPages
    {
        public IWebDriver Driver;

        public BBCSignInPages(IWebDriver browser)
        {
            Driver = browser;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.Id, Using = "idcta-link")]
        public IWebElement SignInLink;

        [FindsBy(How = How.Id, Using = "user-identifier-input")]
        public IWebElement Username;

        [FindsBy(How = How.Id, Using = "password-input")]
        public IWebElement Password;

        [FindsBy(How = How.Id, Using = "submit-button")]
        public IWebElement SubmitButton;

        [FindsBy(How = How.Id, Using = "idcta-username")]
        public IWebElement SigninName;

        string account = "Mangesh";

        public void NavigateBBCSignIn()
        {
            Driver.Navigate().GoToUrl("https://bbc.co.uk");
        }

        public void ClickSignIn()
        {
            SignInLink.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            //time to wait
            // implicitwait it will wait for given time and if we click it will move to next step.
            //explicit it needs to wait for the time given.
        }

        public void UserDetails()
        {
            Username.SendKeys("mangeshpkarekar@yahoo.com");
            Password.SendKeys("SoapdisH123");
            SubmitButton.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        public void VerifyLogin()
        {
            SigninName.Text.Contains(account).Should().BeTrue();
        }
        public void Takescreenshot()
        {
            Screenshot Takescreenshot = ((ITakesScreenshot)Driver).GetScreenshot();
            Takescreenshot.SaveAsFile(@"C:\Users\purna\Desktop\screenshot\Takescreenshot.jpeg", ScreenshotImageFormat.Jpeg);
        }
       
    }
}
