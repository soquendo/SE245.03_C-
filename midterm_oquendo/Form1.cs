using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midterm_oquendo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            Person temp = new Person();
            temp.fname = txt_fname.Text;
            temp.mname = txt_mname.Text;
            temp.lname = txt_lname.Text;
            temp.Street1 = txt_street1.Text;
            temp.Street2 = txt_street2.Text;
            temp.City = txt_city.Text;
            temp.State = txt_state.Text;
            temp.Zipcode = txt_zipcode.Text;
            temp.Phone = txt_phone.Text;
            temp.Email = txt_email.Text;

            lbl_feedback.Text = "First Name: " + txt_fname.Text + "\nMiddle Name: " + txt_mname.Text + "\nLast Name: " + txt_lname.Text + "\nAddress Line #1: " + txt_street1.Text + "\nAddress Line #2: " + txt_street2.Text + "\nCity: " + txt_city.Text + "\nState: " + txt_state.Text + "\nZip Code: " + txt_zipcode.Text + "\nPhone Number: " + txt_phone.Text + "\nE-Mail: " + txt_email.Text;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
