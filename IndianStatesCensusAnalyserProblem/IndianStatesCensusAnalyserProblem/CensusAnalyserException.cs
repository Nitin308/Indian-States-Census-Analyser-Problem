using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyserProblem
{
    public class CensusAnalyserException : Exception
    {
        public ExceptionType exception;
        /// <summary>
        /// Creating a Enum for Different Types
        /// </summary>
        public enum ExceptionType
        {
            FILE_NOT_FOUND, INVALID_FILE_TYPE, INCORRECT_HEADER,
            NO_SUCH_COUNTRY,
            INCOREECT_DELIMITER
        }
        /// <summary>
        /// Creating a Constructor 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public CensusAnalyserException(string message, ExceptionType exception) : base(message)
        {
            this.exception = exception;
        }
    }
}