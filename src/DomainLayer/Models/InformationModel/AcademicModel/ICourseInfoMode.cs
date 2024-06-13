using DomainLayer.Models.CommonModel.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.InformationModel.AcademicModel
{
    public interface ICourseInfoModel : ISharedCourseInfoModel
    {
        string CourseName { get; set; }
        int NumberOfUnits { get; set; }
    }
}
