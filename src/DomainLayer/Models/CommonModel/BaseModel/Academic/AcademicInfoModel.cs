
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.CommonModel.BaseModel
{
    public class AcademicInfoModel : SharedAcademicInfoModel, IAcademicInfoModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Year must not be empty!")]
        public string Year{ get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Program must not be empty!")]
        public string Program { get; set; }
    }
}
