﻿Feature: ContactUs
	Checking message form

Scenario: Send message as unauthorized user
	Given I'm on the main page
	When I go to the contact page
	And I feel my data
	And I send a message
	Then I see the success message

Scenario: Check user's data in inputs
	Given I'm on the main page
	And I click login
	And I enter login, password and click login button
	When I go to the contact page
	Then Data in inputs is correct

Scenario: Send message as authorized user
	Given I'm on the main page
	And I click login
	And I enter login, password and click login button
	When I go to the contact page
	And I write and send a message
	Then I see the success message

Scenario: Send empty message as authorized user
	Given I'm on the main page
	And I click login
	And I enter login, password and click login button
	When I go to the contact page
	And I send an empty message
	Then I see the the error message