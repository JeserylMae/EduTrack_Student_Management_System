namespace InfrastructureLayer.Query
{
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
    }
}
