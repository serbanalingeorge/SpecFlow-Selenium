using System;
using Example.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class DragAndDropSteps
    {
        private readonly DragAndDrop _dragAndDrop;

        public DragAndDropSteps()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
            _dragAndDrop = new DragAndDrop(driver);
        }
        [Given(@"I navigate to the drag and drop page")]
        public void GivenINavigateToTheDragAndDropPage()
        {
            _dragAndDrop.GoTo();
        }
        
        [When(@"The drag and drop page is loaded successfully")]
        public void WhenTheDragAndDropPageIsLoadedSuccessfully()
        {
            _dragAndDrop.IsAt();
        }
        
        [Then(@"I want to move the image into the box")]
        public void ThenIWantToMoveTheImageIntoTheBox()
        {
            _dragAndDrop.DragDrop();
        }
    }
}
