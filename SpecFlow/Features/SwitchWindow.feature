Feature: SwitchWindow
	In order to navigate on multiple tabs
	As a user
	I want to open a new window and switch to first one

@SwitchWindow
Scenario: Open a new window and switch to first one
	Given I navigate to switch window page
	And The switch page loaded successfully
	When I open a new window it appears
	Then I move to the first window
