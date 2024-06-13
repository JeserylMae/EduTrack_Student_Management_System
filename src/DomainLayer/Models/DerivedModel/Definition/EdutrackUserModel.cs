
using DomainLayer.Models.CommonModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DomainLayer.Models.DerivedModel
{
    public class EdutrackUserModel : IEdutrackUserModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "User ID must not be empty!")]
        [StringLength(10, MinimumLength = 8, ErrorMessage = "User ID must have 8 - 10 characters!")]
        public string UserID { get; set;}

        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password must not be empty!")]
        public string AccountPassword { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email address must not be empty!")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^\w+[\w-]*@\w{3,15}\.\w{2,5}$", ErrorMessage = "Enter an existing email address!")]
        public string Email { get; set; }
    }
}
