﻿using System;
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
            Conn.ConnectionString = @"Server=sql.neit.edu\studentsqlserver,4500;Database=SE133_SOquendo;User ID=SE133_SOquendo;Password=008016420;";

            string strSQL = "INSERT INTO EBooks (Title, AuthorFirst, AuthorLast, Email, Pages, DatePublished, DateRentalExpires, Price, BookmarkPage) VALUES (@Title, @AuthorFirst, @AuthorLast, @Email, @Pages, @DatePublished, @DateRentalExpires, @Price, @BookmarkPage)";

            SqlCommand comm = new SqlCommand(); //bark command
            comm.CommandText = strSQL;          //commander knows what to say
            comm.Connection = Conn;             //here's the phone

            //write parameters in same sequence as sql statement
            comm.Parameters.AddWithValue("@Title", Title);
            comm.Parameters.AddWithValue("@AuthorFirst", AuthorFirst);
            comm.Parameters.AddWithValue("@AuthorLast", AuthorLast);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Pages", Pages);
            comm.Parameters.AddWithValue("@DatePublished", DatePublished);
            comm.Parameters.AddWithValue("@DateRentalExpires", DateRentalExpires);
            comm.Parameters.AddWithValue("@Price", Price);
            comm.Parameters.AddWithValue("@BookmarkPage", BookmarkPage);

            try
            {
                Conn.Open();
                int intRecs = comm.ExecuteNonQuery();
                strResult = $"SUCCESS: Inserted {intRecs} records.";
                Conn.Close();

            }
            catch (Exception err) //if we arrive at this point, there was prob connecting to db
            {
                strResult = "ERROR: " + err.Message;
            }
            finally
            {

            }


            return strResult;

        }

        //**************************************************************************************
        //  NEW - Part one of drill-down search (Takes search params to narrow the search results
        //**************************************************************************************
        public DataSet SearchEBooks(String strTitle, String strAuthorLast)
        {
            
            //create dataset to return filled
            DataSet ds = new DataSet();

            //create a command for sql
            SqlCommand comm = new SqlCommand();

            //write SELECT statement to perform search
            String strSQL = "SELECT EBook_ID, Title, AuthorFirst, AuthorLast FROM EBooks WHERE 0=0";

            //if names are filled, include in search
            if (strTitle.Length > 0)
            {
                strSQL += " AND Title LIKE @Title";
                comm.Parameters.AddWithValue("@Title", "%" + strTitle + "%");
            }
            if (strAuthorLast.Length > 0)
            {
                strSQL += " AND AuthorLast LIKE @AuthorLast";
                comm.Parameters.AddWithValue("@AuthorLast", "%" + strAuthorLast + "%");
            }

            //create DB tools
            SqlConnection conn = new SqlConnection();
            string strConn = @GetConnected(); //who, what where of DB
            conn.ConnectionString = strConn;

            //basic info to command object
            comm.Connection = conn;     //tell the commander what connection to use
            comm.CommandText = strSQL;  //tell the command what to say

            //create data adapter
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;    //commander uses data adapter as a translator to speak with datasets

            conn.Open();  //open connection
            da.Fill(ds, "EBooks_Temp"); //fill the dataset with results from database named "EBooks_Temp"
            conn.Close();               //close connection

            return ds;
        }

        //method returns data reader filled with all data from one ebook
        //ebook is specified by ID passed to this function
        public SqlDataReader FindOneEBook(int intEBook_ID)
        {
            //create DB tools needed
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            //connection string to sql server
            string strConn = GetConnected();

            //sql command string to pull up one ebook's data
            string sqlString = "SELECT * FROM EBooks WHERE EBook_ID = @EBook_ID;";

            //tell connection obj the who what where
            conn.ConnectionString = strConn;

            //give the command obj info it needs
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@EBook_ID", intEBook_ID);

            conn.Open(); //open DB connection and YELL the command

            return comm.ExecuteReader();   //return dataset to be used by others

        }

        //new utility function so that one string conrtols all sql server login info
        private string GetConnected()
        {
            return "Server=sql.neit.edu,4500;Database=SE133_SOquendo;User Id=SE133_SOquendo;Password=008016420;";
        }

        public Ebook(): base ()
        {
            BookmarkPage = 0;
            DateRentalExpires = DateTime.Now.AddDays(14);
        }
    }
}
