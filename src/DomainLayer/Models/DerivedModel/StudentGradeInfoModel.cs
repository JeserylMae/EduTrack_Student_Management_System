using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.DerivedModel;

namespace DomainLayer.Models.DerivedModel
{
    public interface IStudentGradeInfoModel : IStudentSharedInfoModel
    {
        decimal Grade {  get; set; }
    }

    class StudentGradeInfoModel : StudentSharedInfoModel, IStudentGradeInfoModel
    {
        [Required]
        [Range(1.00, 5.00, ErrorMessage = "Grade must be from 1.00 to 5.00 only!")]
        public decimal Grade { get; set; }

    }
}
