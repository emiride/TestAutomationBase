using Demo.Core.CustomAttributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Enums
{
    public enum DriverTypeEnum
    {
        [Text("Chrome")]
        Chrome,
        [Text("Firefox")]
        Firefox,
        [Text("InternetExplorer")]
        InternetExplorer,
        [Text("Edge")]
        Edge,
        [Text("Docker")]
        Docker
    }
}
