Feature: PageScroll
	In order to be able to fill the fields
	As a user
	I want to be able to scroll the page

@PageScroll
Scenario: Scroll page to be able to see the fields 
	Given I navigate to scroll page 
	And The scroll page loaded successfully
	When I scroll the page I see the empty fields
	Then I input the name and date
