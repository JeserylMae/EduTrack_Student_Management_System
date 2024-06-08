
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DomainLayer.Models.CommonModel
{
    class PersonalInfoModel : IPersonalInfoModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name must not be empty!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be 2 - 50 characters!")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "First name must not be empty!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be 2 - 50 characters!")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Middle name must not be empty!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Middle name must be 2 - 50 characters!")]
        public string MiddleName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Birth Date is required!")]
        [DataType(DataType.Date, ErrorMessage = "Enter a valid date!")]
        public DateTime BirthDate { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Gender must not be empty!")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Gender must be 4 - 10 characters!")]
        public string Gender { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Home address must not be empty!")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Home address must be 2 - 100 characters!")]
        public string HomeAddress { get; set; }

        [Required(ErrorMessage = "Email address must not be empty!")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Enter an existing email address!")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Contact number must not be empty!")]
        [RegularExpression(@"^\(?([0-9]{9})$", ErrorMessage = "Contact number must contain numbers only!")]
        public string ContactNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Emergency contact name must not be empty!")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Emergency contact name must be 10 - 100 characters!")]
        public string EmergencyContactName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Emergency contact number must not be empty!")]
        [RegularExpression(@"^\(?([0-9]{9})$", ErrorMessage = "Emergency contact number must contain numbers only!")]
        public string EmergencyContactNumber { get; set; }
    }
}
