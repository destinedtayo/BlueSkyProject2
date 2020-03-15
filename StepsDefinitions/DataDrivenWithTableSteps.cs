using BlueSkyProject2.PageObjects;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;



namespace BlueSkyProject2.StepsDefinitions
{
    [Binding]
    public class DataDrivenWithTableSteps
    {
        DataTablePage dataTablePage;

        public DataDrivenWithTableSteps()
        {
            dataTablePage = new DataTablePage();
        }

        [When(@"I enter email and password")]
        public void WhenIEnterEmailAndPassword(Table table)
        {
            var emailandPassword = table.CreateInstance<Details>();

            string email = emailandPassword.Email;
            string password = emailandPassword.Password;

            dataTablePage.EnterEmailandPassword(email, password);
        }
    }
}
