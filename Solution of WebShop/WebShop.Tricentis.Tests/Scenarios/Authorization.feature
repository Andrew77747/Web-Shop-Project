Feature: Authorization
	Simple calculator for adding two numbers

@mytag
Scenario: Add two numbers
	Given I'm on the main page
	When I click login 
	Then I'm on the authorization page