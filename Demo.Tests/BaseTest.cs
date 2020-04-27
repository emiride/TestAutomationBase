using Demo.Core;
using Demo.Core.Interfaces;
using Demo.Pages;
using NUnit.Framework;
using System;

namespace Demo.Tests
{
    [TestFixture]
    [Parallelizable]
    public class BaseTest
    {
        private IExecutionTool ExecutionTool;
        protected INavigator Navigator;
        private BasePage _basePage;

        public BaseTest()
        {
            ExecutionTool = WebExecutionTool.Instance;
            Navigator = new DemoNavigator(ExecutionTool);
            _basePage = new BasePage(ExecutionTool);
        }
        [SetUp]
        public void TestSetUp()
        {
            ExecutionTool.StartApplication();
        }

        [TearDown]
        public void TestTearDown()
        {
            ExecutionTool.ExitApplication();
        }
    }
}
