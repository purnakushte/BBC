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
    public class BBCPageLoad
    {
        public IWebDriver Driver;

        public BBCPageLoad(IWebDriver browser)
        {
            Driver = browser;
            PageFactory.InitElements(Driver, this);
        }

        public void NavigateBBC()
        {
            Driver.Navigate().GoToUrl("https://bbc.co.uk");
        }

        [FindsBy(How = How.ClassName, Using = "hp-banner__text")]
        public IWebElement WelcomeMassage;
        //WelcomeMassage is a variable name can right anything

        string Welcome = "Welcome to the BBC";
        public void CheckMessage()
        {
            WelcomeMassage.Text.Contains(Welcome).Should().BeTrue();
        }

        //[FindsBy(How = How.LinkText, Using = "Welcome to the BBC")]
        //public IWebElement Hello;
        //to find the link 

        //public void Welcome1()
        //{
        //    IWebElement Welcome = Driver.FindElement(By.ClassName ("hp-banner__text"));
        //}

    }
}
