Feature: FileUpload
	As a user
	I want to be able to select and upload a file 

@FileUpload
Scenario: Upload a file
	Given I navigate to upload file page
	When The upload file page is successfully loaded
	Then I want to select and upload a file
