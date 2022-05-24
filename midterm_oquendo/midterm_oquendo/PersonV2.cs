using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace midterm_oquendo
{
    class PersonV2 : Person
    {
        private string cellphone;
        private string instaURL;

        public PersonV2(): base()
        {
            cellphone = "";
            instaURL = "";
        }

        public string Cellphone
        {
            get
            {
                return cellphone;
            }

            set
            {
                if (ValidationLibrary.IsItFilledPhone(value) == true)
                {
                    cellphone = value;
                }
                else
                {
                    feedback += "\nERROR: Cell number can not be blank, Please enter only digits (Ex. 4019997777)";
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
               
                if (ValidationLibrary.IsItFilledInsta(value) == true)
                {
                    if (ValidationLibrary.IsItValidIG(value) == true)
                    {
                        instaURL = value;
                    }
                    else
                    {
                        feedback += "\nERROR Please enter valid instagram URL";
                    }

                }
                else
                {
                    feedback += "\nERROR: Enter Instagram URL (Ex. instagram.com/username)";
                }
                
            }
        }

        public string AddARecord()
        {
            string strResult = "";
            SqlConnection Conn = new SqlConnection();

            Conn.ConnectionString = @"Server=sql.neit.edu\studentsqlserver,4500;Database=SE133_SOquendo;User ID=SE133_SOquendo;Password=008016420;";

            string strSQL = "INSERT INTO PersonV2 (fname, mname, lname, Street1, Street2, City, State, Zipcode, Phone, Email, Cellphone, IG) VALUES (@fname, @mname, @lname, @Street1, @Street2, @City, @State, @Zipcode, @Phone, @Email, @Cellphone, @IG)";

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

