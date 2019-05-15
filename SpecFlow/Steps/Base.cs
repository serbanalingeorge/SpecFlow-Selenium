using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Browser;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class BaseTest
    {
        private DriverManager _driverManager;
        private IWebDriver driver;

        [BeforeScenario()]
        public void RunBeforeScenario()
        {
            _driverManager = DriverManagerFactory.GetDriverManager(DriverType.Firefox);
            driver = _driverManager.GetWebDriver();

            //driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            ScenarioContext.Current.Add("currentDriver",driver);
        }

        [AfterScenario()]
        public void RunAfterScenario()
        {
            _driverManager.QuitWebDriver();
        }
    }
}
