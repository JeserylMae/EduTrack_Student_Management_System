

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.CommonModel.BaseModel;
using DomainLayer.Models.CommonModel.DistinctModel;


namespace DomainLayer.Models.InformationModel.AcademicModel
{
    public interface IInstructorAcademicInfoModel : IAcademicInfoModel
    {

    }

    public class InstructorAcademicInfoModel : AcademicInfoModel, IInstructorAcademicInfoModel
    {
        public InstructorAcademicInfoModel()
        {
            _instructorPropertyModel = new InstructorPropertyModel();
        }

        public InstructorPropertyModel InstructorPropertyModel
        {
            get => (InstructorPropertyModel)_instructorPropertyModel;
            set => _instructorPropertyModel = value;
        }


        private IInstructorPropertyModel _instructorPropertyModel;
    }
}
