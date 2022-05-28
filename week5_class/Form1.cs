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

namespace week5_class
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// NEW - Constructor that Receives an EBook ID....this means we need to look up the data and populate fields (View/Edit/Del)
        /// </summary>
        /// <param name="intEBook_ID"></param>
        
        public Form1()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            btnUpdate.Visible = false;
            btnDelete.Enabled = false;
            btnDelete.Visible = false;

        }

        public Form1(int intEBook_ID)
        {
            //retrieves from the parent
            InitializeComponent();

            btnAddBook.Enabled = false;
            btnAddBook.Visible = false;

            Ebook temp = new Ebook();
            SqlDataReader dr = temp.FindOneEBook(intEBook_ID);

            dtpDateRentalExpires.Value = DateTime.Now.AddDays(14);

            //Use that info to fill out the form
            //Loop thru the records stored in the reader 1 record at a time
            // Note that since this is based on one person's ID, then we
            //  should only have one record
            while (dr.Read())
            {
                //Take the Name(s) from the datareader and copy them
                // into the appropriate text fields
                txtTitle.Text = dr["Title"].ToString();
                txtAuthorFirst.Text = dr["AuthorFirst"].ToString();
                txtAuthorLast.Text = dr["AuthorLast"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                txtPages.Text = dr["Pages"].ToString();
                txtBookmark.Text = dr["BookmarkPage"].ToString();
                lblEBook_ID.Text = dr["EBook_ID"].ToString();

                dtpDatePublished.Value = DateTime.Parse(dr["DatePublished"].ToString());
                dtpDateRentalExpires.Value = DateTime.Parse(dr["DateRentalExpires"].ToString());
          
            }
        }

        private void lblFeedback_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leave me alone");
        }

        //blue colors refer to classes
        //object is generic class that has some type of visual interface
        //in this instance, based off what is clicked
        //'sender' becomes copy of the event/click
        //
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            //lblFeedback.Text = $"Your Book is: {txtTitle.Text} by {txtAuthorFirst.Text} {txtAuthorLast.Text}. It costs ${txtPrice.Text}";


            //reset feedback label
            lblFeedback.Text = "";

            //create an empty or blank book
            Ebook temp = new Ebook();

            //fill in the book specs
            temp.Title = txtTitle.Text;
            temp.AuthorFirst = txtAuthorFirst.Text;
            temp.AuthorLast = txtAuthorLast.Text;
            temp.Email = txtEmail.Text;

            temp.DatePublished = dtpDatePublished.Value;
            temp.DateRentalExpires = dtpDateRentalExpires.Value;

            int intTempPages;
            bool blnResult = Int32.TryParse(txtPages.Text, out intTempPages);
            if (blnResult == false)
            {
                lblFeedback.Text += "Incorrect page number, please try again. (Ex. 128) ";
            }
            else
            {
                temp.Pages = intTempPages;
            }


            int intBMPage;
            blnResult = Int32.TryParse(txtBookmark.Text, out intBMPage);

            if (blnResult == false)
            {
                lblFeedback.Text += "Incorrect bookmark page number, please try again. (Ex. 198) ";
            }
            else
            {
                temp.BookmarkPage = intBMPage;
            }

            //temp.Price = txtPrice.Text;
            double tPrice = 0;
            
            if (Double.TryParse(txtPrice.Text, out tPrice) == true)
            {
                temp.Price = tPrice;
            }
            else
            {
                lblFeedback.Text = "ERROR: Price must be numeric. (Ex: 12.99)";
            }


            //check for potential errors, and print them OR print out info
            if (lblFeedback.Text.Contains("ERROR:"))
            {
                //Do nothing, already posted error msg on form
            }
            else if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                lblFeedback.Text = temp.AddARecord();
               //lblFeedback.Text = $"{temp.Title}, published {temp.DatePublished} by {temp.AuthorFirst} {temp.AuthorLast} costs ${temp.Price}; Rental expires {temp.DateRentalExpires}";
            }

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            

        }




        /// <summary>
        /// Form code to create an oject and call it's update method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sample_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "Star Wars";
            txtAuthorFirst.Text = "George";
            txtAuthorLast.Text = "Lucas";
            txtPrice.Text = "5.99";
            txtEmail.Text = "GLucas@lucasfilm.com";
            txtPages.Text = "300";
            txtBookmark.Text = "61";
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblReturn_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Ebook temp = new Ebook();

            //Getting the strings from the form and setting them in object
            temp.Title = txtTitle.Text;
            temp.AuthorFirst = txtAuthorFirst.Text;
            temp.AuthorLast = txtAuthorLast.Text;
            temp.Email = txtEmail.Text;
            temp.EBook_ID = Convert.ToInt32(lblEBook_ID.Text);


            //Getting te dates from the datetime pickers
            temp.DatePublished = dtpDatePublished.Value;
            temp.DateRentalExpires = dtpDateRentalExpires.Value;

            //**************************************************************************
            //get the string from page # textboxes,convert to ints, set their values
            //**************************************************************************
            int intTempPages;
            bool blnResult = Int32.TryParse(Console.ReadLine(), out intTempPages);

            if (blnResult == false)
            {
                lblFeedback.Text += "Sorry incorrect page #.  Please try again. (Ex: 214) ";
            }
            else
            {
                temp.Pages = intTempPages;
            }
            //**************************************************************************


            //**************************************************************************
            //get the string from Bookmark page # textboxes,convert to ints, set their values
            //**************************************************************************
            int intBMPage;
            blnResult = Int32.TryParse(Console.ReadLine(), out intBMPage);

            if (blnResult == false)
            {
                lblFeedback.Text += "Sorry incorrect Bookmark page #.  Please try again. (Ex: 214) ";
            }
            else
            {
                temp.BookmarkPage = intBMPage;
            }
            //**************************************************************************


            if (!temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.UpdateARecord();   //if no errors weh setting values, then perform the insertion into db
            }
            else
            {
                lblFeedback.Text = temp.Feedback;       //else...dispay the error msg
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Int32 intEBook_ID = Convert.ToInt32(lblEBook_ID.Text);  //Get the ID from the Label

            //Create a EBook so we can use the delete method
            Ebook temp = new Ebook();

            //Use the EBook ID and pass it to the delete function
            // and get the number of records deleted
            lblFeedback.Text = temp.DeleteOneEBook(intEBook_ID);
        }
    }
}
