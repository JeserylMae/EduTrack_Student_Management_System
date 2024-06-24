
using System.ComponentModel.DataAnnotations;


namespace DomainLayer.Inner.CommonModel.BaseModel
{
    public class SharedCourseInfoModel : ISharedCourseInfoModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Course code must not be empty!")]
        [StringLength(6, ErrorMessage = "Course code must be 6 charaters only!")]
        public string CourseCode { get; set; }
    }
}
