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

            if (temp.Feedback.Contains("ERROR:"))
            {
                txt_feedback.Text = temp.Feedback;
            }
            else
            {
                txt_feedback.Text = "First Name: " + temp.fname + "\nMiddle Name: " + temp.mname + "\nLast Name: " + temp.lname + "\nAddress Line #1: " + temp.Street1 + "\nAddress Line #2: " + temp.Street2 + "\nCity: " + temp.City + "\nState: " + temp.State + "\nZip Code: " + temp.Zipcode + "\nPhone Number: " + temp.Phone + "\nE-Mail: " + temp.Email;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
