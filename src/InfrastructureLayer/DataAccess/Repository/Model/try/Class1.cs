using CommonComponets;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.DataAccess.Repository.Model
{
    public class Class1
    {
        enum TypeOfExistenceCheck
        {
            DoesExistInTheDB,
            DoesNotExistInTheDB,
        }
        enum RequestType
        {
            Add,
            Update,
            Read,
            Delete,
            ConfirmAdd,
            ConfirmDelete
        }
        enum ModelValueAssignmentMethod
        {
            AssignCourseInfoModelValue,
            AssignEdutrackUserInfoModelValue,
            AssignStudentGradeInfoModelValue,
            AssignStudentPersonalInfoModelValue,
            AssignStudentAcademicInfoModelValue,
            AssignStudentAttendanceInfoModelValue,
            AssignInstructorPersonalInfoModelValue,
            AssignInstructorAcademicInfoModelValue
        }

        public Class1()
        {

        }
        public Class1(string connectionString)
        {
            _connectionString = connectionString;
        }

        private void ConnectDatabase(MySqlConnection mysqlConnection)
        {
            string _connectionString = ConfigurationManager.ConnectionStrings["CONSTR.EDUTRACK"].ConnectionString;
            
            try
            {
                MySqlConnection conn = new MySqlConnection(_connectionString);
                mysqlConnection.Open();
            }
            catch (MySqlException e)
            {
                dataAccessStatus.SetValues(status: "Error", operationSucceeded: false, exceptionMessage: e.Message,
                                            customMessage: "Unable to add data from the database. Failed to open database.",
                                            helpLink: e.HelpLink, errorCode: e.ErrorCode, StackTrace: e.StackTrace);
                throw new DataAccessException(e.Message, e.InnerException, dataAccessStatus);
            }
        }
    }
}
