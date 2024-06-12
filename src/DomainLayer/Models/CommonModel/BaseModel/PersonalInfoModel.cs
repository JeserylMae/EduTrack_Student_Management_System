﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;


namespace DomainLayer.Models.CommonModel.BaseModel
{
    public class PersonalInfoModel : IPersonalInfoModel
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

        [Required(AllowEmptyStrings = false, ErrorMessage = "Birth Date is required!")]
        [DataType(DataType.Date, ErrorMessage = "Enter a valid date!")]
        public DateTime? BirthDate { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Gender must not be empty!")]
        [RegularExpression(@"^[a-zA-Z]{4,10}$", ErrorMessage = "Gender must be 4 - 10 characters!")]
        public string Gender { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Home address must not be empty!")]
        [RegularExpression(@"^[a-zA-Z0-9,-. ]{10,100}$", ErrorMessage = "Home address must be 2 - 100 characters!")]
        public string HomeAddress { get; set; }

        [Required(ErrorMessage = "Email address must not be empty!")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^\w+[\w-]*@\w{3,15}\.\w{2,5}$", ErrorMessage = "Enter an existing email address!")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Contact number must not be empty!")]
        [RegularExpression(@"^[\d]{11}$", ErrorMessage = "Contact number must contain numbers only!")]
        public string ContactNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Emergency contact name must not be empty!")]
        [RegularExpression(@"^[a-zA-z., ]{10,100}$", ErrorMessage = "Emergency contact name must be 10 - 100 characters!")]
        public string EmergencyContactName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Emergency contact number must not be empty!")]
        [RegularExpression(@"^[\d]{11}$", ErrorMessage = "Emergency contact number must contain numbers only with 11 digis!")]
        public string EmergencyContactNumber { get; set; }
    }
}


///
/// <summary>
///  Here's a quick breakdown of common shorthand character classes in regular expressions:
/// \d: Matches any digit(equivalent to[0 - 9]).
/// \D: Matches any non - digit(equivalent to[^0 - 9]).
/// \w: Matches any word character(equivalent to [a-zA-Z0-9_]).
/// \W: Matches any non - word character(equivalent to[^a - zA - Z0 - 9_]).
/// \s: Matches any whitespace character(space, tab, newline, etc.).
/// \S: Matches any non - whitespace character.
/// </summary>
///