using DomainLayer.Models.CommonModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Instructors
{
    class InstructorPersonalInfoModel : PersonalInfoModel, IInstructorPersonalInfoModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Instructor ID must not be empty!")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Instructor ID must be 10 characters!")]
        [RegularExpression(@"^\(?([0-9]{2})[-. ]?([0-9]{5})$", ErrorMessage = "Instructor ID is not valid!")]
        public string SrCode { get; set; }
    }
}
