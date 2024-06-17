
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Inner.CommonModel.DistinctModel
{
    public class StudentPropertyModel : IStudentPropertyModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Sr Code must not be empty!")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Sr Code must be 8 characters!")]
        [RegularExpression(@"^\d{2}-\d{5}$", ErrorMessage = "Sr Code is not valid!")]
        public string SrCode { get; set; }
    }
}
