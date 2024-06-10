
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.CommonModel.BaseModel;
using DomainLayer.Models.CommonModel.DistinctModel;


namespace DomainLayer.Models.InformationModel.AcademicModel
{
    public interface IStudentAcademicInfoModel : IAcademicInfoModel, IStudentPropertyModel 
    { 
    
    }

    class StudentAcademicInfoModel : AcademicInfoModel, IStudentAcademicInfoModel
    {
        public StudentAcademicInfoModel()
        {
            _studentModel = new StudentPropertyModel();
        }

        public string SrCode
        {
            get => _studentModel.SrCode;
            set => _studentModel.SrCode = value;
        }


        private IStudentPropertyModel _studentModel;
    }
}
