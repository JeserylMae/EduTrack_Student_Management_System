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
    public interface IStudentSharedInfoModel : IStudentPropertyModel 
    {
    
    }

    class StudentSharedInfoModel : StudentPropertyModel, IStudentSharedInfoModel
    {
        public StudentSharedInfoModel() 
        { 
            _courseInfoModel = new CourseInfoModel();
            _academicInfoModel = new AcademicInfoModel();  
        } 

        public string CourseCode
        {
            get => _courseInfoModel.CourseCode;
            set => _courseInfoModel.CourseCode = value;
        }
        public string Section
        {
            get => _academicInfoModel.Section;
            set => _academicInfoModel.Section = value;
        }


        private ICourseInfoModel _courseInfoModel;
        private IAcademicInfoModel _academicInfoModel;
    }
}
