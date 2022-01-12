Feature: SuccessMessage

Background: Authorization
Given I'm on the main page
When I click login
And I enter login, password and click login button
And I go to shopping cart
And I check if the card is clear

Scenario: Cheking success message
	Given I go to the 'Books' page
	When I add book to cart
	Then Success message is visible

Scenario: Cheking alert message
	Given I go to the 'Books' page
	When I add book to cart
	And I go to shopping cart
	And I checkout the good
	Then Alert message is visible