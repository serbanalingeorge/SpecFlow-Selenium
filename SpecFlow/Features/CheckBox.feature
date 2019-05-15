Feature: CheckBox
	In order to select an option
	As a user
	I want to be able to select any checkbox I want

@CheckBox
Scenario: Select checkbox
	Given I navigate to the checkbox page
	And The checkbox page loaded succesfully
	When I click a checkbox remains selected
	Then I am able to select another one
