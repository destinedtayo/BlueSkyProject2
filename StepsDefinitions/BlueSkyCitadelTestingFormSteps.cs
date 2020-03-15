using BlueSkyProject2.PageObjects;
using FluentAssertions;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyProject2.StepsDefinitions
{
    [Binding]
    public class BlueSkyCitadelTestingFormSteps
    {
        AutomationTestingFormPage automationTestingFormPage;
        public BlueSkyCitadelTestingFormSteps()
        {
            automationTestingFormPage = new AutomationTestingFormPage();
        }

        [Then(@"the page url is ""(.*)""")]
        public void ThenThePageUrlIs(string url)
        {
            Assert.AreEqual(url, automationTestingFormPage.GetPageURL); //Nunit

            url.Should().Be(automationTestingFormPage.GetPageURL); //FluentAssertion
            url.Should().Contain("bluesky");
            automationTestingFormPage.GetPageURL.Should().Contain("bluesky");

            automationTestingFormPage.GetPageURL.Should().Contain("https://blueskycitadel.com/automation-testing-form/");
        }


        [When(@"I select one in the Select box")]
        public void WhenISelectOneInTheSelectBox()
        {
            automationTestingFormPage.SelectOneFromSelectOneTWoThree();
        }


        [When(@"I enter Paragraph Text")]
        public void WhenIEnterParagraphText()
        {
            automationTestingFormPage.EnterParagraphText();
        }

        [Then(@"the error message ""(.*)""")]
        public void ThenTheErrorMessage(string errorMessage)
        {
            automationTestingFormPage.CheckErrorMessageIsDisplayed();

            Assert.AreEqual(errorMessage, automationTestingFormPage.GetTextForError());


        }

        [Then(@"the message ""(.*)""")]
        public void ThenTheMessage(string message)
        {
            
        }


        [When(@"I click on the Submit button")]
        public void WhenIClickOnTheSubmitButton()
        {
            automationTestingFormPage.ClickSubmitButton();
        }


        [Given(@"I navigate to the BlueSky Testing Form")]
        public void GivenINavigateToTheBlueSkyTestingForm()
        {
            automationTestingFormPage.NavigateToForm();
        }
        
        [When(@"I enter the Single Line Text")]
        public void WhenIEnterTheSingleLineText()
        {
            automationTestingFormPage.EnterSingleLineText();
        }
        
        [When(@"I enter Email")]
        public void WhenIEnterEmail()
        {
            automationTestingFormPage.EnterEmail("destinedtayo@yahoo.com");
        }
        
        [When(@"I select the Multi-Select")]
        public void WhenISelectTheMulti_Select()
        {
            automationTestingFormPage.SelectMultiSelector();
        }
        
        [When(@"I select the Radio List")]
        public void WhenISelectTheRadioList()
        {
            automationTestingFormPage.SelectOneFromSelectRadio();
        }
        
        [When(@"I select the Checkbox List")]
        public void WhenISelectTheCheckboxList()
        {
            automationTestingFormPage.SelectOneTwoThreeFromCheckboxList();
        }
        
        [When(@"I select United Kingdom as Country")]
        public void WhenISelectUnitedKingdomAsCountry()
        {
            automationTestingFormPage.SelectUnitedKingdomFromCountry();
        }
        
        [When(@"I select (.*)th of the current month")]
        public void WhenISelectThOfTheCurrentMonth(int message)
        {
            automationTestingFormPage.SelectDateFromCalendar();
        }
    }
}
