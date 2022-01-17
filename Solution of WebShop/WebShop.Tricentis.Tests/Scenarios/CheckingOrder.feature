Feature: CheckingOrder

Background: Authorization
	Given I'm on the main page
	When I click login
	And I enter login, password and click login button
	And I go to shopping cart
	And I check if the card is clear
	And The address is clear

Scenario: Checking the order is correct
	Given I go to the 'Books' page
	When I add book to cart
	And I go to shopping cart
	And I click checkout
	And I feel the order
	Then The order number is correct