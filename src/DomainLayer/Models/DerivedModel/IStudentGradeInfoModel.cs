using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.DerivedModel
{
    public interface IStudentGradeInfoModel : IStudentSharedInfoModel
    {
        decimal Grade { get; set; }
    }
}
