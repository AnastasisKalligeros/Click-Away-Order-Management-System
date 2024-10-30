using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class Form1 : Form
    {
        Admin admin = new Admin();
        public Form1()
        {
            InitializeComponent();
        }

     

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(location.Text))
            {
                string shop = null;
                if (comboBox1.SelectedIndex == 0) shop = "Πειραιάς";
                if (comboBox1.SelectedIndex == 1) shop = "Κηφισιά";
                if (comboBox1.SelectedIndex == 2) shop = "Γαλάτσι";
                System.Data.DataTable dtRecord = admin.loadDB(shop);
                if (dtRecord != null)
                {
                    dataGridView1.DataSource = dtRecord;
                    dataGridView1.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Πρόβλημα κατα την φόρτωση των παραγγελιών.");
                }
            }
            else
            {
                string shop = null;
                if (comboBox1.SelectedIndex == 0) shop = "Πειραιάς";
                if (comboBox1.SelectedIndex == 1) shop = "Κηφισιά";
                if (comboBox1.SelectedIndex == 2) shop = "Γαλάτσι";
                System.Data.DataTable dtRecord = admin.loadDBV2(location.Text,shop);
                if (dtRecord != null)
                {
                    dataGridView1.DataSource = dtRecord;
                    dataGridView1.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Πρόβλημα κατα την φόρτωση των παραγγελιών.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Admin admin = new Admin();
           bool flag = admin.login(Username.Text, Password.Text);
            if (flag)
            {
                panel1.Hide();
            }
            else
            {
                MessageBox.Show("Λάθος στοιχεία");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
