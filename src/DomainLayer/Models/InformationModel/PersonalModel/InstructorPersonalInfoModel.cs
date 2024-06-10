using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.CommonModel.BaseModel;
using DomainLayer.Models.CommonModel.DistinctModel;

namespace DomainLayer.Models.InformationModel.PersonalModel
{
    public interface IInstructorPersonalInfoModel : IInstructorPropertyModel, IPersonalInfoModel 
    { 
    
    }

    class InstructorPersonalInfoModel : PersonalInfoModel, IInstructorPersonalInfoModel
    {
        public InstructorPersonalInfoModel()
        {
            _instructorPropertyModel = new InstructorPersonalInfoModel();
        }

        public string InstructorID
        {
            get => _instructorPropertyModel.InstructorID;
            set => _instructorPropertyModel.InstructorID = value;
        }

        public string SpecializedDegree
        {
            get => _instructorPropertyModel.SpecializedDegree;
            set => _instructorPropertyModel.SpecializedDegree = value;
        }


        private IInstructorPropertyModel _instructorPropertyModel;
    }
}
