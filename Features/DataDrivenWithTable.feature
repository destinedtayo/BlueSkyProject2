Feature: DataDrivenWithTable
	In order to repeat my data or to be able to update my data from feature file
	I want to add my data to the feature file


@mytag
Scenario: Validate Form With Table
	Given I navigate to site "http://blueskycitadel.com/automation-testing-form/"
	When I enter email and password
	| Email                  | Password   |
	| destinedtayo@yahoo.com | mypassword |
