Feature: Alert
	In order to navigate on the website
	As a user
	I want to be able to close a popup alert

@PopupAlert
Scenario: Close popup alert
	Given I navigate to the website
	And The page loaded successfully
	When I open a popup alert should appear
	Then I a close the popup alert should disappear
