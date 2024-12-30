namespace InfrastructureLayer.Query
{
    public struct ProgramQuery
    {
        public readonly string GetAll => (@"
            SELECT * FROM ProgramTbl;
        ");

        public readonly string GetAllProgram => (@"
            SELECT 
                ProgramId, ProgramName
            From 
                ProgramTbl;
        ");

        public readonly string InsertNew => (@"
            INSERT INTO ProgramTbl(
                ProgramId, 
                ProgramName, 
                DepartmentId, 
                DepartmentName
            )
            VALUES (
                @p_ProgramId, 
                @p_ProgramName, 
                @p_DepartmentId, 
                @p_DepartmentName
            );
        ");

        public readonly string Update => (@"
            UPDATE 
                ProgramTbl
            SET 
                ProgramName = @p_ProgramName,
                DepartmentId = @p_DepartmentId,
                DepartmentName = @p_DepartmentName
            WHERE 
                ProgramId = @p_ProgramId;
        ");

        public readonly string UpdateProgramId => (@"
            UPDATE 
                ProgramTbl
            SET 
                ProgramId = @p_ProgramId
            WHERE
                ProgramName = @p_ProgramName;
        ");

        public readonly string Delete => (@"
            DELETE FROM 
                ProgramTbl
            WHERE 
                ProgramId = @p_ProgramId;
        ");
    }
}
