﻿using DomainLayer.DataModels;
using FontAwesome.Sharp;
using PresentationLayer.Presenters.Enumerations;
using PresentationLayer.UserControls.MainControls;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls.AdminSubControls
{
    public interface IAcademicInfoControl
    {
        void DisposeControl();

        event EventHandler ControlLoad;
        event EventHandler CloseButtonClicked;
        event EventHandler SubmitAddButtonClicked;
        event EventHandler CancelSubmitButtonClicked;
        event EventHandler SubmitUpdateButtonClicked;


        UserControl CurrentControl          { get; }
        TextBox AccessCourseTextBox         { get; }
        TextBox AccessUsrCodeTextBox        { get; }
        TextBox AccessSectionTextBox        { get; }
        TextBox AccessLastNameTextBox       { get; }
        TextBox AccessFirstNameTextBox      { get; }
        TextBox AccessMiddleNameTextBox     { get; }
        Panel AccessCoursePanel             { get; }
        Label AccessPageLabel               { get; }
        Label AccessUsrCodeLabel            { get; }
        Label AccessFullNameLabel           { get; }
        ComboBox AccessYearComboBox         { get; }
        ComboBox AccessProgramComboBox      { get; }
        ComboBox AccessSemesterComboBox     { get; }
        ComboBox AccessAcademicYearComboBox { get; }
        IconButton AccessSubmitAddButton    { get; }
        IconButton AccessSubmitUpdateButton { get; }


        AccessType ModifyUser                   { get; set; }
        DataGridView AccessInfoTable            { get; set; }
        FormRequestType CurrentRequestType      { get; set; }
        IModifyAcadInfoControl StudentControl   { get; set; }
    }
}
