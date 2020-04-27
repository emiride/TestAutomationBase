using Demo.Core.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core
{
    public static class StaticConfiguration
    {
        public static readonly DriverTypeEnum DriverType = DriverTypeEnum.Docker;
        public const int NumberOfThreads = 3;
    }
}
