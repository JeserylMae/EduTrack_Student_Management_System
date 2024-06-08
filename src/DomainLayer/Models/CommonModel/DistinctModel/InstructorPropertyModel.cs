using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.CommonModel.DistinctModel
{
    public interface IInstructorPropertyModel
    {
        string InstructorID { get; set; }
        string SpecializedDegree { get; set; }
    }

    class InstructorPropertyModel : IInstructorPropertyModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Intructor ID must not be empty!")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Instructor ID must be 10 characters!")]
        [RegularExpression(@"^\(?([0-9]{2})[-. ]?([0-9]{5})$", ErrorMessage = "Instructor ID is not valid!")]
        public string InstructorID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Specialized degree must not be empty!")]
        [StringLength(100, MinimumLength = 20, ErrorMessage = "Specialized degree must be at least 20 charaters!")]
        public string SpecializedDegree { get; set; }
    }
}
