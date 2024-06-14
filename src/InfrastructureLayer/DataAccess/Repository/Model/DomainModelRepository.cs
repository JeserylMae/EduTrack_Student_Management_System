using DomainLayer.Models.InformationModel.AcademicModel;
using ServiceLayer.Services.ModelServices;
using MySql.Data.MySqlClient;
using CommonComponets;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Mysqlx;
using System.Diagnostics;

namespace InfrastructureLayer.DataAccess.Repository.Model
{
    public class DomainModelRepository : IDomainModelRepository
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

        public DomainModelRepository()
        {
            
        }
        public DomainModelRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        
        public IEnumerable<TDomainModel> GetAll<TDomainModel>() where TDomainModel : class
        {
            List<TDomainModel> domainModelList = new List<TDomainModel>();
            DataAccessStatus dataAccessStatus = new DataAccessStatus();

            using (MySqlConnection mysqlConnection = new MySqlConnection(_connectionString))
            {
                try
                {
                    string sql = "SELECT * FROM Departments";

                    mysqlConnection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, mysqlConnection))
                    {

                        // this should be inside another function and should be called using delegates.
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                IStudentAcademicInfoModel studentAcadeimicInfoModel = new StudentAcademicInfoModel();
                                studentAcadeimicInfoModel.StudentPropertyModel.SrCode = reader["SrCode"].ToString();
                                studentAcadeimicInfoModel.Section = reader["ClassSection"].ToString();
                                studentAcadeimicInfoModel.Semester = reader["Semester"].ToString();
                                studentAcadeimicInfoModel.Year = reader["YearLevel"].ToString();
                                studentAcadeimicInfoModel.AcademicYear = reader["AcademicYear"].ToString();
                            }
                        }
                        mysqlConnection.Close();
                    }
                }
                catch (MySqlException e)
                {
                    dataAccessStatus.SetValues(status: "Error", operationSucceeded: false, exceptionMessage: e.Message,
                                               customMessage: "Unable to get Department Model list from the database.",
                                               helpLink: e.HelpLink, errorCode: e.ErrorCode, StackTrace: e.StackTrace);
                    throw new DataAccessException(e.Message, e.InnerException, dataAccessStatus);
                }
            }
            return domainModelList;
        }

        public TDomainModel GetByID<TDomainModel>(string id) where TDomainModel : class
        {
            StudentAcademicInfoModel studentAcademicInfoModel = new StudentAcademicInfoModel();
            DataAccessStatus dataAccessStatus = new DataAccessStatus();
            bool MatchingRecordFound = false;
            string sql = "SELECT * FROM StudentAcademicInfoTbl WHERE SrCode = @SrCode";

            using (MySqlConnection mysqlConnection = new MySqlConnection(_connectionString))
            {
                try
                {
                    mysqlConnection.Open();
                    
                    using (MySqlCommand cmd = new MySqlCommand(sql, mysqlConnection))
                    {
                        cmd.CommandText = sql;
                        cmd.Prepare();
                        cmd.Parameters.Add(new MySqlParameter("@SrCode", id));

                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            MatchingRecordFound = reader.HasRows;
                            while(reader.Read())
                            {
                                studentAcademicInfoModel.StudentPropertyModel.SrCode = reader["SrCode"].ToString();
                                studentAcademicInfoModel.Section = reader["ClassSection"].ToString();
                                studentAcademicInfoModel.Semester = reader["Semester"].ToString();
                                studentAcademicInfoModel.Year = reader["YearLevel"].ToString();
                                studentAcademicInfoModel.AcademicYear = reader["AcademicYear"].ToString();
                            }
                        }
                        mysqlConnection.Close();
                    }
                }
                catch (MySqlException e)
                {
                    dataAccessStatus.SetValues(status: "Error", operationSucceeded: false, exceptionMessage: e.Message,
                                               customMessage: "Unable to get Department Model for requested id from the database.",
                                               helpLink: e.HelpLink, errorCode: e.ErrorCode, StackTrace: e.StackTrace);
                    throw new DataAccessException(e.Message, e.InnerException, dataAccessStatus);
                }

                if(!MatchingRecordFound)
                {
                    dataAccessStatus.SetValues(status: "Error", operationSucceeded: false, exceptionMessage: string.Empty,
                                               customMessage: "Unable to get Department Model list from the database. " +
                                                              $"ID {id} does not exist in the database.",
                                               helpLink: string.Empty, errorCode: 0, StackTrace: string.Empty);
                    throw new DataAccessException(dataAccessStatus);
                }
            }
            return studentAcademicInfoModel;
        }

        public void Add<TDomainModel>(TDomainModel DomainDataModel) where TDomainModel : class
        {
            DataAccessStatus dataAccessStatus = new DataAccessStatus();

            using (MySqlConnection mysqlConnection = new MySqlConnection(_connectionString))
            {
                try
                {
                    mysqlConnection.Open();   
                }
                catch (MySqlException e) 
                {
                    dataAccessStatus.SetValues(status: "Error", operationSucceeded: false, exceptionMessage: e.Message,
                                                customMessage: "Unable to add data from the database. Failed to open database.",
                                                helpLink: e.HelpLink, errorCode: e.ErrorCode, StackTrace: e.StackTrace);
                    throw new DataAccessException(e.Message, e.InnerException, dataAccessStatus);
                }

                string mysqlQuery = "INSERT INTO StudentAcademicInfoTbl"
                                  + "VALUES(@SrCode, @ClassSection, @Semester, @YearLevel, @AcademicYear)";

                using (MySqlCommand cmd = new MySqlCommand(mysqlQuery, mysqlConnection))
                {
                    try
                    {
                        RecordExistsCheck(cmd, DomainDataModel, TypeOfExistenceCheck.DoesNotExistInTheDB, RequestType.Add);
                    }
                    catch(DataAccessException ex) 
                    { 
                        ex.CustomMessage = 
                    }
                }
            }
        }


        private string _connectionString;
    }
}


