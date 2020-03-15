
Feature: BlueSkyCitadelTestingForm
	In order to be a guru tester
	I want to test the BlueSky Citadel Testing
	Which has a lot of element that i will be automating in future

@regression @blueskyform
Scenario: valid form submission
	Given I navigate to the BlueSky Testing Form
	When I enter the Single Line Text
	And I select one in the Select box
	And I enter Email
	And I enter password "mysecurePassword"
	And I select the Multi-Select
	And I select the Radio List
	And I select the Checkbox List
	And I select United Kingdom as Country
	And I select 12th of the current month
	And I enter Paragraph Text
	And I click on the Submit button
	Then the message "Your form has been successfully submitted."


	Scenario: Invalid form submission
	Given I navigate to the BlueSky Testing Form
	When I enter the Single Line Text
	And I select one in the Select box
	And I enter Email
	And I select the Multi-Select
	And I select the Radio List
	And I select the Checkbox List
	#And I select United Kingdom as Country
	#And I select 12th of the current month
	#And I enter Paragraph Text
	And I click on the Submit button
	Then the error message "Please correct errors before submitting this form."
	And the page url is "https://blueskycitadel.com/automation-testing-form/"