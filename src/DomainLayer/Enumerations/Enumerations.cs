using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Presenters.Enumerations
{
    public enum FormRequestType
    {
        ADD, UPDATE
    }

    public enum StudentAcadParams
    {
        None,
        SrCode,
        SrCodeAndAcadYear,
        SrCodeAndAcadYearAndYearLevel,
        SrCodeAndAcadYearAndYearLevelAndSemester
    }
}
