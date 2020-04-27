using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Interfaces
{
    public interface ILabel : IElement
    {
        /// <summary>
        /// Reads text from a label UI element
        /// </summary>
        /// <returns>the text contained in the label UI element</returns>
        string Read();
    }
}
