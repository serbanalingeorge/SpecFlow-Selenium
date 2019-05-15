using System;
using Example.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class AlertSteps
    {
        private readonly Alert _alertPage;
        public AlertSteps()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
            _alertPage = new Alert(driver);
        }
        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            _alertPage.GoTo();
        }
        
        [Given(@"The page loaded successfully")]
        public void GivenThePageLoadedSuccessfully()
        {
            _alertPage.IsAt();
        }
        
        [When(@"I open a popup alert should appear")]
        public void WhenIOpenAPopupAlertShouldAppear()
        {
            _alertPage.OpenAlert();
        }
        
        [Then(@"I a close the popup alert should disappear")]
        public void ThenIACloseThePopupAlertShouldDisappear()
        {
            _alertPage.CloseAlert();
        }
    }
}
