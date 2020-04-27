using Demo.Core.Interfaces;
using Demo.Pages.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Pages
{
    public class DemoNavigator: BasePage, INavigator
    {
        public DemoNavigator(IExecutionTool executionTool) : base(executionTool)
        {

        }

        public HomePage GoToHomePage()
        {
            executionTool.GoTo(StaticUrls.HomePageUrl);
            return new HomePage(executionTool);
        }
    }
}
