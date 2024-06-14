using DomainLayer.Models.CommonModel.BaseModel;
using DomainLayer.Models.CommonModel.DistinctModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.InformationModel.AcademicModel
{
    public interface IStudentAcademicInfoModel : IAcademicInfoModel
    {
        StudentPropertyModel StudentPropertyModel { get; set; }
    }
}
