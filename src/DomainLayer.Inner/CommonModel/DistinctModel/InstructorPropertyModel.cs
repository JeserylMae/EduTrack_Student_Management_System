
using System.ComponentModel.DataAnnotations;


namespace DomainLayer.Inner.CommonModel.DistinctModel
{
    public class InstructorPropertyModel : IInstructorPropertyModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Instructor ID must not be empty!")]
        [RegularExpression(@"^[\d]{2}-[\d]{2}-[\d]{5}$", ErrorMessage = "Instructor ID is not valid!")]
        public string InstructorID { get; set; }
    }
}
