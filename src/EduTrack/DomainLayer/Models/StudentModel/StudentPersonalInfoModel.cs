
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DomainLayer.Models.CommonModel;

namespace DomainLayer.StudentModel
{
    class StudentPersonalInfoModel : PersonalInfoModel, IStudentPersonalInfoModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Sr Code must not be empty!")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Sr Code must be 8 characters!")]
        [RegularExpression(@"^\(?([0-9]{2})[-. ]?([0-9]{5})$", ErrorMessage = "Sr Code is not valid!")]
        public string SrCode { get; set; }
    }
}
