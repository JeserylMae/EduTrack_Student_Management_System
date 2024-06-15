using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonComponets
{
    public class DataAccessException : Exception
    {
        public DataAccessException() 
        {
            
        }
        public DataAccessException(DataAccessStatus dataAccessStatus) 
        {
            _dataAccessStatus = dataAccessStatus;
        }
        public DataAccessException(string message, Exception InnerExcpetion, DataAccessStatus dataAccessStatus)
                                   : base(message, InnerExcpetion)
        {
            _dataAccessStatus = dataAccessStatus;
        }
        public DataAccessStatus DataACcessStatus
        {
            get => _dataAccessStatus;
            set => _dataAccessStatus = value;
        }


        private DataAccessStatus _dataAccessStatus;
    }
}
