Feature: BBCHeaderLinks
	In order to test the Headers links
	As a User
	I want to be able to click on those links.

@BBCHeaderLinks
Scenario Outline: Check Header Page load
	Given I navigate to BBC
	When I click on <header links>
	Then I see the <header links> pages
Examples:
| header links |
| News         |
| Sport        |
| Weather      |
