using InfrastructureLayer.Repository.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repository.ModelQuery
{
    internal class EdutrackUserModelQuery
    {
        internal static string ModelQueryGenerator(AccessDefaultVariation.RequestType requestType,
                                                   AccessDefaultVariation.RequestFrom requestFrom)
        {
            string modelQuery = string.Empty;

            if (requestFrom == AccessDefaultVariation.RequestFrom.Student)
                return modelQuery;

            if (requestType == AccessDefaultVariation.RequestType.GetAll)
            {
                modelQuery = "SELECT * FROM EdutrackUserTbl";
            }
            else if (requestType == AccessDefaultVariation.RequestType.GetById)
            {
                modelQuery = "SELECT * FROM EdutrackUserTbl WHERE UserID = @UserID";
            }
            else if (requestType == AccessDefaultVariation.RequestType.Add)
            {
                modelQuery = "INSERT INTO EdutrackUserTbl(UserId, UserPassword, EmailAddress) "
                           + "VALUES(@UserId, @UserPassword, @EmailAddress)";
            }
            else if (requestType == AccessDefaultVariation.RequestType.Update) 
            {
                modelQuery = "UPDATE EdutrackUserTbl "
                           + "SET UserPassword = @UserPassword, EmailAddress = @ EmailAddress "
                           + "WHERE UserId = @UserId;";
            }
            else if (requestType == AccessDefaultVariation.RequestType.Delete) 
            {
                modelQuery = "DELETE FROM EdutrackUserTbl WHERE UserId = @UserId;";
            }

            return modelQuery;
        }
    }
}
