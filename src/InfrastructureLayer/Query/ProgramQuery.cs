namespace InfrastructureLayer.Query
{
    public struct ProgramQuery
    {
        public readonly string spGetAll => (@"
            SELECT * FROM ProgramTbl;
        ");

        public readonly string spGetAllProgram => (@"
            SELECT 
                ProgramId, ProgramName
            From 
                ProgramTbl;
        ");

        public readonly string spInsertNew => (@"
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

        public readonly string spUpdate => (@"
            UPDATE 
                ProgramTbl
            SET 
                ProgramName = @p_ProgramName,
                DepartmentId = @p_DepartmentId,
                DepartmentName = @p_DepartmentName
            WHERE 
                ProgramId = @p_ProgramId;
        ");

        public readonly string spUpdateProgramId => (@"
            UPDATE 
                ProgramTbl
            SET 
                ProgramId = @p_ProgramId
            WHERE
                ProgramName = @p_ProgramName;
        ");

        public readonly string spDelete => (@"
            DELETE FROM 
                ProgramTbl
            WHERE 
                ProgramId = @p_ProgramId;
        ");
    }
}
