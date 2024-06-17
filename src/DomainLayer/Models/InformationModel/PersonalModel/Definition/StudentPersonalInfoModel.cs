
using DomainLayer.Inner.CommonModel.BaseModel;
using DomainLayer.Inner.CommonModel.DistinctModel;

namespace DomainLayer.Models.InformationModel.PersonalModel
{
    public class StudentPersonalInfoModel : PersonalInfoModel, IStudentPersonalInfoModel
    {
        public StudentPersonalInfoModel() 
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


