using DomainLayer.Models.InformationModel.AcademicModel;
using InfrastructureLayer.Repository.ModelQuery;
using System.Collections.Generic;
using System;
using DomainLayer.Models.DerivedModel;

namespace InfrastructureLayer.Repository.Access
{
    public static class AccessDefaultVariation
    {
        public static void InitializeQueryGenerator() 
        {
            _ModelDatabaseQueryGenerator = new Dictionary<string, _GetModelQuery>
            {
                { nameof(CourseInfoModel), new _GetModelQuery(CourseInfoModelQuery.ModelQueryGenerator) },
                { nameof(EdutrackUserModel), new _GetModelQuery(EdutrackUserModelQuery.ModelQueryGenerator) }
            };
        }

        public static string GenerateQuery<TDomainModel>(TDomainModel domainModel, AccessDefaultVariation.RequestFrom requestFrom,
                                                         AccessDefaultVariation.RequestType requestType)
        {
            if (_ModelDatabaseQueryGenerator.TryGetValue(nameof(domainModel), out _GetModelQuery queryGenerator))
            {
                return queryGenerator.DynamicInvoke(requestType, requestFrom).ToString();
            }

            return string.Empty;
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
        private static Dictionary<string, _GetModelQuery> _ModelDatabaseQueryGenerator;
    }
}
