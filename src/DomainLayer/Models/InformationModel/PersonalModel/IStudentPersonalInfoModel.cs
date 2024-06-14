using DomainLayer.Models.CommonModel.BaseModel;
using DomainLayer.Models.CommonModel.DistinctModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.InformationModel.PersonalModel
{
    public interface IStudentPersonalInfoModel : IPersonalInfoModel
    {
        StudentPropertyModel StudentPropertyModel { get; set; }
    }
}
