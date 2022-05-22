using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace lab6_oquendo
{
    class PersonV2 : Person
    {
        private string cellphone;
        private string instaURL;

        public string Cellphone
        {
            get
            {
                return cellphone;
            }

            set
            {
                if (ValidationLibrary.isNotThis(value.Length, 10) == true)
                {
                    Feedback += "\nERROR: Please enter 10 digit number (Ex. 4015559797";
                }
                if (ValidationLibrary.IsItNum(value) == false)
                {
                    Feedback += "\nERROR: Invalid Cell Phone number - Please enter digits.";
                }
                else
                {
                    cellphone = value;
                }
            }
        }

        public string IG
        {
            get
            {
                return instaURL;
            }

            set
            {
                if (ValidationLibrary.IsItValidIG(value) == true)
                {
                    instaURL = value;
                }
                if (ValidationLibrary.IsItFilledInsta(value) == true)
                {
                    instaURL = value;
                }
                else
                {
                    Feedback += "ERROR: Enter Instagram URL (Ex. instagram.com/username";
                }
                
            }
        }

        public PersonV2() : base()
        {
            Cellphone = "";
            IG = "";
        }

        public string AddARecord()
        {
            string strResult = "";
            SqlConnection Conn = new SqlConnection();

            Conn.ConnectionString = @"Server=sql.neit.edu\studentsqlserver,4500;Database=SE133_SOquendo;User ID=SE133_SOquendo;Password=008016420;";

            string strSQL = "INSERT INTO PersonV2 (Fname, Mname, Lname, Street1, Street2, City, State, Zip, Pnum, Email, CellPhone, IgURL) VALUES (@Fname, @Mname, @Lname, @Street1, @Street2, @City, @State, @Zip, @Pnum, @Email, @CellPhone, @IgURL)";

            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = Conn;

            comm.Parameters.AddWithValue("@fname", fname);
            comm.Parameters.AddWithValue("@mname", mname);
            comm.Parameters.AddWithValue("@lname", lname);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@Zipcode", Zipcode);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Cellphone", Cellphone);
            comm.Parameters.AddWithValue("@IG", IG);

            try
            {
                Conn.Open();
                int intRecs = comm.ExecuteNonQuery();
                strResult = $"SUCCESS: Inserted {intRecs} Records";
                Conn.Close();
            }
            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;
            }
            finally
            {

            }

            return strResult;
        }

    }
    
}

