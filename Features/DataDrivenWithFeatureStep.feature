Feature: DataDrivenWithFeatureStep
	In order to repeat my data or to be able to update my data from feature file
	I want to add my data to the feature file


@mytag
Scenario Outline: Validate Form Parameter
	Given I navigate to site "http://blueskycitadel.com/automation-testing-form/"
	When I enter email "destinedtayo@yahoo.com"
	And I enter password "mysecurePassword"
	#And I click on submit button
	Then the form is submitted
