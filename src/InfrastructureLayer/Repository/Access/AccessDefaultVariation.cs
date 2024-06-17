using DomainLayer.Models.InformationModel.AcademicModel;
using InfrastructureLayer.Repository.ModelQuery;
using System.Collections.Generic;
using System;
using DomainLayer.Models.DerivedModel;

namespace InfrastructureLayer.Repository.Access
{
    public static class AccessDefaultVariation
    {
        public static void InitializeQueryGenrator() 
        {
            _ModelDatabaseQueryGenerator = new Dictionary<string, Delegate>
            {
                { nameof(CourseInfoModel), new _GetModelQuery(CourseInfoModelQuery.ModelQueryGenerator) },
                { nameof(EdutrackUserModel), new _GetModelQuery(EdutrackUserModelQuery.ModelQueryGenerator) }
            };
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

        public enum RequestFrom
        {
            Admin,
            Student,
            Instructor
        }

        public enum RequestType
        {
            Add,
            Update,
            Delete,
            GetAll,
            GetById,
            DeleteAll,
            GetAllById,
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


        private delegate string _GetModelQuery(RequestType requestType, RequestFrom requestFrom);
        private static Dictionary<string, Delegate> _ModelDatabaseQueryGenerator;
    }
}
