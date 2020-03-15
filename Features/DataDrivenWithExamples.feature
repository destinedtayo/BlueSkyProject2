Feature: DataDrivenWithExamples
	In order to repeat my data or to be able to update my data from feature file
	I want to add my data to the feature file


@mytag
Scenario: Validate Form Example
	Given I navigate to site "http://www.giftrete.com"
	And I navigate to site "https://blueskycitadel.com/automation-testing-form/"
	When I enter email "<Email>"
	And I enter password "<Password>"
	#And I click on submit button
	#Then the form is submitted

Examples:
| Email                  | Password        |
| destinedtayo@yahoo.com | mysecurePasword |
| destinedtayo1@yahoo.com | mysecurePasword2 |