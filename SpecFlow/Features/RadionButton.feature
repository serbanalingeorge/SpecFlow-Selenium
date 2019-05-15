Feature: RadionButton
	In order to select an option
	As a user
	I want to be able to select any radio button I want

@RadioButton
Scenario: Select radion button
	Given I navigate to the radio button page
	And The radio button page loaded succesfully
	When I click a radio button
	Then I am able to click another one