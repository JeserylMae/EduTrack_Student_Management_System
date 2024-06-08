using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.CommonModel.BaseModel;
using DomainLayer.Models.CommonModel.DistinctModel;

namespace DomainLayer.Models.InformationModel.PersonalModel
{
    public interface IInstructorPersonalInfoModel : IInstructorPropertyModel, IPersonalInfoModel { }

    class InstructorPersonalInfoModel : PersonalInfoModel, IInstructorPersonalInfoModel
    {
        private IInstructorPersonalInfoModel _instructorModel = new InstructorPersonalInfoModel();

        public string InstructorID
        {
            get => _instructorModel.InstructorID;
            set => _instructorModel.InstructorID = value;
        }
        public string SpecializedDegree
        {
            get => _instructorModel.SpecializedDegree;
            set => _instructorModel.SpecializedDegree = value;
        }
    }
}
