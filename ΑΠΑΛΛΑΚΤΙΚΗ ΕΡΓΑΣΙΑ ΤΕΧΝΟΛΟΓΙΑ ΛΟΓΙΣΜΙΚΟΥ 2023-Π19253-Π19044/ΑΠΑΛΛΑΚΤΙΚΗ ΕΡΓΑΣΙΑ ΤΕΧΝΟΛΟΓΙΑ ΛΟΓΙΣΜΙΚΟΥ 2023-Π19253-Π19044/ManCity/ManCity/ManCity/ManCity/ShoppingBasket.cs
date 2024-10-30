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
    public partial class ShoppingBasket : Form
    {
        string location = System.IO.File.ReadAllText(@"text.txt");
        double Sum = 0;
        Categories categories;
        public ShoppingBasket(Categories categories)
        {
            InitializeComponent();
            SumPrice.Text = "0";
            this.categories = categories;
            SumPrice.ForeColor = Color.White;
            label3.Text = "";
            OrderButton.Hide();
            comboBox2.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            label3.Text = "";
            OrderButton.Hide();
            this.Hide();
            categories.Show();
            comboBox2.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }



        public void ItemAddingTable(int id, String product, decimal amount, double price)
        {
            string[] arr = new string[4];

            arr[0] = id.ToString();
            arr[1] = product;
            arr[2] = amount.ToString();
            int temp = Decimal.ToInt32(amount);
            arr[3] = (temp * price).ToString() + "€";

            Sum += temp * price;
            SumPrice.Text = Sum.ToString();

            ListViewItem Additem;
            Additem = new ListViewItem(arr);
            this.listView1.Items.Add(Additem);
        }
        private bool CheckAvailability()
        {
            bool flag = true;
            try
            {

                string connectionString = "Data Source=DataBase.db;Version=3;";

                SQLiteConnection conn = new SQLiteConnection(connectionString);
                string message = "Η τρέχουσα τοποθεσία σας είναι: " + location + ". Επιλέξτε το πιο κοντινό σας κατάστημα.";
                MessageBox.Show(message);
                conn.Open();
                string query = "";
                if (comboBox1.Text == "Πειραιάς")
                {
                    query = "Select * from Shops Where Id = 1";



                }
                else if (comboBox1.Text == "Κηφισιά")
                {
                    query = "Select * from Shops Where Id = 2";

                }
                else
                {
                    query = "Select * from Shops Where Id = 3";

                }
                SQLiteCommand command = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {


                    for (int i = 0; i < listView1.Items.Count; i++)
                    {

                        string x = listView1.Items[i].Text;

                        int Item = Int32.Parse(x);
                        int y = reader.GetInt32(Item + 1);
                        int checker = Int32.Parse(listView1.Items[i].SubItems[2].Text);
                        if (y < checker)
                        {
                            flag = false;

                        }


                    }


                }
                else
                {
                    MessageBox.Show("Δεν υπάρχει εγγραφή");

                }


                conn.Close();


            }
            catch
            {
                MessageBox.Show("Πρόβλημα με τη σύνδεση της βάσης");
            }


            return flag;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            comboBox2.Show();
            if (CheckAvailability() == true)
            {
                label3.Text = "Υπάρχει απόθεμα";
                OrderButton.Show();

            }
            else
            {
                label3.Text = "Δεν υπάρχει απόθεμα";
                OrderButton.Hide();
            }
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            int[] board = new int[16];
            for (int i = 0; i < 16; i++)
            {
                board[i] = 0;
            }
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (board[Int32.Parse(listView1.Items[i].Text)-1] > 0)
                {
                    board[Int32.Parse(listView1.Items[i].Text)-1] = board[Int32.Parse(listView1.Items[i].Text)] + Int32.Parse(listView1.Items[i].SubItems[2].Text);
                }
                else
                {
                    board[Int32.Parse(listView1.Items[i].Text)-1] = Int32.Parse(listView1.Items[i].SubItems[2].Text);
                }
            }
            if (comboBox2.SelectedIndex != -1)
            {
                this.Hide();
                Order order = new Order(comboBox1.Text, comboBox2.Text, board,location,dateTimePicker1.Value.Date.ToString());
                order.Show();



            }
            else
            {
                MessageBox.Show("Παρακαλώ επέλεξε ώρα.");
            }


        }
            
        }
    }
    

