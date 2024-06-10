
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.CommonModel.BaseModel;
using DomainLayer.Models.CommonModel.DistinctModel;


namespace DomainLayer.Models.InformationModel.AcademicModel
{
    public interface IInstructorAcademicInfoModel : IAcademicInfoModel, IInstructorPropertyModel 
    { 
    
    }

    class InstructorAcademicInfoModel : AcademicInfoModel, IInstructorAcademicInfoModel
    {
        public InstructorAcademicInfoModel()
        {
            _instructorModel = new InstructorPropertyModel();
        }

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


        private IInstructorPropertyModel _instructorModel;
    }
}
