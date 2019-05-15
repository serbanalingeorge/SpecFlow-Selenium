﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Example.Pages
{
    public class CheckBox : IPage
    {
        private readonly IWebDriver _driver;

        public CheckBox(IWebDriver driver)
        {
            _driver = driver;
        }
        private readonly By _pageLogo = By.Id("logo");
        private readonly By _checkBox1 = By.Id("checkbox-1");
        private readonly By _checkBox2 = By.Id("checkbox-2");
        private readonly By _checkBox3 = By.Id("checkbox-3");

        public void GoTo()
        {
            _driver.Navigate().GoToUrl("https://formy-project.herokuapp.com/checkbox");
        }

        public bool IsAt()
        {
            return _driver.FindElement(_pageLogo).Displayed;
        }

        public void SelectBox1()
        {
            _driver.FindElement(_checkBox1).Click();
        }

        public void SelectBox2()
        {
            _driver.FindElement(_checkBox2).Click();
        }

        public void SelectBox3()
        {
            _driver.FindElement(_checkBox3).Click();
        }


    }
}
