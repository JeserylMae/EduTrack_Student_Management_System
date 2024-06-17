using InfrastructureLayer.Repository.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InfrastructureLayer.Repository.Access.AccessDefaultVariation;

namespace InfrastructureLayer.Repository.ModelQuery
{
    internal class StudentAcademicInfoModelQuery
    {
        internal static string ModelQueryGenerator(AccessDefaultVariation.RequestType requestType,
                                                   AccessDefaultVariation.RequestFrom requestFrom)
        {
            string modelQuery = string.Empty;
           
            if (requestType == AccessDefaultVariation.RequestType.GetAll)
            {
                modelQuery = "SELECT * FROM StudentAcademicInfoTbl";
            }
            else if (requestType == AccessDefaultVariation.RequestType.GetById)
            {
                modelQuery = "SELECT * FROM StudentAcademicInfoTbl WHERE SrCode = @SrCode";
            }
            else if (requestType == AccessDefaultVariation.RequestType.Add)
            {
                modelQuery = "INSERT INTO StudentAcademicInfoTbl"
                           + "VALUES(@SrCode, @YearLevel, @Semester, @ClassSection, @AcademicLevel, @ProgramDepartment)";
            }
            else if (requestType == AccessDefaultVariation.RequestType.Update)
            {
                modelQuery = "UPDATE StudentAcademicInfoTbl "
                           + "SET YearLevel = @YearLevel, "
                           + "Semester = @Semester, "
                           + "ClassSection = @ClassSection, "
                           + "AcademicYear = @AcademicYear, "
                           + "ProgramDepartment = @ProgramDepartment "
                           + "WHERE SrCode = @SrCode;";
            }
            else if (requestType == AccessDefaultVariation.RequestType.Delete)
            {
                modelQuery = "DELETE FROM StudentAcademicInfoTbl WHERE SrCode = @SrCode AND AcademicYear = @AcademicYear;";
            }
            else if (requestType == AccessDefaultVariation.RequestType.DeleteAll)
            {
                modelQuery = "DELETE FROM StudentAcademicInfoTbl WHERE SrCode = @SrCode;";
            }

            return modelQuery;
        }
    }
}
