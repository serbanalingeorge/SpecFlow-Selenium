Feature: JavaScriptPopup
	In order to navigate on the page
	As a user
	I want to be able to close a java script popup

@ExecuteJavaScript
Scenario: Close a java script popup
	Given I navigate to the modal page	
	And The modal page loaded successfully
	When I open the java script alert and it should appear
	Then I close the the java script alert and it should disappear
