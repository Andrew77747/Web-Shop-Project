Feature: ShoppingCart

Background: Authorization
Given I'm on the main page
When I click login
And I enter login, password and click login button
Scenario: Add goods to cart
    When I go to the 'Books' page
	And I add books to cart
	And I go to the 'Computers' page
	And I add pc to cart
	And I go to the 'Electronics' page
	And I add cell phones to cart
	And I go to the 'Apparel & Shoes' page
	And I add apparel to cart
	And I go to the 'Digital downloads' page
	And I add digital downloads to cart
	And I go to the 'Jewelry' page
	And I add jewelry to cart
	And I go to the 'Gift Cards' page
	And I add gift cards to cart