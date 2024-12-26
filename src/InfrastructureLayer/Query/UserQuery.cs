namespace InfrastructureLayer.Query
{
    public struct UserQuery
    {
        public readonly string GetById => (@"
            SELECT * FROM UserTbl WHERE UserId = p_UserId;
        ");
    }
}
