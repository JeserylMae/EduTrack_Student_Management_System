using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DataModels.Instructor
{
    public class PInstructorPersonalInfoModel<TModel>
    {
        public TModel InfoModel         { get; set; }
        public string DefaultPassword   { get; set; }
        public string Position          { get; set; }
        public string UserId            { get; set; }
        public string GuardianCode      { get; set; }
    }
}
