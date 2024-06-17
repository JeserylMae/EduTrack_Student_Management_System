using InfrastructureLayer.Repository.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InfrastructureLayer.Repository.ModelQuery
{
    internal class CourseInfoModelQuery
    {
        internal static string ModelQueryGenerator(AccessDefaultVariation.RequestType requestType,
												   AccessDefaultVariation.RequestFrom requestFrom)
        {
			string modelQuery = string.Empty;

            if(requestType == AccessDefaultVariation.RequestType.GetAll)
			{
				modelQuery = "SELECT * FROM CourseInfoTbl";
			}
			else if(requestType == AccessDefaultVariation.RequestType.GetById)
			{
				modelQuery = "SELECT * FROM CourseInfoTbl WHERE SrCode = @SrCode";
			}
			else if (requestType == AccessDefaultVariation.RequestType.Add)
            {
                modelQuery = "SELECT * FROM CourseInfoTbl";
            }
			else if(requestType == AccessDefaultVariation.RequestType.Update)
			{
				modelQuery = "UPDATE CourseInfoTbl "
						   + "SET CourseName = @CourseName, NumberOfUnits = @NumberOfUnits "
						   + "WHERE CourseCode = @CourseCode;";
			}
			else if(requestType == AccessDefaultVariation.RequestType.Delete)
			{
				modelQuery = "DELETE FROM CourseInfoTbl WHERE CourseCode = @CourseCode;";
			}

            return modelQuery;
        }
    }
}
