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


