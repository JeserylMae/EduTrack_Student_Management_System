using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.InformationModel.AcademicModel
{
    public interface ICourseInfoModel
    {
        string CourseCode { get; set; }
        string CourseName { get; set; }
        int NumberOfUnits { get; set; }
    }

    class CourseInfoModel : ICourseInfoModel
    {
        [Required]
        [StringLength(6, ErrorMessage = "Course code must be 6 charaters only!")]
        public string CourseCode { get; set; }

        [Required]
        public string CourseName { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "Number of units must be between 1 - 5!")]
        public int NumberOfUnits { get; set;}
    }
}
