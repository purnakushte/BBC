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
    public class BBCHeaderlinksPages
    {
        public IWebDriver Driver;

        public BBCHeaderlinksPages(IWebDriver Browser)
        {
            Driver = Browser;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "News")]
        public IWebElement NewsLink;

        [FindsBy(How = How.LinkText, Using = "Sport")]
        public IWebElement SportLink;

        [FindsBy(How = How.LinkText, Using = "Weather")]
        public IWebElement WeatherLink;

        string NewsUrl = "https://www.bbc.co.uk/news";
        string SportUrl = "https://www.bbc.co.uk/sport";
        string WeatherUrl = "https://www.bbc.co.uk/weather";

        public void NavigatetoBBC()
        {
            Driver.Navigate().GoToUrl("https://bbc.co.uk");
        }

        public void ClickHeaderLink(string link)
        {
            switch (link)
            {
                case "News":
                    NewsLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "Sport":
                    SportLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "Weather":
                    WeatherLink.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                default:
                    Console.WriteLine("Wrong Link");
                    break;
            }
        }

        public void VerifyHeaderLink(string link)
        {
            switch (link)
            {
                case "News":
                    Driver.Url.Contains(NewsUrl);
                    break;
                case "Sport":
                    Driver.Url.Contains(SportUrl);
                    break;
                case "Weather":
                    Driver.Url.Contains(WeatherUrl);
                    break;
                default:
                    Console.WriteLine("Wrong Link");
                    break;

            }
        }
    }
}
