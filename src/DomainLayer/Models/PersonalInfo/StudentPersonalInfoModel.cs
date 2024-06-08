using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DomainLayer.Models.CommonModel;

namespace DomainLayer.Models.PersonalInfo
{
    public interface IStudentPersonalInfoModel : IStudentModel, IPersonalInfoModel { }

    class StudentPersonalInfoModel : IStudentPersonalInfoModel
    {
        private StudentModel _studentModel = new StudentModel();
        private PersonalInfoModel _personalInfoModel = new PersonalInfoModel();

        public string SrCode
        {
            get => _studentModel.SrCode; 
            set => _studentModel.SrCode = value;
        }
        public DateTime BirthDate 
        { 
            get => _personalInfoModel.BirthDate; 
            set => _personalInfoModel.BirthDate = value; 
        }
        public string ContactNumber 
        { 
            get => _personalInfoModel.ContactNumber; 
            set => _personalInfoModel.ContactNumber= value; }
        public string Email 
        { 
            get => _personalInfoModel.Email;
            set => _personalInfoModel.Email = value;
        }
        public string EmergencyContactName 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); }
        public string EmergencyContactNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Gender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string HomeAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MiddleName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}


