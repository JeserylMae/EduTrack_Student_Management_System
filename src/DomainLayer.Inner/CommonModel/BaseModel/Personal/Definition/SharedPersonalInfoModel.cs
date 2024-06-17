
using System.ComponentModel.DataAnnotations;


namespace DomainLayer.Inner.CommonModel.BaseModel
{
    public class SharedPersonalInfoModel : ISharedPersonalInfoModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name must not be empty!")]
        [RegularExpression(@"^[a-zA-Z ]{2,30}$", ErrorMessage = "Last name must be 2 - 30 characters!")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "First name must not be empty!")]
        [RegularExpression(@"^[a-zA-Z ]{2,30}$", ErrorMessage = "First name must be 2 - 30 characters!")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Middle name must not be empty!")]
        [RegularExpression(@"^[a-zA-Z ]{2,30}$", ErrorMessage = "Middle name must be 2 - 30 characters!")]
        public string MiddleName { get; set; }
    }
}
