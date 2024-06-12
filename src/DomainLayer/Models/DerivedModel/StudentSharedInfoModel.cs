using DomainLayer.Models.CommonModel.DistinctModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.InformationModel.AcademicModel;
using DomainLayer.Models.CommonModel.BaseModel;
using System.Runtime.InteropServices;
using System.Reflection;

namespace DomainLayer.Models.DerivedModel
{
    public class StudentSharedInfoModel
    {
        public StudentSharedInfoModel()
        {
            _studentPropertyModel = new StudentPropertyModel();
            _sharedCourseInfoModel = new SharedCourseInfoModel();
            _sharedAcademicInfoModel = new SharedAcademicInfoModel();
        }

        public StudentPropertyModel StudentPropertyModel
        {
            get => (StudentPropertyModel)_studentPropertyModel;
            set => _studentPropertyModel = value;
        }

        public SharedCourseInfoModel SharedCourseInfoModel
        {
            get => (SharedCourseInfoModel)_sharedCourseInfoModel;
        }

        public SharedAcademicInfoModel SharedAcademicInfoModel
        {
            get => (SharedAcademicInfoModel)_sharedAcademicInfoModel;
            set => _sharedAcademicInfoModel = value;
        }

        private IStudentPropertyModel _studentPropertyModel;
        private ISharedCourseInfoModel _sharedCourseInfoModel;
        private ISharedAcademicInfoModel _sharedAcademicInfoModel;
    }
}
