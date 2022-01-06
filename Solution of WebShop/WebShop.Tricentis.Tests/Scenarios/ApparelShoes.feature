Feature: ApparelShoes

Background: Open Apparel And Shoes Page
Given I'm on the main page
And I go to the 'Apparel & Shoes' page

Scenario: Check Product Cards Sorting
	#When I choose sorting
	#Then The sorting is right
	#When I choose sorting desc
	#Then The sorting desc is right
	#When I choose sorting by price
	#Then The sorting by price is right
	When I choose sorting by price desc
	Then The sorting by price desc is right