/// <summary>
/// 1. Copy first the code from the YT. Spefically the codes for:
///     add
///     update
///     delete
///     GetAll
///     GetById
///     and the verification code related to them.
/// 2. Modify the code to suit your project. Instead of repeated 
/// creation of the functions above, just create functions for each model
/// for assignment of values from DB. 
/// 
/// 3. Using delegates call 
/// 
/// ==== Define a delegate ====
/// public delegate void MyDelegate(string message);
/// public class Program
/// {
///    public static void Main()
///    {
///        // Instantiate the delegate and pass it to a method
///        MyDelegate del = new MyDelegate(DisplayMessage);
///        ProcessMessage(del);
///    }
///    public static void DisplayMessage(string message)
///    {
///        Console.WriteLine(message);
///    }
///    public static void ProcessMessage(MyDelegate del)
///    {
///        del("Hello, World!");
///    }
/// }
/// 
/// 4. then put the delegates into a dict
/// using System;
////using System.Collections.Generic;

////public enum Operation
////{
////    Add,
////    Subtract,
////    Multiply,
////    Divide
////}

////public class Program
////{
////    // Define a delegate
////    public delegate int MathOperation(int a, int b);

////    public static void Main()
////    {
////        // Create a dictionary to map enum values to delegates
////        Dictionary<Operation, MathOperation> operations = new Dictionary<Operation, MathOperation>
////        {
////            { Operation.Add, Add },
////            { Operation.Subtract, Subtract },
////            { Operation.Multiply, Multiply },
////            { Operation.Divide, Divide }
////        };

////        // Use the enum to invoke the corresponding delegate
////        int a = 10;
////        int b = 5;
////        Operation op = Operation.Multiply;

////        if (operations.TryGetValue(op, out MathOperation operation))
////        {
////            int result = operation(a, b);
////            Console.WriteLine($"Result of {op}: {result}");
////        }
////        else
////        {
////            Console.WriteLine("Operation not found.");
////        }
////    }

////    public static int Add(int a, int b) => a + b;
////    public static int Subtract(int a, int b) => a - b;
////    public static int Multiply(int a, int b) => a * b;
////    public static int Divide(int a, int b) => a / b;
////}

/// 
/// </summary>