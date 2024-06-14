
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.CommonModel.BaseModel;
using DomainLayer.Models.CommonModel.DistinctModel;


namespace DomainLayer.Models.InformationModel.AcademicModel
{
    public class StudentAcademicInfoModel : AcademicInfoModel, IStudentAcademicInfoModel
    {
        public StudentAcademicInfoModel()
        {
            StudentPropertyModel = new StudentPropertyModel();
        }

        public StudentPropertyModel StudentPropertyModel
        {
            get => StudentPropertyModel;
            set => StudentPropertyModel = value;
        }
    }
}
