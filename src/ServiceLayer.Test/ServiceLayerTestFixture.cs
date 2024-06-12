using DomainLayer.Models.CommonModel.BaseModel;
using DomainLayer.Models.InformationModel.AcademicModel;
using DomainLayer.Models.InformationModel.PersonalModel;
using ServiceLayer.TestingServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Test
{
    public class ServiceLayerTestFixture
    {
        public ServiceLayerTestFixture() 
        {
            _instructorPersonalInfoModel = new InstructorPersonalInfoModel();
            _studentPersonalInfoModel = new StudentPersonalInfoModel();
            _instructorAcademicInfoModel = new InstructorAcademicInfoModel();
            _studentAcademicInfoModel = new StudentAcademicInfoModel();
            _modelDataAnnotationCheck = new ModelDataAnnotationCheck();
        }


        #region Boiler-plate Code Class Properties.

        public InstructorPersonalInfoModel InstructorPersonalInfoModel
        {
            get => (InstructorPersonalInfoModel)_instructorPersonalInfoModel; 
            set => _instructorPersonalInfoModel = value; 
        }
        public StudentPersonalInfoModel StudentPersonalInfoModel
        {
            get => (StudentPersonalInfoModel)_studentPersonalInfoModel;
            set => _studentPersonalInfoModel = value;
        }
        public InstructorAcademicInfoModel InstructorAcademicInfoModel
        {
            get => (InstructorAcademicInfoModel)_instructorAcademicInfoModel;
            set => _instructorAcademicInfoModel = value;
        }
        public StudentAcademicInfoModel StudentAcademicInfoModel
        {
            get => (StudentAcademicInfoModel)_studentAcademicInfoModel;
            set => _studentAcademicInfoModel = value;
        }
        public ModelDataAnnotationCheck ModelDataAnnotationCheck
        {
            get => (ModelDataAnnotationCheck)_modelDataAnnotationCheck;
            set => _modelDataAnnotationCheck = value;
        }

        #endregion


        private IInstructorPersonalInfoModel _instructorPersonalInfoModel;
        private IStudentPersonalInfoModel _studentPersonalInfoModel;
        private IInstructorAcademicInfoModel _instructorAcademicInfoModel;
        private IStudentAcademicInfoModel _studentAcademicInfoModel;
        private IModelDataAnnotationCheck _modelDataAnnotationCheck;
    }
}
