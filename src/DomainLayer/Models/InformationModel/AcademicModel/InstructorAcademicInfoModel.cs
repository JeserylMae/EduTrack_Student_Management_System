
using DomainLayer.Inner.CommonModel.BaseModel;
using DomainLayer.Inner.CommonModel.DistinctModel;
using DomainLayer.Models.InformationModel.AcademicModel;

namespace DomainLayer.Models.InformationModel.AcademicModel
{
    public class InstructorAcademicInfoModel : AcademicInfoModel, IInstructorAcademicInfoModel
    {
        public InstructorAcademicInfoModel()
        {
            InstructorPropertyModel = new InstructorPropertyModel();
            SharedCourseInfoModel = new SharedCourseInfoModel();
        }

        public InstructorPropertyModel InstructorPropertyModel
        {
            get => InstructorPropertyModel;
            set => InstructorPropertyModel = value;
        }
        public SharedCourseInfoModel SharedCourseInfoModel
        {
            get => SharedCourseInfoModel;
            set=> SharedCourseInfoModel = value;
        }
    }
}
