using DomainLayer.Models.InformationModel.AcademicModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfrastructureLayer.DataAccess.Repository.Model;

namespace InfrastructureLayer.DataAccess.Repository.Access
{
    public static class AccessDefaultVariation
    {
        public static void InitializeQueryGenrator() 
        {
            _ModelDatabaseQueryGenerator = new Dictionary<string, Delegate>();
            _ModelDatabaseQueryGenerator.Add(nameof(CourseInfoModel), new _GetModelQuery(CourseInfoModelRepository.CourseInfoModelQueryGenerator));
        }

        // sample of invoking delegates
        // if (delegateDictionary.TryGetValue("Add", out Delegate addDelegate))
        // {
        //    int result = (int)addDelegate.DynamicInvoke(10, 5);
        // Console.WriteLine($"Addition Result: {result}");
        // }

    public enum TypeOfExistenceCheck
        {
            DoesExistInTheDB,
            DoesNotExistInTheDB,
        }

        public enum RequestType
        {
            Add,
            Update,
            Read,
            Delete,
            GetAll,
            GetById,
            ConfirmAdd,
            ConfirmDelete
        }

        internal enum ModelValueAssignmentMethod
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

        internal static Dictionary<string, Func<string>> ModelDatabaseGenerator
        {
            get => ModelDatabaseGenerator;
        }


        private delegate string _GetModelQuery(RequestType requestType);
        private static Dictionary<string, Delegate> _ModelDatabaseQueryGenerator;
    }
}
