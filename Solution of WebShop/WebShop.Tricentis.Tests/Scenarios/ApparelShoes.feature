Feature: ApparelShoes

Background: Open Apparel And Shoes Page
Given I'm on the main page
And I go to the 'Apparel & Shoes' page

Scenario: Check Product Cards Sorting
	When I choose sorting
	Then The sorting is right
	When I choose sorting desc
	Then The sorting desc is right