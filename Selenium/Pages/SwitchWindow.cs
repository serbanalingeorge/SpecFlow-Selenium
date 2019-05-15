using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Example.Pages
{
    public class SwitchWindow : IPage
    {
        private readonly IWebDriver _driver;

        public SwitchWindow(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _pageLogo = By.Id("logo");
        private readonly By _newWindow = By.Id("new-tab-button");


        public bool IsAt()
        {
            return _driver.FindElement(_pageLogo).Displayed;
        }

        public void GoTo()
        {
            _driver.Navigate().GoToUrl("https://formy-project.herokuapp.com/switch-window");
        }

        public void OpenNewWindow(int newWidows)
        {
            _driver.FindElement(_newWindow).Click();
        }

        public void SwitchToFirstWindow()
        {
            var originalHandle = _driver.CurrentWindowHandle;
            _driver.SwitchTo().Window(originalHandle);
        }
    }
}
