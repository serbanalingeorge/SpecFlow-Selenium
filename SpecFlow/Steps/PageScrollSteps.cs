using System;
using Example.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class PageScrollSteps
    {
        private readonly PageScroll _pageScroll;

        public PageScrollSteps()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
            _pageScroll = new PageScroll(driver);
        }
        [Given(@"I navigate to scroll page")]
        public void GivenINavigateToScrollPage()
        {
            _pageScroll.GoTo();
        }
        
        [Given(@"The scroll page loaded successfully")]
        public void GivenTheScrollPageLoadedSuccessfully()
        {
            _pageScroll.IsAt();
        }
        
        [When(@"I scroll the page I see the empty fields")]
        public void WhenIScrollThePageISeeTheEmptyFields()
        {
            _pageScroll.MoveToElementForInteraction();
        }
        
        [Then(@"I input the name and date")]
        public void ThenIInputTheNameAndDate()
        {
            _pageScroll.InputName("Full name");
            _pageScroll.InputDate("10/05/2019");
        }
    }
}
