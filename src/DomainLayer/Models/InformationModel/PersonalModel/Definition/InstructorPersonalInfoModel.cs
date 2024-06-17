
using System.ComponentModel.DataAnnotations;
using DomainLayer.Inner.CommonModel.BaseModel;
using DomainLayer.Inner.CommonModel.DistinctModel;


namespace DomainLayer.Models.InformationModel.PersonalModel
{
    public class InstructorPersonalInfoModel : PersonalInfoModel, IInstructorPersonalInfoModel
    {
        public InstructorPersonalInfoModel()
        {
            InstructorPropertyModel = new InstructorPropertyModel();
        }

        public InstructorPropertyModel InstructorPropertyModel 
        {
            get => InstructorPropertyModel;
            set => InstructorPropertyModel = value;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Specialized degree must not be empty!")]
        [RegularExpression(@"[a-zA-X ]{10,50}")]
        public string SpecializedDegree { get; set; }
    }
}
