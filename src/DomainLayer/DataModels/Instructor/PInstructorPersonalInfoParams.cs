using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DataModels.Instructor
{
    public class PInstructorPersonalInfoParams
    {
        public string ItrCode               { get; set; }
        public string UserNameCode          { get; set; }
        public string UserAddressCode       { get; set; }
        public string GuardianNameCode      { get; set; }
        public string GuardianAddressCode   { get; set; }
    }
}
