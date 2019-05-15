using System;
using Example.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class JavaScriptPopupSteps
    {
        private readonly ExecuteJavaScript _executeJavaScript;

        public JavaScriptPopupSteps()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
            _executeJavaScript = new ExecuteJavaScript(driver);
        }
        [Given(@"I navigate to the modal page")]
        public void GivenINavigateToTheModalPage()
        {
            _executeJavaScript.GoTo();
        }
        
        [Given(@"The modal page loaded successfully")]
        public void GivenTheModalPageLoadedSuccessfully()
        {
            _executeJavaScript.IsAt();
        }
        
        [When(@"I open the java script alert and it should appear")]
        public void WhenIOpenTheJavaScriptAlertAndItShouldAppear()
        {
            _executeJavaScript.ClickButton();
        }
        
        [Then(@"I close the the java script alert and it should disappear")]
        public void ThenICloseTheTheJavaScriptAlertAndItShouldDisappear()
        {
            _executeJavaScript.MoveToElementForInteraction(_executeJavaScript.CloseButton());
        }
    }
}
