using DomainLayer.Models.CommonModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.InformationModel.AcademicModel
{
    public interface ICourseInfoModel : ISharedCourseInfoModel
    {
        string CourseName { get; set; }
        int NumberOfUnits { get; set; }
    }

    class CourseInfoModel : SharedCourseInfoModel, ICourseInfoModel
    { 
        [Required(AllowEmptyStrings = false, ErrorMessage = "Course name must not be empty!")]
        public string CourseName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Number of units must not be empty!")]
        [Range(1, 5, ErrorMessage = "Number of units must be between 1 - 5!")]
        public int NumberOfUnits { get; set;}
    }
}
