Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Regression
Scenario: Search on Amazon Home Page
	Given I have navigated to the Amazon homepage
	When I enter something in the search field and press Go
	Then I am shown some Results
