
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Inner.CommonModel.BaseModel
{
    public class AcademicInfoModel : SharedAcademicInfoModel, IAcademicInfoModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Year must not be empty!")]
        public string Year{ get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Program must not be empty!")]
        public string Program { get; set; }
    }
}
