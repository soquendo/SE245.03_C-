using System;
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
            //retrieves from the parent
            InitializeComponent();

            dtpDateRentalExpires.Value = DateTime.Now.AddDays(14);
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
                lblFeedback.Text = $"{temp.Title}, published {temp.DatePublished} by {temp.AuthorFirst} {temp.AuthorLast} costs ${temp.Price}; Rental expires {temp.DateRentalExpires}";
            }

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
    }
}
