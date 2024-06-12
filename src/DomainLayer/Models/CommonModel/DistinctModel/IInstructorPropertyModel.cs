using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.CommonModel.DistinctModel
{
    public interface IInstructorPropertyModel
    {
        string InstructorID { get; set; }
        string SpecializedDegree { get; set; }
    }
}
