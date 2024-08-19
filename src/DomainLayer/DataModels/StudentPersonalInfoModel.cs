

using System;


namespace DomainLayer.DataModels
{
    public class StudentPersonalInfoModel
    {
        public string SrCode                  { get; set; }
        public string LastName                { get; set; }
        public string FirstName               { get; set; }
        public string MiddleName              { get; set; }
        public DateTime BirthDate             { get; set; }
        public string Gender                  { get; set; }
        public string ZipCode                 { get; set; }
        public string Barangay                { get; set; }
        public string Municipality            { get; set; }
        public string Province                { get; set; }
        public string ContactNumber           { get; set; }
        public string GuardianLastName        { get; set; }
        public string GuardinFirstName        { get; set; }
        public string GuardianMiddleName      { get; set; }
        public DateTime GuardianContactNumber { get; set; }
        public string GuardianZipCode         { get; set; }
        public string GuardianBarangay        { get; set; }
        public string GuardianMunicipality    { get; set; }
        public string GuardianProvince        { get; set; }
    }
}
