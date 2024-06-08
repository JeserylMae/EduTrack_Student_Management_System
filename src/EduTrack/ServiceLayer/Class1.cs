using DomainLayer.Models.CommonModel;
using DomainLayer.Models.InstructorModel;
using DomainLayer.StudentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
;

namespace ServiceLayer
{
    public class Class1
    {
        public void nmnm(IStudentPersonalInfoModel studentPersonalInfo)
        {
            studentPersonalInfo.SrCode = "22-23892";
            studentPersonalInfo.BirthDate = DateTime.Now;
        }
    }
}
