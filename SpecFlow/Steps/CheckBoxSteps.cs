using System;
using Example.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class CheckBoxSteps
    {
        private readonly CheckBox _checkBox;
        public CheckBoxSteps()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
            _checkBox = new CheckBox(driver);
        }
        [Given(@"I navigate to the checkbox page")]
        public void GivenINavigateToTheCheckboxPage()
        {
            _checkBox.GoTo();
        }
        
        [Given(@"The checkbox page loaded succesfully")]
        public void GivenTheCheckboxPageLoadedSuccesfully()
        {
            _checkBox.IsAt();
        }
        
        [When(@"I click a checkbox remains selected")]
        public void WhenIClickACheckboxRemainsSelected()
        {
            _checkBox.SelectBox1();
        }
        
        [Then(@"I am able to select another one")]
        public void ThenIAmAbleToSelectAnotherOne()
        {
            _checkBox.SelectBox2();
        }
    }
}
