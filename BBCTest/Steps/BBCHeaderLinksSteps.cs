using System;
using BBCTest.Setup;
using TechTalk.SpecFlow;
using BBCTest.pages;
using OpenQA.Selenium;
using System.Runtime;

namespace BBCTest.Steps
{
    [Binding]
    [Scope(Tag = "BBCHeaderLinks")]
    public class BBCHeaderLinksSteps : setup
    {
        IWebDriver Browser;

        public BBCHeaderlinksPages Headers;

        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            Browser = driver;
            Headers = new BBCHeaderlinksPages(Browser);
            Headers.NavigatetoBBC();
            
        }
        
        [When(@"I click on (.*)")]
        public void WhenIClickOnNews(string link)
        {
            Headers.ClickHeaderLink(link);
        }
        
        [Then(@"I see the (.*) pages")]
        public void ThenISeeTheNewsPages(string link)
        {
            Headers.VerifyHeaderLink(link);
        }
    }
}
