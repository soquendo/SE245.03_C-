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
        private int personID;

        public PersonV2() : base()
        {
            cellphone = "";
            instaURL = "";
        }

        public int PersonID
        {
            get { return personID; }
            set
            {
                if (value >= 0)
                {
                    personID = value;
                }
                else
                {
                    feedback += "\nERROR: Sorry you entered an invalid Person ID.";
                }
            }
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

            string strConn = GetConnected();
            Conn.ConnectionString = strConn;

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

        public DataSet PeopleSearch(String strFname, String strLname, String strState)
        {
            DataSet ds = new DataSet();

            SqlCommand comm = new SqlCommand();

            String strSQL = "SELECT PersonID, fname, lname, State FROM PersonV2 WHERE 0=0";

            if (strFname.Length > 0)
            {
                strSQL += " AND fname LIKE @fname";
                comm.Parameters.AddWithValue("@fname", "%" + strFname + "%");
            }
            if (strLname.Length > 0)
            {
                strSQL += " AND lname LIKE @lname";
                comm.Parameters.AddWithValue("@lname", "%" + strLname + "%");
            }
            if (strState.Length > 0)
            {
                strSQL += " AND State LIKE @State";
                comm.Parameters.AddWithValue("@State", "%" + strState + "%");
            }

            SqlConnection conn = new SqlConnection();
            string strConn = GetConnected();
            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = strSQL;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            conn.Open();
            da.Fill(ds, "PersonV2_temp");
            conn.Close();

            return ds;
        }

        public SqlDataReader FindOnePerson(int intPersonID)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            String strConn = GetConnected();

            string sqlString = "SELECT * FROM PersonV2 WHERE PersonID = @PersonID";

            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@PersonID", intPersonID);

            conn.Open();

            return comm.ExecuteReader();

        }

        public string UpdateARecord()
        {
            Int32 intRecords = 0;
            string strResult = "";
            SqlConnection Conn = new SqlConnection();

            Conn.ConnectionString = GetConnected();

            string strSQL = "UPDATE PersonV2 SET fname = @fname, mname = @mname, lname = @lname, Street1 = @Street1, Street2 = @Street2, City = @City, State = @State, Zipcode = @Zipcode, Phone = @Phone, Email = @Email, Cellphone = @Cellphone, IG = @IG WHERE PersonID = @PersonID;";

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
            comm.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Conn.Open();
                intRecords = comm.ExecuteNonQuery();
                strResult = $"SUCCESS: Updated {intRecords} Records";

            }
            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;
            }
            finally
            {
                Conn.Close();
            }

            return strResult;
        }

        public string DeleteOnePerson(int intPersonID)
        {
            Int32 intRecords = 0;
            string strResult = "";

            SqlConnection Conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            string strConn = GetConnected();
            Conn.ConnectionString = strConn;

            string strSQL = "DELETE FROM PersonV2 WHERE PersonID = @PersonID;";


            comm.CommandText = strSQL;
            comm.Connection = Conn;

            comm.Parameters.AddWithValue("@PersonID", intPersonID);


            try
            {
                Conn.Open();
                intRecords = comm.ExecuteNonQuery();
                strResult = $"{intRecords} Records Deleted";

            }
            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;
            }
            finally
            {
                Conn.Close();
            }

            return strResult;
        }

        private string GetConnected()
        {
            return "Server=sql.neit.edu,4500;Database=SE133_SOquendo;User Id=SE133_SOquendo;Password=008016420;";
        }


    }
    
}

