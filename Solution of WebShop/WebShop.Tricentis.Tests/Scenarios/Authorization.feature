Feature: Authorization
	Simple calculator for adding two numbers

Scenario: Check authorization page URL
	Given I'm on the main page
	When I click login 
	Then I'm on the authorization page