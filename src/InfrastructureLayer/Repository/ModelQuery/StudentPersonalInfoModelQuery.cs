using InfrastructureLayer.Repository.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repository.ModelQuery
{
    internal class StudentPersonalInfoModelQuery
    {
        internal static string ModelQueryGenerator(AccessDefaultVariation.RequestType requestType)
        {
            string modelQuery = string.Empty;

            if (requestType == AccessDefaultVariation.RequestType.GetAll)
            {
                modelQuery = "SELECT * FROM StudentPersonalInfoTbl";
            }
            else if (requestType == AccessDefaultVariation.RequestType.GetById)
            {
                modelQuery = "SELECT * FROM StudentPersonalInfoTbl WHERE SrCode = @SrCode";
            }
            else if (requestType == AccessDefaultVariation.RequestType.Add)
            {
                modelQuery = "INSERT INTO StudentPersonalInfoTbl "
                           + "VALUES(@SrCode, @LastName, @FirstName, @MiddleName, @BirthDate, @Gender, @HomeAddress, @EmailAddress, @ContactNumber, @EmergencyContactName, @EmergencyContactNumber)";
            }
            else if (requestType == AccessDefaultVariation.RequestType.Update)
            {
                modelQuery = "UPDATE StudentPersonalInfoTbl "
                           + "SET LastName = @Lastname, "
                           + "FisrtName = @FirstName, "
                           + "MiddleName = @MiddleName, "
                           + "BirthDate = @BirthDate, "
                           + "Gender = @Gender, "
                           + "HomeAddress = @HomeAddress, "
                           + "EmailAddress = @EmailAddress, "
                           + "ContactNumber = @ContactNumber, "
                           + "EmergencyContactName = @EmergencyContactName, "
                           + "EmergencyContactNumber = @EmergencyContactNumber "
                           + "WHERE SrCode = @SrCode;";
            }
            else if (requestType == AccessDefaultVariation.RequestType.Delete)
            {
                modelQuery = "DELETE FROM StudentPersonalInfoTbl WHERE SrCode = @SrCode;";
            }

            return modelQuery;
        }
    }
}
