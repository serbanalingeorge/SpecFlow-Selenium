using System;
using Example.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class AutocompleteSteps
    {
        private readonly Autocomplete _autocomplete;
        public AutocompleteSteps()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
            _autocomplete = new Autocomplete(driver);
        }
        [Given(@"I navigate to the page")]
        public void GivenINavigateToThePage()
        {
            _autocomplete.GoTo();
        }
        
        [Given(@"The page loaded successful")]
        public void GivenThePageLoadedSuccessful()
        {
            _autocomplete.IsAt();
        }
        
        [When(@"I search the address and select it")]
        public void WhenISearchTheAddressAndSelectIt()
        {
            _autocomplete.SendAddress("1216 5th Avenue, New York, NY, USA");
        }
        
        [Then(@"The entire form is autocomplete")]
        public void ThenTheEntireFormIsAutocomplete()
        {
            _autocomplete.Validate();
        }
    }
}
