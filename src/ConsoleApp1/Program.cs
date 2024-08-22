
using DomainLayer.DataModels;
using ServiceLayer.Database;
using System;
using System.Net.Http;


namespace ServiceLayer
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            StudentPersonalInfoModel student = new StudentPersonalInfoModel();
            StudentPersonalInfoServices services = new StudentPersonalInfoServices();
            PersonalInfoModel<StudentPersonalInfoModel> personalInfoModel = new PersonalInfoModel<StudentPersonalInfoModel>();

            student.SrCode = "11-111-1114";
            student.LastName = "Riego";
            student.FirstName = "Percival";
            student.MiddleName = "Vesarius";
            student.BirthDate = "2002-2-23";
            student.Gender = "MALE";
            student.ContactNumber = "094358";
            student.EmailAddress = "sibal@gmail.com";
            student.ZipCode = "0999";
            student.Barangay = "Padre Castillo";
            student.Municipality = "San Pascual";
            student.Province = "Batangas";
            student.GuardianLastName = "Riego";
            student.GuardianFirstName = "Achilles";
            student.GuardianMiddleName = "Vesarius";
            student.GuardianContactNumber = "04934";
            student.GuardianZipCode = "0999";
            student.GuardianBarangay = "Padre Castillo";
            student.GuardianMunicipality = "San Pascual";
            student.GuardianProvince = "Batangas";

            personalInfoModel.InfoModel = student;
            personalInfoModel.GuardianCode = student.SrCode + "-GUA";
            personalInfoModel.StudentCode = student.SrCode + "-STU";
            personalInfoModel.DefaultPassword = "sibal";
            personalInfoModel.Position = "STUDENT";

            try
            {
                var response = await services.InsertNew(personalInfoModel);
                Console.WriteLine(response);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
