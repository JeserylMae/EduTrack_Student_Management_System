using PresentationLayer.Presenters.Enumerations;

namespace InfrastructureLayer.Query
{
    public struct InstructorAcademicInfoQuery
    {
        public readonly string spGetAll => (@"
            SELECT
                InstructorAIT.ItrCode,
                InstructorAIT.Course,
                InstructorAIT.Program,
                InstructorAIT.Section,
                InstructorAIT.Semester,
                InstructorAIT.YearLevel,
                InstructorAIT.AcademicYear,
                InstructorName.LastName,
                InstructorName.FirstName,
                InstructorName.MiddleName
            FROM
                InstructorAcademicInfoTbl as InstructorAIT
            LEFT JOIN 
                NameTbl InstructorName ON InstructorAIT.InstructorNameId = InstructorName.UserId;
        ");

        public string spGetAllDistinct(string field)
        {
            return ($@"
                SELECT 
                    DISTINCT {field}
                FROM 
                    InstructorAcademicInfoTbl;
            ");
        }

        public readonly string spGetRecordId => (@"
            SELECT
                RecordId
            FROM 
                InstructorAcademicInfoTbl
            WHERE
                (@p_ItrCode IS NULL OR ItrCode = @p_ItrCode) AND
                (@p_Course IS NULL OR Course = @p_Course) AND
                (@p_Section IS NULL OR Section = @p_Section) AND
                (@p_YearLevel IS NULL OR YearLevel = @p_YearLevel) AND
                (@p_AcademicYear IS NULL OR AcademicYear = @p_AcademicYear);
        ");

        public string spGetById(InstructorAcadParams parameters)
        {
            string query = (@"
                SELECT
                    InstructorAIT.ItrCode,
                    InstructorAIT.Course,
                    InstructorAIT.Program,
                    InstructorAIT.Section,
                    InstructorAIT.YearLevel,
                    InstructorAIT.Semester,
                    InstructorAIT.AcademicYear,
                    InstructorName.LastName,
                    InstructorName.FirstName,
                    InstructorName.MiddleName
                FROM
                    InstructorAcademicInfoTbl as InstructorAIT
                LEFT JOIN 
                    NameTbl InstructorName ON InstructorAIT.InstructorNameId = InstructorName.UserId
            ");
            HandleParameters(parameters, ref query);

            return query;
        }

        public readonly string spInsertNew => (@"
            INSERT INTO InstructorAcademicInfoTbl(
                ItrCode, InstructorNameId, Course, Program, Section, YearLevel, Semester, AcademicYear
            )
            VALUES(
                @p_ItrCode, @p_InstructorNameId, @p_Course, @p_Program, @p_Section, @p_YearLevel, @p_Semester, @p_AcademicYear
            );
        ");

        public readonly string spUpdate => (@"
            UPDATE
                InstructorAcademicInfoTbl
            SET
                InstructorNameId = @p_InstructorNameId,
                Course = @p_Course,
                Program = @p_Program,
                Section = @p_Section,
                Semester = @p_Semester, 
                YearLevel = @p_YearLevel,
                AcademicYear = @p_AcademicYear
            WHERE   
                ItrCode = @p_ItrCode AND
                RecordId = @p_RecordId;
        ");

        public string spDelete(InstructorAcadParams parameters)
        {
            string query = @"
                DELETE FROM InstructorAcademicInfoTbl AS InstructorAIT
            ";
            HandleParameters(parameters, ref query);

            return query;
        }

        #region Helpers
        private void HandleParameters(InstructorAcadParams parameters, ref string query)
        {
            switch (parameters)
            {
                case InstructorAcadParams.ItrCode:
                    query += @"WHERE InstructorAIT.ItrCode = @p_ItrCode;";
                    break;
                case InstructorAcadParams.ItrCodeAndAcademicYear:
                    query += @"
                        WHERE 
                            InstructorAIT.ItrCode = @p_ItrCode AND
                            InstructorAIT.AcademicYear = @p_AcademicYear;
                    ";
                    break;
                case InstructorAcadParams.ItrCodeAndAcademicYearAndYearLevel:
                    query += @"
                        WHERE 
                            InstructorAIT.ItrCode = @p_ItrCode AND
                            InstructorAIT.AcademicYear = @p_AcademicYear AND
                            InstructorAIT.YearLevel = @p_YearLevel;
                    ";
                    break;
                case InstructorAcadParams.ItrCodeAndAcademicYearAndYearLevelAndSemester:
                    query += @"
                        WHERE 
                            InstructorAIT.ItrCode = @p_ItrCode AND
                            InstructorAIT.AcademicYear = @p_AcademicYear AND
                            InstructorAIT.YearLevel = @p_YearLevel AND
                            InstructorAIT.Semester = @p_Semester;
                    ";
                    break;
                case InstructorAcadParams.ItrCodeAndAcademicYearAndYearLevelAndSemesterAndSection:
                    query += @"
                        WHERE 
                            InstructorAIT.ItrCode = @p_ItrCode AND
                            InstructorAIT.AcademicYear = @p_AcademicYear AND
                            InstructorAIT.YearLevel = @p_YearLevel AND
                            InstructorAIT.Semester = @p_Semester AND
                            InstructorAIT.Section = @p_Section;
                    ";
                    break;
                case InstructorAcadParams.ItrCodeAndAcademicYearAndYearLevelAndSemesterAndSectionAndCourse:
                    query += @"
                        WHERE 
                            InstructorAIT.ItrCode = @p_ItrCode AND
                            InstructorAIT.AcademicYear = @p_AcademicYear AND
                            InstructorAIT.YearLevel = @p_YearLevel AND
                            InstructorAIT.Semester = @p_Semester AND
                            InstructorAIT.Section = @p_Section AND
                            InstructorAIT.Course = @p_Course;
                    ";
                    break;
            }
        }
        #endregion
    }

}
