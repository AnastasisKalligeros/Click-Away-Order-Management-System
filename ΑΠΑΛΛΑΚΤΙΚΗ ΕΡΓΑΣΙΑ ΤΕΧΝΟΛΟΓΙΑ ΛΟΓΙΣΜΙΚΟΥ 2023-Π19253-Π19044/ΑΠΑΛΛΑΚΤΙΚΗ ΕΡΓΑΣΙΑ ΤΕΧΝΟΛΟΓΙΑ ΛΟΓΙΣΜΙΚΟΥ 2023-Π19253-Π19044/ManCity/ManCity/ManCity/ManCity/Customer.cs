using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManCity
{
    class Customer
    {
        private string name;
        private string surname;
        private string email;
        private string location;
        private string date;
        public Customer(string name,string surname, string email,string location,string date)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.location = location;
            this.date = date;

        }
        public bool WriteDB(string shops, string hours, int[] Board)
        {

            try
            {

                string connectionString = "Data Source=DataBase.db;Version=3;";

                SQLiteConnection conn = new SQLiteConnection(connectionString);

                conn.Open();


                string query = "Insert into Orders (Name,Surname,Email,Shop,Hours,Location,Date,Product1,Product2,Product3,Product4,Product5,Product6,Product7,Product8,Product9,Product10,Product11,Product12,Product13,Product14,Product15,Product16) Values (@Name,@Surname,@Email,@Shop,@Hours,@Location,@Date,@Product1,@Product2,@Product3,@Product4,@Product5,@Product6,@Product7,@Product8,@Product9,@Product10,@Product11,@Product12,@Product13,@Product14,@Product15,@Product16)";
                

                SQLiteCommand command = new SQLiteCommand(query, conn);
                command.Parameters.AddWithValue("Name", this.name);
                command.Parameters.AddWithValue("Surname", this.surname);
                command.Parameters.AddWithValue("Email", this.email);
                command.Parameters.AddWithValue("Shop", shops);
                command.Parameters.AddWithValue("Hours", hours);
                command.Parameters.AddWithValue("Location", location);
                command.Parameters.AddWithValue("Date", this.date);
                command.Parameters.AddWithValue("Product1", Board[0].ToString());
                command.Parameters.AddWithValue("Product2", Board[1].ToString());
                command.Parameters.AddWithValue("Product3", Board[2].ToString());
                command.Parameters.AddWithValue("Product4", Board[3].ToString());
                command.Parameters.AddWithValue("Product5", Board[4].ToString());
                command.Parameters.AddWithValue("Product6", Board[5].ToString());
                command.Parameters.AddWithValue("Product7", Board[6].ToString());
                command.Parameters.AddWithValue("Product8", Board[7].ToString());
                command.Parameters.AddWithValue("Product9", Board[8].ToString());
                command.Parameters.AddWithValue("Product10", Board[9].ToString());
                command.Parameters.AddWithValue("Product11", Board[10].ToString());
                command.Parameters.AddWithValue("Product12", Board[11].ToString());
                command.Parameters.AddWithValue("Product13", Board[12].ToString());
                command.Parameters.AddWithValue("Product14", Board[13].ToString());
                command.Parameters.AddWithValue("Product15", Board[14].ToString());
                command.Parameters.AddWithValue("Product16", Board[15].ToString());



                int return_value = command.ExecuteNonQuery();
                
                conn.Close();
                return true;
              

            }
            catch
            {
                Console.WriteLine("error");
            }
            return false;
        }
    }
}
