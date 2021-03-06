Feature: Authorization
	Checking the authorization

Scenario: Check authorization page URL
	Given I'm on the main page
	When I click login
	Then I'm on the authorization page

Scenario: Check LogIn
	Given I'm on the main page
	And I go to the authorization page
	When I enter login, password and click login button
	Then I see 'andrew-walker@yandex.ru'
	And I see 'Log out'

Scenario: Check Logout
	Given I'm on the main page
	And I'am registered
	When I click logout
	Then I'm on the main page
	And I don't see 'andrew-walker@yandex.ru'
	And I don't see 'Log out'

Scenario: Check the search input
	Given I'm on the main page
	When I type my request and click the search button
	And I click the found item
	Then I see 'Simple Computer'