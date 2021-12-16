Feature: ShoppingCart

Background: Authorization
Given I'm on the main page
When I click login
And I enter login, password and click login button
Scenario: Add goods to cart
    When I go to the 'Books' page
	And I add 'Computing and Internet' add to shopping cart
	And I add 'Fiction' add to shopping cart
	And I go to the 'Computers' page
	And I add 'Build your own cheap compute' add to shopping cart
	And I add 'Build your own expensive computer' add to shopping cart
	And I go to the 'Electronics' page
	And I add 'Smartphone' add to shopping cart
	And I add 'Phone Cover' add to shopping cart
	And I go to the 'Apparel & Shoes' page
	And I add 'Genuine Leather Handbag with Cell Phone Holder & Many Pockets' add to shopping cart
	And I add 'Casual Golf Belt' add to shopping cart
	#And I add 'Men's Wrinkle Free Long Sleeve' add to shopping cart - не ищется по локатору


	#And I go to the 'Digital downloads' page
	#And I add digital downloads to cart
	#And I go to the 'Jewelry' page
	#And I add jewelry to cart
	#And I go to the 'Gift Cards' page
	#And I add gift cards to cart
	#Then I check that all goods are added