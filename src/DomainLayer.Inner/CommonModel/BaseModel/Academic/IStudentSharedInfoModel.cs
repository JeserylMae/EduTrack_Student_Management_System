using DomainLayer.Inner.CommonModel.BaseModel;
using DomainLayer.Inner.CommonModel.DistinctModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Inner.CommonModel.BaseModel
{
    public interface IStudentSharedInfoModel
    {
        StudentPropertyModel StudentPropertyModel { get; set; }
        SharedCourseInfoModel SharedCourseInfoModel { get; set; }
        SharedAcademicInfoModel SharedAcademicInfoModel { get; set; }
    }
}
