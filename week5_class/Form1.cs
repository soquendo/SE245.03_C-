﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week5_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblFeedback_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leave me alone");
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            lblFeedback.Text = $"Your Book is: {txtTitle.Text}";
        }
    }
}
