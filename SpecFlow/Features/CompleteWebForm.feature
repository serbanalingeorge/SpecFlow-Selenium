Feature: CompleteWebForm
	In order to complete a web form 
	As a user
	I want to be able fill all the informations and submit it

@CompleteForm
Scenario: Add two numbers
	Given I navigate to complete web form page
	And The complete web form loaded successfully
	When I complete all fields and submit the form
	Then A successful message is displayed
