using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.CommonModel.BaseModel
{
    public class SharedAcademicInfoModel : ISharedAcademicInfoModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Section must not be empty!")]
        public string Section { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Semester must not be empty!")]
        public string Semester { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Academic year must not be empty!")]
        public string AcademicYear { get; set; }
    }
}
