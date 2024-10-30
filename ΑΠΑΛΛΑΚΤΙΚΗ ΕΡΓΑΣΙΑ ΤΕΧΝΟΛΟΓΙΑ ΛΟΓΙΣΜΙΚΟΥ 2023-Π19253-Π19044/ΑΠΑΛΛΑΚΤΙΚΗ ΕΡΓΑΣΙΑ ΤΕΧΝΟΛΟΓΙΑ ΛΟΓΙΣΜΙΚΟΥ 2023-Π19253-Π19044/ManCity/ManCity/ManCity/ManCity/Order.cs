using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ManCity
{
    public partial class Order : Form
    {
        string shops;
        string hours;
        int[] Board;
        string location;
        string date;

        public Order(string shops , string hours, int []Board,string location,string date)
        {
            InitializeComponent();
            this.shops = shops;
            this.hours= hours;
            this.Board = Board;
            this.location = location;
            this.date = date.Remove(10);
          
            
           
        }



       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmationButton_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε όλα τα πεδία");

            }
            else
            {
                Customer customer = new Customer(textBox1.Text, textBox2.Text, textBox3.Text,location,date);
                bool ret_value = customer.WriteDB(shops, hours, Board);
                if(ret_value) { 
                    MessageBox.Show("Επιτυχής Παραγγελία."); 
                }
                else
                {
                    MessageBox.Show("Πρόβλημα κατά την Παραγγελία.");
                }
                
            }
        }
        private void WriteDB()
        {
            
            try
            {

                string connectionString = "Data Source=DataBase.db;Version=3;";

                SQLiteConnection conn = new SQLiteConnection(connectionString);

                conn.Open();


                MessageBox.Show("Σύνδεση με την βάση");
               
             
                
                string query = "Insert into Orders (Name,Surname,Email,Shop,Hours,Location,Product1,Product2,Product3,Product4,Product5,Product6,Product7,Product8,Product9,Product10,Product11,Product12,Product13,Product14,Product15,Product16) Values (@Name,@Surname,@Email,@Shop,@Hours,@Location,@Product1,@Product2,@Product3,@Product4,@Product5,@Product6,@Product7,@Product8,@Product9,@Product10,@Product11,@Product12,@Product13,@Product14,@Product15,@Product16)";
                //string query2 = "Insert into test (Name,Surname,Email,Shop,Hours,Product1) Values (@Name,@Surname,@Email,@Shop,@Hours,@Product1)";
                
                SQLiteCommand command = new SQLiteCommand(query, conn);
                command.Parameters.AddWithValue("Name", textBox1.Text);
                command.Parameters.AddWithValue("Surname", textBox2.Text);
                command.Parameters.AddWithValue("Email", textBox3.Text);
                command.Parameters.AddWithValue("Shop",shops);
                command.Parameters.AddWithValue("Hours", hours);
                command.Parameters.AddWithValue("Location", location);
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
                MessageBox.Show("Επιτυχής Παραγγελία.");

            }
            catch
            {
                MessageBox.Show("Πρόβλημα με τη σύνδεση της βάσης");
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {

        }

        
    }
}
