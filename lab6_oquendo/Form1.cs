using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab6_oquendo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;

            lbl_PersonID.Visible = false;

        }

        public Form1(Int32 intPersonID)
        {
            InitializeComponent();

            btnAddInfo.Enabled = false;
            btnAddInfo.Visible = false;

            PersonV2 temp = new PersonV2();

            SqlDataReader dr = temp.FindOnePerson(intPersonID);

            while (dr.Read())
            {
                txt_fname.Text = dr["fname"].ToString();
                txt_mname.Text = dr["mname"].ToString();
                txt_lname.Text = dr["lname"].ToString();
                txt_street1.Text = dr["Street1"].ToString();
                txt_street2.Text = dr["Street2"].ToString();
                txt_city.Text = dr["City"].ToString();
                txt_state.Text = dr["State"].ToString();
                txt_zipcode.Text = dr["Zipcode"].ToString();
                txt_phone.Text = dr["Phone"].ToString();
                txt_email.Text = dr["Email"].ToString();
                txt_cellphone.Text = dr["Cellphone"].ToString();
                txt_Instagram.Text = dr["IG"].ToString();
                lbl_PersonID.Text = dr["PersonID"].ToString();

            }
        }


        private void submit_button_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
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
            temp.PersonID = Convert.ToInt32(lbl_PersonID.Text);

            if (!temp.Feedback.Contains("ERROR:"))
            {
                txt_feedback.Text = temp.UpdateARecord();
            }
            else
            {
                txt_feedback.Text = temp.Feedback;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 intPersonID = Convert.ToInt32(lbl_PersonID.Text);

            PersonV2 temp = new PersonV2();

            txt_feedback.Text = temp.DeleteOnePerson(intPersonID);
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
            txt_fname.Text = "Jared";
            txt_mname.Text = "A";
            txt_lname.Text = "Doe";
            txt_street1.Text = "10 Main St";
            txt_street2.Text = "Apt 1";
            txt_city.Text = "Providence";
            txt_state.Text = "RI";
            txt_zipcode.Text = "02903";
            txt_phone.Text = "4015559999";
            txt_email.Text = "JDoe@aol.com";
            txt_cellphone.Text = "4012228888";
            txt_Instagram.Text = "instagram.com/JDoe";

        }

        private void btnAddInfo_Click(object sender, EventArgs e)
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
            temp.PersonID = Convert.ToInt32(lbl_PersonID.Text);


            if (txt_feedback.Text.Contains("ERROR:"))
            {
                //Do nothing... already posted error msg on the form
            }
            else if (temp.Feedback.Contains("ERROR:"))
            {
                txt_feedback.Text = temp.Feedback;
            }
            else
            {
                txt_feedback.Text = temp.AddARecord();
                //lblFeedback.Text = $"Name: {temp.Fname} {temp.Mname} {temp.Lname}\nStreet 1: {temp.Street1}\nStreet 2: {temp.Street2}\nCity: {temp.City}\nState: {temp.State}\nZip Code: {temp.Zip}\nPhone #: {temp.Pnum}\nEmail: {temp.Email} \nCell #: {temp.CellPhone} \nInstagram: {temp.IgURL}";
            }

        }



    }
}
