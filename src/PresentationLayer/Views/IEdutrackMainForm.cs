﻿
using System;
using System.Windows.Forms;
using System.Drawing;

namespace PresentationLayer.Views
{ 
    public interface IEdutrackMainForm
    {
        int TopPosition                     { get; set; }
        int LeftPosition                    { get; set; }
        int FormWidth                       { get; set; }
        int FormHeight                      { get; set; }
        bool IsAppMaximized                 { get; set; }
        string ConnectionString             { get; set; }
        bool EnableMaximizeAppButton        { get; set; }
        Point WindowLocation                { get; set; }
        UserControl UserControlPage         { get; set; }
        FormWindowState FormWindowState     { get; set; }
        FormStartPosition FormStartPosition { get; set; }

        event EventHandler WindowExit;
        event EventHandler WindowMaximized;
        event EventHandler WindowMinimized;
        event MouseEventHandler MouseMoved;
        event MouseEventHandler MousePressed;

        void SetWindowToMaximized();
    }
}
