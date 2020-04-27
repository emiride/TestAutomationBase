using Demo.Core.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Elements
{
    public class Label : ILabel
    {
        private IWebElement _element;
        public string Id { get; private set; }
        private WebExecutionTool WebExecutionTool => WebExecutionTool.Instance;

        public Label(By by)
        {
            Id = Guid.NewGuid().ToString();
            _element = WebExecutionTool.GetWebExecutionTool().FindElement(by);
        }

        public Label(IWebElement element)
        {
            Id = Guid.NewGuid().ToString();
            _element = element;
        }

        public bool Exists(int timeout)
        {
            return _element.Displayed;
        }

        public string Read()
        {
            return _element.Text;
        }
    }
}
