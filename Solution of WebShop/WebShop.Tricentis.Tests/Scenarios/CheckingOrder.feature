Feature: CheckingOrder

Background: Authorization
Given I'm on the main page
When I click login
And I enter login, password and click login button
And I go to shopping cart
And I check if the card is clear
And The address is clear

@mytag
Scenario: Checking the order is correct
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120