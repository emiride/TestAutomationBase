using Demo.Core.Interfaces;
using System;
using System.Threading;

namespace Demo.Pages
{
    public class BasePage
    {
        protected int _defaultExplicitWait = 30;
        protected IExecutionTool executionTool;

        public BasePage(IExecutionTool executionTool)
        {
            this.executionTool = executionTool;
            Thread.Sleep(5000);
            executionTool.WaitForApplicationIdle();
        }
    }
}
