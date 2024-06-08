using DomainLayer.Models.CommonModel.DistinctModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.InformationModel.AcademicModel;
using DomainLayer.Models.CommonModel.BaseModel;

namespace DomainLayer.Models.DerivedModel
{
    public interface IStudentSharedInfoModel : IStudentPropertyModel { }


    class StudentSharedInfoModel : StudentPropertyModel, IStudentSharedInfoModel
    {
        private ICourseInfoModel _courseModel = new CourseInfoModel();
        private IAcademicInfoModel _academicInfoModel = new AcademicInfoModel();

        public string CourseCode
        {
            get => _courseModel.CourseCode;
            set => _courseModel.CourseCode = value;
        }
        public string Section
        {
            get => _academicInfoModel.Section;
            set => _academicInfoModel.Section = value;
        }
    }
}
