using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.CommonModel.BaseModel
{
    public class SharedCourseInfoModel : ISharedCourseInfoModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Course code must not be empty!")]
        [StringLength(6, ErrorMessage = "Course code must be 6 charaters only!")]
        public string CourseCode { get; set; }
    }
}
