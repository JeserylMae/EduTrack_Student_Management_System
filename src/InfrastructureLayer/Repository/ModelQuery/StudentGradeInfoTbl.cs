using InfrastructureLayer.Repository.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repository.ModelQuery
{
    internal class StudentGradeInfoTbl
    {
        internal static string ModelQueryGenerator(AccessDefaultVariation.RequestType requestType)
        {
            string modelQuery = string.Empty;

            if (requestType == AccessDefaultVariation.RequestType.GetAll)
            {
                modelQuery = "SELECT (SrCode, CourseCode, Grade, ClassSection, Semester, AcademicYear) "
                           + "FROM StudentGradeInfoTbl";
            }
            else if (requestType == AccessDefaultVariation.RequestType.GetById)
            {
                modelQuery = "SELECT * FROM StudentGradeInfoTbl WHERE SrCode = @SrCode;";
            }
            else if (requestType == AccessDefaultVariation.RequestType.GetAllById)
            {
                modelQuery = "SELECT * FROM StudentGradeInfoTbl WHERE SrCode = @SrCode "
                           + "AND ClassSection = @ClassSection";
            }
            else if (requestType == AccessDefaultVariation.RequestType.Add)
            {
                modelQuery = "INSERT INTO StudentGradeInfoTbl(SrCode, CourseCode, Grade, ClassSection, Semester, AcademicYear) "
                           + "VALUES(@SrCode, @CourseCode, @Grade, @ClassSection, @Semester, @AcademicYear)";
            }
            else if (requestType == AccessDefaultVariation.RequestType.Update)
            {
                modelQuery = "UPDATE StudentGradeInfoTbl "
                           + "SET CourseCode = @CourseCode, "
                           + "Grade = @Grade, "
                           + "Semester = @Semester, "
                           + "AcademicYear = @AcademicYear "
                           + "WHERE SrCode = @SrCode AND ClassSection = @ClassSection;";
            }
            else if (requestType == AccessDefaultVariation.RequestType.Delete)
            {
                modelQuery = "DELETE FROM StudentGradeInfoTbl "
                           + "WHERE SrCode = @SrCode AND ClassSection = @ClassSection;";
            }
            else if (requestType == AccessDefaultVariation.RequestType.DeleteAll)
            {
                modelQuery = "DELETE FROM StudentGradeInfoTbl WHERE SrCode = @SrCode;";
            }

            return modelQuery;
        }
    }
}
