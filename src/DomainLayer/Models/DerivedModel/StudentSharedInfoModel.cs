using DomainLayer.Models.CommonModel.DistinctModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.InformationModel.AcademicModel;
using DomainLayer.Models.CommonModel.BaseModel;
using System.Runtime.InteropServices;
using System.Reflection;

namespace DomainLayer.Models.DerivedModel
{
    public interface IStudentSharedInfoModel 
    {
        string Name { get; }    
    
    }

    public class StudentSharedInfoModel : IStudentSharedInfoModel
    {
        public string Name { get; }
    }
}
