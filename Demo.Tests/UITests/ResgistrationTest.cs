using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Tests.UITests
{
    public class ResgistrationTest : BaseTest
    {

        [Test, Property("Test", "1")]
        public void CreateAccountPopulatedEmailTest()
        {
            string sampleEmail = "demo@example.com";
            Navigator.GoToHomePage()
                .ClickOnSignIn()
                .Register(sampleEmail)
                .VerifyEmailFieldIsEqualTo(sampleEmail);
        }
    }
}
