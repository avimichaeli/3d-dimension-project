using System;

namespace ComputerGraphics3.Exceptions
{
    /// <summary>
    /// Avraham Michaeli - 203835749
    /// Nadav Ben-assor - 301785663
    /// </summary>
    public class FileNotSelectedException:Exception
    {
        /// <summary>
        /// exception for secenario when user doesn't selceted a file.
        /// </summary>
        /// <param name="message"></param>
        public FileNotSelectedException(string message) : base(message)
        {

        }
    }
}
     