using System;
using DomainLayer.Models.CommonModels;

namespace DomainLayer.Student
{
    interface IStudentPersonalInfoModel : IPersonalInfoModel
    {
        string SrCode { get; set; }
    }
}