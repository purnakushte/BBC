Feature: BBCSignIn
	In order to login in BBC
	As a user
	I want to be able to validate Login details

@BBCSignIn
Scenario: Add two numbers
	Given I nabigate to BBC
	When I click signin
	And I login with valid user details
	Then I see login is successfull
