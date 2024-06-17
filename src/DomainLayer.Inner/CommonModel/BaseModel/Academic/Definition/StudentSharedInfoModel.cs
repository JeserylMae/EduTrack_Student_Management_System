
using DomainLayer.Inner.CommonModel.DistinctModel;


namespace DomainLayer.Inner.CommonModel.BaseModel
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
    }
}
