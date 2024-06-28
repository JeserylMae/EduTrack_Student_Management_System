using WebService.DbAccess;

namespace WebService.ApiService
{
    public static class WebApiTest
    {
        public static void ConfigureApi(this WebApplication app)
        {
            app.MapGet("/EdutrackUserTbl", GetUsers);
        }

        public static async Task<IResult> GetUsers(IEdutrackUserDataAccess edutrackUserDataAccess)
        {
            try
            {
                return Results.Ok(await edutrackUserDataAccess.GetUsers());
            }
            catch (Exception ex) 
            { 
                return Results.Problem(ex.Message);
            }
        }
    }
}
