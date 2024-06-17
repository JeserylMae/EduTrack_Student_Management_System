
using System.Collections.Generic;
using System.Configuration;
using CommonComponets;
using MySql.Data.MySqlClient;


namespace InfrastructureLayer.DataAccess.Repository.Database
{
    internal static class DatabaseManager
    {
        internal static string DatabaseConnectionStringGetter()
        {
            return ConfigurationManager.ConnectionStrings["CONSTR.EDUTRACK"].ConnectionString;
        }

        internal static void DatabaseConnection(string connectionString)
        {
            DataAccessStatus dataAccessStatus = new DataAccessStatus();

            if (connectionString == null) 
            {
                dataAccessStatus.SetValues(customMessage: "Unable to connect database! Connection string is missing.", exception: null);
                throw new DataAccessException(dataAccessStatus);
            }

            try 
            { 
                MySqlConnection dbConnection = new MySqlConnection(connectionString);
                dbConnection.Open();
            }
            catch (MySqlException e) 
            {
                dataAccessStatus.SetValues(customMessage: "Operation cannot be performed! Database connection failed.", exception: e);
                throw new DataAccessException(e.Message, e.InnerException, dataAccessStatus);
            }
        }

        internal static void DatabaseDisconnection(MySqlConnection dbConnection)
        {
            dbConnection.Close();
            dbConnection.Dispose();
        }
    }
}


/// <summary>
/// 
/// variables/entities to be declared:
/// 1. Readonlydict 
///     
/// 
/// create a fucntion which will obtain the classname of the object passed on the add, delete, etc.
/// functions.
/// 
/// </summary>
