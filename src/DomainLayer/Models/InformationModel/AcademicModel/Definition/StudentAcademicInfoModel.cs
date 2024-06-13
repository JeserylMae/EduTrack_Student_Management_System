
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
            _studentPropertyModel = new StudentPropertyModel();
        }

        public StudentPropertyModel StudentPropertyModel
        {
            get => (StudentPropertyModel)_studentPropertyModel;
            set => _studentPropertyModel = value;
        }


        private IStudentPropertyModel _studentPropertyModel;
    }
}
