using Demo.Core.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Elements
{
    public class Button : IButton
    {
        public string Id { get; private set; }
        private IWebElement _element;
        private WebExecutionTool WebExecutionTool => WebExecutionTool.Instance;
        public Button(By by)
        {
            Id = Guid.NewGuid().ToString();
            _element = WebExecutionTool.GetWebExecutionTool().FindElement(by);
        }

        public Button(IWebElement element)
        {
            Id = Guid.NewGuid().ToString();
            _element = element;
        }
        public bool Click()
        {
            _element.Click();
            return true;
        }

        public bool Exists(int timeout)
        {
            return _element.Displayed;
        }
    }
}
