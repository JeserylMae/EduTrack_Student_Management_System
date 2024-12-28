namespace InfrastructureLayer.Query
{
    public enum StudentAcadParams
    {
        None,
        SrCode,
        SrCodeAndAcadYear,
        SrCodeAndAcadYearAndYearLevel,
        SrCodeAndAcadYearAndYearLevelAndSemester
    }

    public struct StudentAcadInfoQuery
    {

        public readonly string spGetAll => (@"
            SELECT 
                StudentAIT.SrCode, 
                StudentName.LastName,   
                StudentName.FirstName,
                StudentName.MiddleName,
                StudentAIT.YearLevel,
                StudentAIT.Semester,
                StudentAIT.Section,
                StudentAIT.AcademicYear,
                StudentAIT.Program
            FROM 
                StudentAcademicInfoTbl as StudentAIT
            LEFT JOIN
                NameTbl StudentName ON StudentAIT.StudentNameId = StudentName.UserId;
        ");

        public string spGetById(StudentAcadParams parameter)
        {
            string query = (@"
                SELECT
                    StudentAIT.SrCode, 
                    StudentName.LastName,   
                    StudentName.FirstName,
                    StudentName.MiddleName,
                    StudentAIT.YearLevel,
                    StudentAIT.Semester,
                    StudentAIT.Section,
                    StudentAIT.AcademicYear,
                    StudentAIT.Program
                FROM 
                    StudentAcademicInfoTbl as StudentAIT
                LEFT JOIN
                    NameTbl StudentName ON StudentAIT.StudentNameId = StudentName.UserId
            ");
            HandleParameter(ref query, parameter);

            return query;
        }

        public readonly string spInsertNew => (@"
            INSERT INTO StudentAcademicInfoTbl
            Values(p_SrCode, p_StudentNameId, p_YearLevel, p_Semester, p_Section, p_AcademicYear, p_Program);
        ");

        public readonly string spUpdate => (@"
            UPDATE 
                StudentAcademicInfoTbl
            SET
                YearLevel = p_YearLevel,
                Semester = p_Semester,
                Section = p_Section,
                Program = p_Program,
                AcademicYear = p_AcademicYear
            WHERE
                SrCode = p_SrCode;
        ");

        public string spDelete(StudentAcadParams parameter)
        {
            string query = @"DELETE FROM StudentAcademicInfoTbl";

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
                            StudentAIT.YearLevel = @p_YearLevel
                            StudentAIT.Semester = @p_Semester;
                    ";
                    break;
                case StudentAcadParams.None:
                    throw new InvalidDataException(message: "Missing parameters.");
            }
        }
    }
}
