

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.CommonModel.BaseModel;
using DomainLayer.Models.CommonModel.DistinctModel;


namespace DomainLayer.Models.InformationModel.AcademicModel
{
    public class InstructorAcademicInfoModel : AcademicInfoModel, IInstructorAcademicInfoModel
    {
        public InstructorAcademicInfoModel()
        {
            InstructorPropertyModel = new InstructorPropertyModel();
            SharedCourseInfoModel = new SharedCourseInfoModel();
        }

        public InstructorPropertyModel InstructorPropertyModel
        {
            get => InstructorPropertyModel;
            set => InstructorPropertyModel = value;
        }
        public SharedCourseInfoModel SharedCourseInfoModel
        {
            get => SharedCourseInfoModel;
            set=> SharedCourseInfoModel = value;
        }
    }
}
