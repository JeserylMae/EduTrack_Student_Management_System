using PresentationLayer.Presenters.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.HomeSubControls
{
    internal interface IStudItrHomeRightControl
    {
        void DestroyControl();
        event EventHandler OnControlLoad;


        string CurrentUserId        { get; set; }
        AccessType CurrentUserType { get; set; }

        Label AccessYearText                { get; }
        Label AccessSrCodeText              { get; }
        Label AccessSemesterText            { get; }
        Label AccessSectionText             { get; }
        Label AccessProgramText             { get; }
        Label AccessStudEmailText           { get; }
        Label AccessStudContactNumberText   { get; }

        Label AccessGenderText              { get; }
        Label AccessItrCodeText             { get; }
        Label AccessAddressText             { get; }
        Label AccessItrEmailText            { get; }
        Label AccessBirthDateText           { get; }
        Label AccessItrContactNumberText    { get; }

        FlowLayoutPanel AccessStudentInfoMainPanel      { get; }
        FlowLayoutPanel AccessInstructorInfoMainPanel   { get; }
    }
}
