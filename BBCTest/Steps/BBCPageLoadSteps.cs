using System;
using TechTalk.SpecFlow;
using BBCTest.Setup;
using BBCTest.pages;
using OpenQA.Selenium;


namespace BBCTest.Steps
{
    [Binding]
    [Scope(Tag = "@BBCPageLoad")]
    public class BBCPageLoadSteps : setup
    {
        public IWebDriver Browser;
        // Browser = name
        public BBCPageLoad pageload;

        [Given(@"I navigate to BBC")]
        public void GivenINavigateToBBC()
        {
            Browser = driver;
            //coz of inheritance can access the object of the setup
            pageload = new BBCPageLoad(Browser);
            pageload.NavigateBBC();
            
        }
        
        [Then(@"I see BBC page loads")]
        public void ThenISeeBBCPageLoads()
        {
            pageload.CheckMessage();   
        }
    }
}
