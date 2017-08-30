﻿using System;
using System.Windows.Forms;

namespace RibbonDemo
{
    public partial class MDIChild2 : Form
   {
      public MDIChild2()
      {
         InitializeComponent();
      }

      protected override void OnLoad(EventArgs e)
      {
         base.OnLoad(e);
         this.ControlBox = false;
         this.WindowState = FormWindowState.Maximized;
         this.BringToFront();
      }
   }
}
