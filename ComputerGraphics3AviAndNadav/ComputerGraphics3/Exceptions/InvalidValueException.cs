using System;

namespace ComputerGraphics3.Exceptions
{
    /// <summary>
    /// Avraham Michaeli - 203835749
    /// Nadav Ben-assor - 301785663
    /// </summary>
    class InvalidValueException :Exception
    {
        /// <summary>
        /// exception for secenario when user entered wrong input in some fields.
        /// </summary>
        /// <param name="message"></param>
        public InvalidValueException(string message) : base(message)
        {
           
        }
    }
}
   