Feature: ShoppingCart

Background: Authorization
	Given I'm on the main page
	When I click login
	And I enter login, password and click login button
	And I go to shopping cart
	And I check if the card is clear
#@Ignore
Scenario: Add goods to cart
	When I go to the 'Books' page
	And I add 'Computing and Internet' add to shopping cart
	And I add 'Fiction' add to shopping cart
	And I go to the 'Computers' page
	And I add 'Build your own cheap computer' add to shopping cart
	And I add 'Build your own expensive computer' add to shopping cart
	And I go to the 'Electronics' page
	And I add 'Smartphone' add to shopping cart
	And I add 'Phone Cover' add to shopping cart
	And I go to the 'Apparel & Shoes' page
	And I add 'Genuine Leather Handbag with Cell Phone Holder & Many Pockets' add to shopping cart
	And I add 'Casual Golf Belt' add to shopping cart
	And I go to the 'Digital downloads' page
	And I add '3rd Album' add to shopping cart
	And I add 'Music 2' add to shopping cart
	And I go to the 'Jewelry' page
	And I add 'Create Your Own Jewelry' add to shopping cart
	And I add 'Black & White Diamond Heart' add to shopping cart
	And I go to the 'Gift Cards' page
	And I add '$5 Virtual Gift Card' add to shopping cart
	And I add '$25 Virtual Gift Card' add to shopping cart
	And I add '$50 Physical Gift Card' add to shopping cart
	And I go to shopping cart
	Then I check that all goods are added

Scenario: Add one good to cart twice
	When I go to the 'Books' page
	And I add 'Computing and Internet' add to shopping cart
	And I add 'Computing and Internet' add to shopping cart
	Then The good is added twice