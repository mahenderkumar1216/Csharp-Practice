﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreationalPatterns.SingletonPattern
{
    public partial class ExceptionHandlerForm1 : Form
    {
        public ExceptionHandlerForm1()
        {
            InitializeComponent();
        }

        private void btnDoSomethingBad_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception("Form 1 did something bad");
            }
            catch(Exception ex)
            {
                ExceptionHandler.Instance.WriteExceptionLog(ex);
            }
        }

        private void btnGoToForm2_Click(object sender, EventArgs e)
        {
            ExceptionHandlerForm2 form2 = new ExceptionHandlerForm2();
            form2.ShowDialog();
        }
    }
}