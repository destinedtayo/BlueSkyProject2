using BlueSkyProject2.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkyProject2.PageObjects
{
    class DataTablePage
    {
        IWebDriver driver;

        IWebElement emailAddress => driver.FindElement(By.Name("email"));

        IWebElement passwordText => driver.FindElement(By.Name("nf-field-144"));

        public DataTablePage()
        {
            driver = Hook.driver;
        }
        public void EnterEmailandPassword(string email, string password)
        {
            emailAddress.SendKeys(email);
            passwordText.SendKeys(password);
        }
    }
}
