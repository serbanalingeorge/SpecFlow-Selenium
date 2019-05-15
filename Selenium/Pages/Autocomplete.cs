﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Example.Pages
{
    public class Autocomplete : IPage
    {
        private readonly IWebDriver _driver;

        public Autocomplete(IWebDriver driver)
        {
            _driver = driver;
        }
        private readonly By _pageLogo = By.Id("logo");
        private readonly By _addressField = By.Id("autocomplete");
        private readonly By _autocompleteResult = By.ClassName("pac-item");

        public void GoTo()
        {
            _driver.Navigate().GoToUrl("https://formy-project.herokuapp.com/autocomplete");
        }

        public bool IsAt()
        {
            return _driver.FindElement(_pageLogo).Displayed;
        }

        public void SendAddress(string input)
        {
            _driver.FindElement(_addressField).SendKeys(input);
        }

        public void Validate()
        {
            _driver.FindElement(_autocompleteResult).Click();
        }

        public void CreateImplicitWait(int seconds)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }

        public IWebElement FindElement(IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }

            return driver.FindElement(by);
        }
    }
}
