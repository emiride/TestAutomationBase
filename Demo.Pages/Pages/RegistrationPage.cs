using Demo.Core.Elements;
using Demo.Core.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Pages.Pages
{
    public class RegistrationPage : BasePage
    {
        #region Properties
        private IField EmailAddressField => new Field(By.Id("email_create"));
        private IButton CreateAnAccountButton => new Button(By.Id("SubmitCreate"));
        #endregion

        #region Constructors
        public RegistrationPage(IExecutionTool executionTool) : base(executionTool)
        {

        }
        #endregion

        #region Actions

        public CreateAccountPage Register(string email)
        {
            EmailAddressField.Write(email);
            CreateAnAccountButton.Click();
            return new CreateAccountPage(executionTool);
        }

        #endregion

    }
}
