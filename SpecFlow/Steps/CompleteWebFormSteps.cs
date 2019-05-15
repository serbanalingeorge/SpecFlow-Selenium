using System;
using Example.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class CompleteWebFormSteps
    {
        private readonly CompleteWebForm _completeWebForm;

        public CompleteWebFormSteps()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
            _completeWebForm = new CompleteWebForm(driver);
        }
        [Given(@"I navigate to complete web form page")]
        public void GivenINavigateToCompleteWebFormPage()
        {
            _completeWebForm.GoTo();
        }
        
        [Given(@"The complete web form loaded successfully")]
        public void GivenTheCompleteWebFormLoadedSuccessfully()
        {
            _completeWebForm.IsAt();
        }
        
        [When(@"I complete all fields and submit the form")]
        public void WhenICompleteAllFieldsAndSubmitTheForm()
        {
            _completeWebForm.SubmitForm("George","Serban","QA Engineer", "10/05/2019");
        }
        
        [Then(@"A successful message is displayed")]
        public void ThenASuccessfulMessageIsDisplayed()
        {
            _completeWebForm.ExpectedMessageDisplayed();
        }
    }
}
