Feature: Autocomplete
	In order to fill the form 
	As a user
	I expect all the form fields to be filled

@AutocompleteWebForm
Scenario: Successful autocomplete 
	Given I navigate to the page 
	And The page loaded successful
	When I search the address and select it
	Then The entire form is autocomplete