Feature: SuccessMessage

Background: Authorization
Given I'm on the main page
When I click login
And I enter login, password and click login button
Scenario: Cheking success message
	Given I go to the 'Books' page
	When I add book to cart
	Then Success message is visible