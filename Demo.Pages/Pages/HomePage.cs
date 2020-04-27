using Demo.Core.Elements;
using Demo.Core.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Pages.Pages
{
    public class HomePage : BasePage
    {
        #region Properties
        private IButton SignInButton => new Button(By.ClassName("login"));
        #endregion

        #region Constructors
        public HomePage(IExecutionTool executionTool) : base(executionTool)
        {

        }
        #endregion

        #region Actions

        public RegistrationPage ClickOnSignIn()
        {
            SignInButton.Click();
            return new RegistrationPage(executionTool);
        }

        #endregion

    }
}
