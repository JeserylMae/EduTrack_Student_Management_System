

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.CommonModel.BaseModel;
using DomainLayer.Models.CommonModel.DistinctModel;


namespace DomainLayer.Models.InformationModel.AcademicModel
{
    public class InstructorAcademicInfoModel : AcademicInfoModel, IInstructorAcademicInfoModel
    {
        public InstructorAcademicInfoModel()
        {
            _instructorPropertyModel = new InstructorPropertyModel();
            _sharedCourseInfoModel = new SharedCourseInfoModel();
        }

        public InstructorPropertyModel InstructorPropertyModel
        {
            get => (InstructorPropertyModel)_instructorPropertyModel;
            set => _instructorPropertyModel = value;
        }
        public SharedCourseInfoModel SharedCourseInfoModel
        {
            get => (SharedCourseInfoModel)_sharedCourseInfoModel;
            set=> _sharedCourseInfoModel = value;
        }

        private IInstructorPropertyModel _instructorPropertyModel;
        private ISharedCourseInfoModel _sharedCourseInfoModel;
    }
}
