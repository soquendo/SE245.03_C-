using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace week5_class
{
    class Ebook: Book
    {
        private DateTime dateRentalExpires;
        private int bookmarkPage;

        public DateTime DateRentalExpires
        {
            get
            {
                return dateRentalExpires;
            }

            set
            {
                if (ValidationLibrary.IsAFutureDate(value))
                {
                    dateRentalExpires = value;
                }
                else
                {
                    feedback += "\nERROR: Please enter a future date";
                }

            }
        }

        public int BookmarkPage
        {
            get
            {
                return bookmarkPage;
            }

            set
            {
                if (value >= 0 && value <= Pages)
                {
                    bookmarkPage = value;
                }
                else
                {
                    feedback += "\nERROR: You entered an invalid bookmark page number.";
                }
            }
        }

        public string AddARecord()
        {
            string strResult = ""; //init string

            SqlConnection Conn = new SqlConnection(); //make connection obj


            //init properties
            Conn.ConnectionString = @"Server=sql.neit.edu\studentsqlserver,4500;Database=SE133_SOquendo;UserId=SE133_SOquendo;Password=008016420;";

            string strSQL = "INSERT INTO EBooks (Title, AuthorFirst, AuthorLast, Email, Pages, DatePublished, DateRentalExpires, BookmarkPage) VALUES(@Title, @AuthorFirst, @AuthorLast, @Email, @Pages, @DatePublished, @DateRentalExpires, @BookmarkPage)";

            SqlCommand comm = new SqlCommand(); //bark command
            comm.CommandText = strSQL;          //commander knows what to say
            comm.Connection = Conn;             //here's the phone

            //write parameterse in same sequence as sql statement
            comm.Parameters.AddWithValue("@Title", Title);
            comm.Parameters.AddWithValue("@AuthorFirst", AuthorFirst);
            comm.Parameters.AddWithValue("@AuthorLast", AuthorLast);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Pages", Pages);
            comm.Parameters.AddWithValue("@DatePublished", DatePublished);
            comm.Parameters.AddWithValue("@DateRentalExpires", DateRentalExpires);
            comm.Parameters.AddWithValue("@BookmarkPage", BookmarkPage);

            try
            {
                Conn.Open();



            }




        }





        public Ebook(): base ()
        {
            BookmarkPage = 0;
            DateRentalExpires = DateTime.Now.AddDays(14);
        }

    }
}
