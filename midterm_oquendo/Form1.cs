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
            txt_feedback.Text = "";
            Customer temp = new Customer();
            
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

            temp.CustomerSince = dtpCustomerSince.Value;
            //temp.TotalPurchases = txt_TotalPurchases.Text; //double
            //temp.DiscountMember = ck_DiscountMember.Value; //bool
            //temp.RewardsEarned = txt_RewardsEarned.Text; //int


            double dblTempTotalPurch;
            if (double.TryParse(txt_TotalPurchases.Text, out dblTempTotalPurch) == true)
            {
                temp.TotalPurchases = dblTempTotalPurch;
            }
            else
            {
                txt_feedback.Text += "ERROR: Please enter dollar value (Ex. 114.99)";
            }


            bool blnResult;
            int intRewardsEarned;
            blnResult = Int32.TryParse(txt_RewardsEarned.Text, out intRewardsEarned);
            if (blnResult == false)
            {
                txt_feedback.Text += "ERROR: Please enter total rewards points (Ex. 132)";
            }
            else
            {
                temp.RewardsEarned = intRewardsEarned;
            }


            if (temp.Feedback.Contains("ERROR:"))
            {
                txt_feedback.Text = temp.Feedback;
            }
            else
            {
                txt_feedback.Text = "First Name: " + temp.fname + "\tMiddle Name: " + temp.mname + "\tLast Name: " + temp.lname + "\nAddress Line #1: " + temp.Street1 + "\tAddress Line #2: " + temp.Street2 + "\tCity: " + temp.City + "\tState: " + temp.State + "\nZip Code: " + temp.Zipcode + "\tPhone Number: " + temp.Phone + "\nCell Phone: " + temp.Cellphone + "\tE-Mail: " + temp.Email + "\nInstagram: " + temp.IG;
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
    }
}
