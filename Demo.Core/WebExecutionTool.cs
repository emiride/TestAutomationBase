using Demo.Core.Elements;
using Demo.Core.Enums;
using Demo.Core.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Demo.Core
{
    public sealed class WebExecutionTool : IExecutionTool
    {
        private IWebDriver _webDriver;
        static readonly ThreadLocal<WebExecutionTool> executionToolThread = new ThreadLocal<WebExecutionTool>(() => new WebExecutionTool());
        public static WebExecutionTool Instance => executionToolThread.Value;

        private WebExecutionTool()
        {
        }

        public bool ExitApplication()
        {
            _webDriver.Close();
            _webDriver.Quit();
            return true;
        }

        public Dictionary<string, ILabel> GetAllLabels()
        {
            var allLabelElements = _webDriver.FindElements(By.XPath(".//*[string-length(normalize-space(text())) > 0]"));
            var labels = new Dictionary<string, ILabel>();
            foreach (var labelElement in allLabelElements)
            {
                var label = new Label(labelElement);
                labels.Add(label.Id, label);
            }

            return labels;
        }

        public Dictionary<string, IButton> GetAllButtons()
        {
            var allButtonElements = _webDriver.FindElements(By.ClassName("button"));
            var buttons = new Dictionary<string, IButton>();
            foreach (var buttonElement in allButtonElements)
            {
                var button = new Button(buttonElement);
                buttons.Add(button.Id, button);
            }

            return buttons;
        }

        public Dictionary<string, IField> GetAllFields()
        {
            var allFieldElements = _webDriver.FindElements(By.TagName("input"));
            var fields = new Dictionary<string, IField>();
            foreach (var fieldElement in allFieldElements)
            {
                var field = new Field(fieldElement);
                fields.Add(field.Id, field);
            }

            return fields;
        }

        public bool StartApplication()
        {
            Instance.SetWebExecutionTool(StaticConfiguration.DriverType);
            return true;
        }

        public void GoTo(string url)
        {
            _webDriver.Navigate().GoToUrl(url);
        }

        public void WaitForApplicationIdle()
        {
        }

        public IWebDriver GetWebExecutionTool()
        {
            return _webDriver;
        }

        private void SetWebExecutionTool(DriverTypeEnum driverType, DriverOptions driverOptions = null)
        {
            if (driverType == DriverTypeEnum.Chrome)
            {
                _webDriver = driverOptions == null ? new ChromeDriver() : new ChromeDriver((ChromeOptions)driverOptions);
            }
            else if (driverType == DriverTypeEnum.Docker)
            {
                var options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                _webDriver = new RemoteWebDriver(options);
            }
            else
            {
                _webDriver = new FirefoxDriver();
            }
        }



    }
}
