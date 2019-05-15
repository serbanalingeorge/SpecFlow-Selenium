using System;
using Example.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class DatePickerSteps
    {
        private readonly DatePicker _datePicker;

        public DatePickerSteps()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
            _datePicker = new DatePicker(driver);
        }
        [Given(@"I navigate to date picker page")]
        public void GivenINavigateToDatePickerPage()
        {
            _datePicker.GoTo();
        }

        [When(@"The date picker date loaded successfully")]
        public void WhenTheDatePickerDateLoadedSuccessfully()
        {
            _datePicker.IsAt();
        }

        [Then(@"I search and select a date")]
        public void ThenISearchAndSelectADate()
        {
            _datePicker.Input("15/05/2019");
        }
    }
}
