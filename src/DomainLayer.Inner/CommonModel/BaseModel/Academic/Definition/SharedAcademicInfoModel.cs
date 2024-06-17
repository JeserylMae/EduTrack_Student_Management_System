
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Inner.CommonModel.BaseModel
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
