using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Interfaces
{
    public interface IExecutionTool
    {
        /// <summary>
        /// Starts the EHS application
        /// </summary>
        /// <returns>true on successful start</returns>
        bool StartApplication();

        /// <summary>
        /// Halts execution until EHS application is ready for user input
        /// </summary>
        void WaitForApplicationIdle();

        /// <summary>
        /// Goes to specified location e.g. url
        /// </summary>
        /// <param name="location">Location to navigate to</param>
        void GoTo(string location);

        /// <summary>
        /// Terminates the EHS application
        /// </summary>
        /// <returns>true if application terminated without error</returns>
        bool ExitApplication();

        /// <summary>
        /// Retrieves all possible buttons from the EHS application, regardless if the buttons are visible or not.
        /// </summary>
        /// <returns>Dictionary of button identifiers and button proxy objects</returns>
        Dictionary<string, IButton> GetAllButtons();

        /// <summary>
        /// Retrieves all possible text fields from the EHS application, regardless if the fields are visible or not.
        /// </summary>
        /// <returns>Dictionary of field identifiers and field proxy objects</returns>
        Dictionary<string, IField> GetAllFields();

        /// <summary>
        /// Retrieves all possible text labels from the EHS application, regardless if the labels are visible or not.
        /// </summary>
        /// <returns>Dictionary of label identifiers and label proxy objects</returns>
        Dictionary<string, ILabel> GetAllLabels();
    }
}
