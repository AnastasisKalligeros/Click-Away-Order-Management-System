using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManCity
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

      
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ShopBox_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ShopBox_Click_1(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            this.Hide();
            categories.Show();

        }
    }
}
