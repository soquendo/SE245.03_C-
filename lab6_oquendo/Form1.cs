using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6_oquendo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            txt_feedback.Text = "";
            PersonV2 temp = new PersonV2();
            
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

            temp.Cellphone = txt_cellphone.Text;
            temp.IG = txt_Instagram.Text;

            if (temp.Feedback.Contains("ERROR:"))
            {
                txt_feedback.Text = temp.Feedback;
            }
            else
            {
                txt_feedback.Text = "\nFirst Name: " + temp.fname + "\nMiddle Name: " + temp.mname + "\nLast Name: " + temp.lname + "\nAddress Line #1: " + temp.Street1 + "\nAddress Line #2: " + temp.Street2 + "\nCity: " + temp.City + "\nState: " + temp.State + "\nZip Code: " + temp.Zipcode + "\nPhone Number: " + temp.Phone + "\nCell Phone: " + temp.Cellphone + "\nE-Mail: " + temp.Email + "\nInstagram: " + temp.IG;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sample_Click(object sender, EventArgs e)
        {
            txt_fname.Text = "John";
            txt_mname.Text = "A";
            txt_lname.Text = "Doe";
            txt_street1.Text = "10 Main St";
            txt_street2.Text = "Apt 1";
            txt_city.Text = "Providence";
            txt_state.Text = "RI";
            txt_zipcode.Text = "02903";
            txt_phone.Text = "4015559999";
            txt_email.Text = "JohnDoe@aol.com";
            txt_cellphone.Text = "4012228888";
            txt_Instagram.Text = "instagram.com/JohnDoe";
           
        }
    }
}
