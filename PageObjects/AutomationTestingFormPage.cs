using BlueSkyProject2.Hooks;
using BlueSkyProject2.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkyProject2.PageObjects
{
    class AutomationTestingFormPage
    {
        IWebDriver driver;

        Waits waits = new Waits();

        IWebElement singleLineText => driver.FindElement(By.Id("nf-field-135"));

        IWebElement selectOneTwoThree => driver.FindElement(By.XPath("//*[@id='nf-field-136']"));

        IWebElement multiselect123 => driver.FindElement(By.Id("nf-field-137"));

        IWebElement selectRadio => driver.FindElement(By.Id("nf-label-class-field-138-0"));

        IWebElement dateFromCalendar => driver.FindElement(By.CssSelector("input.pikaday__display.pikaday__display--pikaday.ninja-forms-field.nf-element.datepicker"));

        IWebElement emailAddress => driver.FindElement(By.Name("email"));

        IWebElement country => driver.FindElement(By.Id("nf-field-140"));

        IWebElement paragraphText => driver.FindElement(By.Id("nf-field-143"));

        IWebElement checkboxList => driver.FindElement(By.Id("nf-label-field-139-0"));

        IWebElement submitButton => driver.FindElement(By.Id("nf-field-133"));

        IWebElement passwordText => driver.FindElement(By.Name("nf-field-144"));

        IWebElement errorMsg => driver.FindElement(By.CssSelector("#nf-form-errors-9 > nf-errors > nf-section > div"));

        public string GetPageTittle => driver.Title;

        public string GetPageURL => driver.Url;

        //public string GetPageTittle()
        //{
        //    return driver.Title;
        //}

        public void CheckErrorMessageIsDisplayed()
        {
            Assert.IsTrue(errorMsg.Displayed);
        }

        public string GetTextForError()
        {
            // return waits.WaitForElement(driver, errorMsg).Text;
            IWebDriver myDriver = driver;
            return waits.MyDriverWait(driver, errorMsg).Text;
        }

        public void EnterPassword(string password)
        {
            passwordText.SendKeys(password);
        }

        public void ClickSubmitButton()
        {
            waits.WaitForElement(driver, submitButton).Click();
           // submitButton.Click();
        }

        public void SelectOneTwoThreeFromCheckboxList()
        {
            SelectElement select = new SelectElement(selectOneTwoThree);
            checkboxList.Click();
        }

        public void EnterParagraphText()
        {
            paragraphText.SendKeys("");
        }

        public void SelectUnitedKingdomFromCountry()
        {
            SelectElement select = new SelectElement(country);
            select.SelectByValue("GB");
        }
        
        public void EnterEmail(string email)
        {
            emailAddress.SendKeys(email);
        }

        public void SelectDateFromCalendar()
        {
            dateFromCalendar.SendKeys("12/02/2020");
        }

        public void SelectOneFromSelectRadio()
        {
            selectRadio.Click();
        }

        public void SelectMultiSelector()
        {
            SelectElement multiSelector = new SelectElement(multiselect123);
            multiSelector.SelectByText("Two");
            multiSelector.SelectByText("Three");

        }

        public void SelectOneFromSelectOneTWoThree()
        {
           SelectElement select = new SelectElement(selectOneTwoThree);
           select.SelectByValue("one");
        }

        

        public void EnterSingleLineText()
        {
            singleLineText.SendKeys("Tayo");
        }

        public AutomationTestingFormPage()
        {
            driver = Hook.driver;
            Waits waits = new Waits();
        }


        public void NavigateToForm()
        {
            driver.Navigate().GoToUrl("https://blueskycitadel.com/automation-testing-form/");
        }

        public void NavigateToFormWithParameter(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

    }
}