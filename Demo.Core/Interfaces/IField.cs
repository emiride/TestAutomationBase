using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Interfaces
{
    public interface IField : IElement
    {
        /// <summary>
        /// Writes text into a field UI element 
        /// </summary>
        /// <param name="text">the text to enter into the field</param>
        /// <returns>true on successful write</returns>
        bool Write(string text);

        /// <summary>
        /// Reads text from a field UI element
        /// </summary>
        /// <returns>the text contained in the field UI element</returns>
        string Read();

        /// <summary>
        /// Get value from value tag in DOM
        /// </summary>
        /// <returns>value as string</returns>
        string GetValue();
    }
}
