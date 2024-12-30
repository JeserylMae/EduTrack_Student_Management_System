using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DataModels
{
    public class PRProgramModel
    {
        public string ProgramId      { get; set; }
        public string ProgramName    { get; set; }
        public string DepartmentId   { get; set; }
        public string DepartmentName { get; set; }
    }
}
