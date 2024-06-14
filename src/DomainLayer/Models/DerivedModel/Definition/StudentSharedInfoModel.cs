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
    public class StudentSharedInfoModel : IStudentSharedInfoModel
    {
        public StudentSharedInfoModel()
        {
            StudentPropertyModel = new StudentPropertyModel();
            SharedCourseInfoModel = new SharedCourseInfoModel();
            SharedAcademicInfoModel = new SharedAcademicInfoModel();
        }

        public StudentPropertyModel StudentPropertyModel
        {
            get => StudentPropertyModel;
            set => StudentPropertyModel = value;
        }

        public SharedCourseInfoModel SharedCourseInfoModel
        {
            get => SharedCourseInfoModel;
            set => SharedCourseInfoModel = value;
        }

        public SharedAcademicInfoModel SharedAcademicInfoModel
        {
            get => SharedAcademicInfoModel;
            set => SharedAcademicInfoModel = value;
        }
       

        //private IStudentPropertyModel _studentPropertyModel;
        //private ISharedCourseInfoModel _sharedCourseInfoModel;
        //private ISharedAcademicInfoModel _sharedAcademicInfoModel;
    }
}
