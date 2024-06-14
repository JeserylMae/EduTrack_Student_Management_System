using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonComponets
{
    public class DataAccessStatus
    {
        public string Status { get; set; } 
        public bool OperationSucceeded { get; set; }
        public string ExceptionMessage { get; set; }   
        public string CustomMessage { get; set; }
        public string HelpLink { get; set; }
        public int ErrorCode { get; set; }
        public string StackTrace { get; set; }


        public void SetValues(string status, bool operationSucceeded, string exceptionMessage, string customMessage, 
                                string helpLink, int errorCode, string StackTrace)
        {
            Status = status ?? string.Empty;
            OperationSucceeded = operationSucceeded;
            ExceptionMessage = exceptionMessage ?? string.Empty;
            CustomMessage = customMessage ?? string.Empty;
            HelpLink = helpLink ?? string.Empty;
            ErrorCode = errorCode;
            StackTrace = StackTrace ?? string.Empty;
        }

        public string GetFormattedValues()
        {
            string formattedValues = $"Status ---> {Status}"
                                   + $"Operation Succeeded ---> {OperationSucceeded}\n"
                                   + $"Exception Message ---> {ExceptionMessage}\n"
                                   + $"Custom Message ---> {CustomMessage}\n"
                                   + $"Help Link ---> {HelpLink}\n"
                                   + $"Error Code ---> {ErrorCode}\n"
                                   + $"Stack Trace ---> {StackTrace}";
            return formattedValues;
        }
    }
}
