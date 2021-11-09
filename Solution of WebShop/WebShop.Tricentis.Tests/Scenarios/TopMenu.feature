Feature: TopMenu
	Checking Top Menu

	Scenario: Hover on menu items
	Given I'm on the main page
	When I hover on 'Books'
	Then I don't see dropdown
	When I hover on 'Computers'
	Then I see dropdown
	#When I hover on 'Electronics'
	#Then I see dropdown
	#When I hover on 'Apparel & Shoes'
	#Then I don't see dropdown
	#When I hover on 'Digital downloads'
	#Then I don't see dropdown
	#When I hover on 'Jewelry'
	#Then I don't see dropdown
	#When I hover on 'Gift Cards'
	#Then I don't see dropdown
	