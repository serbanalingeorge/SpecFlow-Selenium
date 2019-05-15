using System;
using Example.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class FileUploadSteps
    {
        private readonly FileUpload _fileUpload;

        public FileUploadSteps()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
            _fileUpload = new FileUpload(driver);
        }
        [Given(@"I navigate to upload file page")]
        public void GivenINavigateToUploadFilePage()
        {
            _fileUpload.GoTo();
        }
        
        [When(@"The upload file page is successfully loaded")]
        public void WhenTheUploadFilePageIsSuccessfullyLoaded()
        {
            _fileUpload.IsAt();
        }
        
        [Then(@"I want to select and upload a file")]
        public void ThenIWantToSelectAndUploadAFile()
        {
            _fileUpload.Perform();
        }
    }
}
