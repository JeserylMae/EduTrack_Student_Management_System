using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Presenters.Enumerations
{
    public enum RequestStatus
    {
        SUCCESS, ERROR
    }

    public enum FormRequestType
    {
        ADD, UPDATE, DELETE, CANCEL
    }

    public enum StudentAcadParams
    {
        None,
        SrCode,
        SrCodeAndAcadYear,
        SrCodeAndAcadYearAndYearLevel,
        SrCodeAndAcadYearAndYearLevelAndSemester
    }

    public enum InstructorAcadParams
    {
        None,
        ItrCode,
        ItrCodeAndAcademicYear,
        ItrCodeAndAcademicYearAndYearLevel,
        ItrCodeAndAcademicYearAndYearLevelAndSection,
        ItrCodeAndAcademicYearAndYearLevelAndSectionAndCourse
    }

    public enum RequestType
    {
        INSERT,
        UPDATE,
        DELETE,
        GETALL,
        GETBYPARAMS
    }

    public enum FilterFrom
    {
        AcademicYear,
        YearLevel,
        Semester,
        Section,
        Program,
        None
    }

    public enum AccessType
    {
        ADMIN,
        INSTRUCTOR, 
        STUDENT
    }
}
