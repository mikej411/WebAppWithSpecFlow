Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Validate Sample Test
	Given I have navigated to the About page
	And I have navigated to the Home page
	And I have navigated back to the home page. (Navigating with menu items)
	And I have navigated to the Home page again
	When I enter "blah" into the email text box
	Then the text box should contain "blah"
