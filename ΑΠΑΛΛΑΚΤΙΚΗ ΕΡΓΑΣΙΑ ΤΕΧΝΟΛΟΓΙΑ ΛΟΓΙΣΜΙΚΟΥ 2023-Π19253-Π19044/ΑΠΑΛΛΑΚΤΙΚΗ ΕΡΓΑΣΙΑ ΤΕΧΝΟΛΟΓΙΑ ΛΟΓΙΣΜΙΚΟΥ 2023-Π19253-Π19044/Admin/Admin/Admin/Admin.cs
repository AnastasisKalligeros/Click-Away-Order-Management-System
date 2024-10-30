using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin 
{
    class Admin
    {
        private string name;
        public bool login(string username, string password)
        {
            try
            {
                string connectionString = "Data Source=DataBase.db;Version=3;";
                SQLiteConnection conn = new SQLiteConnection(connectionString);
                conn.Open();
                string query = "select password from Credentials where username= @username";
                SQLiteCommand command = new SQLiteCommand(query, conn);
                command.Parameters.AddWithValue("username", username);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (reader.GetString(0) == password)
                    {
                        return true;
            }

                }
                else
                {
                    return false;
                }
                conn.Close();

            }
            catch
            {
                Console.Write("Error");
            }
            return false;
        }

        public System.Data.DataTable loadDB(string shop)
        {
            DataTable dtRecord = new DataTable();
            try
            {
                string connectionString = "Data Source=DataBase.db;Version=3;";
                SQLiteConnection con = new SQLiteConnection(connectionString);

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "Select * from Orders where Shop= @shop";
                sqlCmd.Parameters.AddWithValue("shop", shop);
                SQLiteDataAdapter sqlDataAdap = new SQLiteDataAdapter(sqlCmd);

                dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                return dtRecord;
                
            }
            catch {
                Console.WriteLine("error");
            }
            return dtRecord;
        }
        public System.Data.DataTable loadDBV2(string location, string shop)
        {
            DataTable dtRecord = new DataTable();
            try
            {
                string connectionString = "Data Source=DataBase.db;Version=3;";
                SQLiteConnection con = new SQLiteConnection(connectionString);

                SQLiteCommand sqlCmd = new SQLiteCommand();
                sqlCmd.Connection = con;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "Select * from Orders where Location= @location and Shop =@shop";
                sqlCmd.Parameters.AddWithValue("location", location);
                sqlCmd.Parameters.AddWithValue("shop", shop);
                SQLiteDataAdapter sqlDataAdap = new SQLiteDataAdapter(sqlCmd);

                dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                return dtRecord;

            }
            catch
            {
                Console.WriteLine("error");
            }
            return dtRecord;
        }
        private bool CheckLogin()
        {   bool flag = true;
            return flag;
        }
    }
}
