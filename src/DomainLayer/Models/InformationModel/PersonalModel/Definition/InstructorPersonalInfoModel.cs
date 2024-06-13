using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.CommonModel.BaseModel;
using DomainLayer.Models.CommonModel.DistinctModel;

namespace DomainLayer.Models.InformationModel.PersonalModel
{
    public class InstructorPersonalInfoModel : PersonalInfoModel, IInstructorPersonalInfoModel
    {
        public InstructorPersonalInfoModel()
        {
            _instructorPropertyModel = new InstructorPropertyModel();
        }

        public string InstructorID
        {
            get => _instructorPropertyModel.InstructorID;
            set => _instructorPropertyModel.InstructorID = value;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Specialized degree must not be empty!")]
        [RegularExpression(@"[a-zA-X ]{10,50}")]
        public string SpecializedDegree { get; set; }

        private IInstructorPropertyModel _instructorPropertyModel;
    }
}
