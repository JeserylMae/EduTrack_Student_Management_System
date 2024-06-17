using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfrastructureLayer.DataAccess.Repository.Access;


namespace InfrastructureLayer.DataAccess.Repository.Model
{
    public class CourseInfoModelRepository
    {
        public static string CourseInfoModelQueryGenerator(AccessDefaultVariation.RequestType requestType)
        {
									string modelQuery = string.Empty;

            if (requestType == AccessDefaultVariation.RequestType.Add)
            {
                modelQuery = "SELECT * FROM CourseInfoTbl";
            }
	else if(requestType == AccessDefaultVariation.RequestType.Update)
	{
		modelQuery = "UPDATE CourseInfoTbl "
										+ "SET CourseName = @CourseName AND NumberOfUnits = @NumberOfUnits "
										+ "WHERE CourseCode = @CourseCode;";
	}
	else if(requestType == AccessDefaultVariation.RequestType.Delete)
	{
		modelQuery = "DELETE FROM CourseInfoTbl WHERE CourseCode = @CourseCode;";
	}
	else if(requestType == AccessDefaultVaration.RequestType.GetAll)
	{
		modelQuery = "SELECT * FROM CourseInfoTbl";
	}
	else if(requestType == AccessDefaultVariation.RequestType.GetId)
	{
		modelQuery = "SELECT ";
	}

            return string.Empty;
        }
    }
}
