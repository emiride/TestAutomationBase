using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.CustomAttributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class TextAttribute : Attribute
    {
        public TextAttribute(string uiText)
        {
            Text = uiText;
        }
        public string Text { get; set; }
    }
}
