namespace InfrastructureLayer.Query
{
    public struct StudentAcadInfoQuery
    {
        public readonly string GetAll => (@"
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
            INNER JOIN
                NameTbl StudentName ON StudentAIT.SrCode = StudentName.UserId;
        ");
    }
}
