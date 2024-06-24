using DomainLayer.Inner.CommonModel.BaseModel;
using System.ComponentModel.DataAnnotations;


namespace DomainLayer.Models.InformationModel.AcademicModel
{ 
    public class CourseInfoModel : SharedCourseInfoModel, ICourseInfoModel
    { 
        [Required(AllowEmptyStrings = false, ErrorMessage = "Course name must not be empty!")]
        public string CourseName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Number of units must not be empty!")]
        [Range(1, 5, ErrorMessage = "Number of units must be between 1 - 5!")]
        public int NumberOfUnits { get; set;}
    }
}
