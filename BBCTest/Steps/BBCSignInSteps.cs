using System;
using BBCTest.pages;
using BBCTest.Setup;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace BBCTest.Steps
{
    [Binding]
    [Scope(Tag = "BBCSignIn")]
    public class BBCSignInSteps :setup
    {
        public IWebDriver Browser;
        public BBCSignInPages Signin;

        [Given(@"I nabigate to BBC")]
        public void GivenINabigateToBBC()
        {
            Browser = driver;
            Signin = new BBCSignInPages(Browser);
            Browser.Navigate().GoToUrl("https://bbc.co.uk");
           
        }
        
        [When(@"I click signin")]
        public void WhenIClickSignin()
        {
            Signin.ClickSignIn();
            Signin.Takescreenshot();
        }
        
        [When(@"I login with valid user details")]
        public void WhenILoginWithValidUserDetails()
        {
            Signin.UserDetails();  
        }
        
        [Then(@"I see login is successfull")]
        public void ThenISeeLoginIsSuccessfull()
        {
            Signin.VerifyLogin(); 
        }
    }
}
