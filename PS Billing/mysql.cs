using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;


namespace PS_Billing
{
    class mysql
    {
        // Prepare the connection
        string connectionString = "datasource=127.0.0.1;sslmode=none;port=3306;username=root;password=;database=ps_billing;";

        #region Select
        
        public DataTable select(string query)
        {
            DataTable dt = new DataTable();
            string error = "";
            try
            {
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                //MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                //commandDatabase.CommandTimeout = 60;
                MySqlDataAdapter da = new MySqlDataAdapter(query, databaseConnection);
                da.Fill(dt);
                // MySqlDataReader reader;
            }
            catch(Exception er)
            {
                error = ""+er.Message;
            }
            return dt;
        }
    
        
    #endregion

    #region Add
    public string add(string query)
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand indata = new MySqlCommand(query,databaseConnection);
            databaseConnection.Open();
            string res = "";
            
            try
            {
                 indata.ExecuteNonQuery();
                res = "Success";
            }
            catch(Exception er)
            {
               res = "Failed " + er.Message;
            }
            databaseConnection.Close();
            return res;

        }

        #endregion

        #region Delete
        public string Delete(string query)
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand del = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            string res;


            try
            {
                del.ExecuteNonQuery();
                res = "Record Delete Success!!";
            }
            catch(Exception er)
            {
                res = "Failed" + er.Message;
            }
            databaseConnection.Close();
            return res;
        }
        #endregion

        #region Update
        public string Update(string query)
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand updt = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            string res;

            try
            {
                updt.ExecuteNonQuery();
                res = "Record Update Success!!";
            }
            catch (Exception er)
            {
                res = "Failed" + er.Message;
            }
            databaseConnection.Close();
            return res;
        }
#endregion


    #region MD5
    public string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
        #endregion
    }
}
