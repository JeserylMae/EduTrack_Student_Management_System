using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DataModels
{
    public class PStudentPersonalInfoParams
    {
        public string SrCode              { get; set; }
        public string StudentNameCode     { get; set; }
        public string StudentAddressCode  { get; set; }
        public string GuardianNameCode    { get; set; }
        public string GuardianAddressCode { get; set; }
    }
}
