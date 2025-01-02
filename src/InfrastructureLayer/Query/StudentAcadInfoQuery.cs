using PresentationLayer.Presenters.Enumerations;

namespace InfrastructureLayer.Query
{
    public struct StudentAcadInfoQuery
    {

        public readonly string spGetAll => (@"
            SELECT 
                StudentAIT.SrCode, 
                StudentAIT.YearLevel,
                StudentAIT.Semester,
                StudentAIT.Section,
                StudentAIT.AcademicYear,
                StudentAIT.Program,
                StudentName.LastName,   
                StudentName.FirstName,
                StudentName.MiddleName
            FROM 
                StudentAcademicInfoTbl as StudentAIT
            LEFT JOIN
                NameTbl StudentName ON StudentAIT.StudentNameId = StudentName.UserId;
        ");

        public readonly string spGetAllSections => (@"
            SELECT 
                DISTINCT Section
            FROM
                StudentAcademicInfoTbl;
        ");

        public readonly string spGetRecordId => (@"
            SELECT Id
            FROM StudentAcademicInfoTbl
            WHERE 
                SrCode = @p_SrCode AND
                Semester = @p_Semester AND
                YearLevel = @p_YearLevel AND
                AcademicYear = @p_AcademicYear;
        ");

        public string spGetById(StudentAcadParams parameter)
        {
            string query = (@"
                SELECT
                    StudentAIT.SrCode, 
                    StudentAIT.YearLevel,
                    StudentAIT.Semester,
                    StudentAIT.Section,
                    StudentAIT.AcademicYear,
                    StudentAIT.Program,
                    StudentName.LastName,   
                    StudentName.FirstName,
                    StudentName.MiddleName
                FROM 
                    StudentAcademicInfoTbl as StudentAIT
                LEFT JOIN
                    NameTbl StudentName ON StudentAIT.StudentNameId = StudentName.UserId
            ");
            HandleParameter(ref query, parameter);

            return query;
        }

        public readonly string spInsertNew => (@"
            INSERT INTO StudentAcademicInfoTbl (SrCode, StudentNameId, YearLevel, Semester, Section, AcademicYear, Program)
            Values(@p_SrCode, @p_StudentNameId, @p_YearLevel, @p_Semester, @p_Section, @p_AcademicYear, @p_Program);
        ");

        public readonly string spUpdate => (@"
            UPDATE 
                StudentAcademicInfoTbl
            SET
                Section = @p_Section,
                Program = @p_Program,
                AcademicYear = @p_AcademicYear,
                YearLevel = @p_YearLevel,
                Semester = @p_Semester
            WHERE
                SrCode = @p_SrCode AND
                Id = @p_Id;
        ");

        public string spDelete(StudentAcadParams parameter)
        {
            string query = @"DELETE FROM StudentAcademicInfoTbl AS StudentAIT";

            HandleParameter(ref query, parameter);
            
            return query;
        }

        private void HandleParameter(ref string query, StudentAcadParams parameter)
        {
            switch (parameter)
            {
                case StudentAcadParams.SrCode:
                    query += @"WHERE StudentAIT.SrCode = @p_SrCode";
                    break;
                case StudentAcadParams.SrCodeAndAcadYear:
                    query += @"WHERE StudentAIT.SrCode = @p_SrCode AND StudentAIT.AcademicYear = @p_AcademicYear;";
                    break;
                case StudentAcadParams.SrCodeAndAcadYearAndYearLevel:
                    query += @"
                        WHERE
                            StudentAIT.SrCode = @p_SrCode AND
                            StudentAIT.AcademicYear = @p_AcademicYear AND
                            StudentAIT.YearLevel = @p_YearLevel;
                    ";
                    break;
                case StudentAcadParams.SrCodeAndAcadYearAndYearLevelAndSemester:
                    query += @"
                        WHERE
                            StudentAIT.SrCode = @p_SrCode AND
                            StudentAIT.AcademicYear = @p_AcademicYear AND
                            StudentAIT.YearLevel = @p_YearLevel AND
                            StudentAIT.Semester = @p_Semester;
                    ";
                    break;
                case StudentAcadParams.None:
                    throw new InvalidDataException(message: "Missing parameters.");
            }
        }
    }
}
