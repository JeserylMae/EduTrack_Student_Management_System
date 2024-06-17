
using DomainLayer.Inner.CommonModel.BaseModel;
using DomainLayer.Inner.CommonModel.DistinctModel;


namespace DomainLayer.Models.InformationModel.AcademicModel
{
    public class StudentAcademicInfoModel : AcademicInfoModel, IStudentAcademicInfoModel
    {
        public StudentAcademicInfoModel()
        {
            StudentPropertyModel = new StudentPropertyModel();
        }

        public StudentPropertyModel StudentPropertyModel
        {
            get => StudentPropertyModel;
            set => StudentPropertyModel = value;
        }
    }
}
