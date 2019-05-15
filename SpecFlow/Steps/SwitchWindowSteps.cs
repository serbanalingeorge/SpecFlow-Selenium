using System;
using Example.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class SwitchWindowSteps
    {
        private readonly SwitchWindow _switchWindow;

        public SwitchWindowSteps()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
            _switchWindow = new SwitchWindow(driver);
        }
        [Given(@"I navigate to switch window page")]
        public void GivenINavigateToSwitchWindowPage()
        {
            _switchWindow.GoTo();
        }
        
        [Given(@"The switch page loaded successfully")]
        public void GivenTheSwitchPageLoadedSuccessfully()
        {
            _switchWindow.IsAt();
        }
        
        [When(@"I open a new window it appears")]
        public void WhenIOpenANewWindowItAppears()
        {
            _switchWindow.OpenNewWindow(1);
        }
        
        [Then(@"I move to the first window")]
        public void ThenIMoveToTheFirstWindow()
        {
            _switchWindow.SwitchToFirstWindow();
        }
    }
}
