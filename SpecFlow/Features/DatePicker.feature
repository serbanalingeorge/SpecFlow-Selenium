Feature: DatePicker
	In order to select a date
	As a user
	I want to be able to search and select a date

@DatePicker
Scenario: Select date
	Given I navigate to date picker page
	When The date picker date loaded successfully
	Then I search and select a date
