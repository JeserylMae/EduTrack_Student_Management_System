using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DomainLayer.Models.CommonModel.BaseModel;
using DomainLayer.Models.CommonModel.DistinctModel;

namespace DomainLayer.Models.InformationModel.PersonalModel
{
    public interface IStudentPersonalInfoModel : IStudentPropertyModel, IPersonalInfoModel { }

    class StudentPersonalInfoModel : PersonalInfoModel, IStudentPersonalInfoModel
    {
        private StudentPropertyModel _studentModel = new StudentPropertyModel();
        
        public string SrCode {
            get => _studentModel.SrCode; 
            set => _studentModel.SrCode = value;
        }
    }
}


