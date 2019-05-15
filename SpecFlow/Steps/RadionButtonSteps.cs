using System;
using Example.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class RadionButtonSteps
    {
        private readonly RadioButton _radioButton;

        public RadionButtonSteps()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
            _radioButton = new RadioButton(driver);
        }
        [Given(@"I navigate to the radio button page")]
        public void GivenINavigateToTheRadioButtonPage()
        {
            _radioButton.GoTo();
        }
        
        [Given(@"The radio button page loaded succesfully")]
        public void GivenTheRadioButtonPageLoadedSuccesfully()
        {
            _radioButton.IsAt();
        }
        
        [When(@"I click a radio button")]
        public void WhenIClickARadioButton()
        {
            _radioButton.ClickButton("1");
        }
        
        [Then(@"I am able to click another one")]
        public void ThenIAmAbleToClickAnotherOne()
        {
            _radioButton.ClickButton("2");
        }
    }
}
