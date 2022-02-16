Feature: Search
	Cheking advanced search

Background: Open main page
	Given I'm on the main page
	When I click login
	And I enter login, password and click login button
	And I go to the Search page

Scenario: Advanced search
	When I choose advanced searched
	And I enter keyword 'Custom T-Shirt'
	And I choose category
	And I choose price range
	And I click the search button
	Then The good 'Custom T-Shirt' is found

Scenario: Advanced search with wrong category
	When I choose advanced searched
	And I enter keyword 'Custom T-Shirt'
	And I choose wrong category
	And I click the search button
	Then The good is not found

Scenario: Advanced search with wrong price
	When I choose advanced searched
	And I enter keyword 'Custom T-Shirt'
	And I choose category
	And I choose wrong price range
	And I click the search button
	Then The good is not found