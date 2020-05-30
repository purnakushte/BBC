Feature: BBCPageLoad
	In order to Check the page load
	As a BBC User
	I want to be able to navigate to BBC Website

@BBCPageLoad
Scenario: Check the page loads for BBC
	Given I navigate to BBC
	Then I see BBC page loads
