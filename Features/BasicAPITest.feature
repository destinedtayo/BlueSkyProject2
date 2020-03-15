Feature: BasicAPITest
	In order to use Github
	I want to know my user details

@mytag
Scenario: Search Result Returned
	Given I have access to Github
	When I search for a user
	Then the result is displayed


Scenario: User Details Test
	Given I have access to Github
	When I search for a user
	Then the result is displayed
	And the details contains "AbelAndColeTechnicalTest"

