using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Interfaces
{
    public interface IElement
    {
        /// <summary>
        /// Verifies that a specific UI element is visible in the EHS application
        /// </summary>
        /// <param name="timeout">max number of seconds to wait for element to become visible</param>
        /// <returns>true on finding the UI element within given timeout</returns>
        bool Exists(int timeout);
    }
}
