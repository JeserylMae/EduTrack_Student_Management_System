
using DomainLayer.Models.CommonModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DomainLayer.Models.DerivedModel
{
    public interface IEdutrackUserModel
    {
        string UserID { get; set; }
        string AccountPassword { get; set; }
    }

    class EdutrackUserModel : IEdutrackUserModel
    {
        private IPersonalInfoModel _personalModel = new PersonalInfoModel();

        public string Email
        {
            get => _personalModel.Email;
            set => _personalModel.Email = value; 
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "User ID must not be empty!")]
        [StringLength(10, MinimumLength = 8, ErrorMessage = "User ID must have 8 - 10 characters!")]
        public string UserID { get; set;}

        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password must not be empty!")]
        public string AccountPassword { get; set; }
    }
}
