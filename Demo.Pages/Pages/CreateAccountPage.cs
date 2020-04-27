using Demo.Core.Elements;
using Demo.Core.Interfaces;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Pages.Pages
{
    public class CreateAccountPage : BasePage
    {
        public IButton TitleMrRadioButton => new Button(By.Id("uniform-id_gender1"));
        public IField FirstNameField => new Field(By.Id("customer_firstname"));
        public IField LastNameField => new Field(By.Id("customer_lastname"));
        public IField EmailField => new Field(By.Id("email"));
        public IField PasswordField => new Field(By.Id("passwd"));


        #region Constructors
        public CreateAccountPage(IExecutionTool executionTool) : base(executionTool)
        {

        }
        #endregion

        #region Actions

        public void VerifyEmailFieldIsEqualTo(string email)
        {
            var actualEmail = EmailField.GetValue();
            StringAssert.AreEqualIgnoringCase(email, actualEmail);
        }

        #endregion
    }
}
