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
    public partial class Categories : Form
    {
        ShoppingBasket shoppingbasket;
        public Categories()
        {
            InitializeComponent();
            shoppingbasket = new ShoppingBasket(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Toys funkopop = new Toys(this,shoppingbasket);
            this.Hide();
            funkopop.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TShirts lights = new TShirts(this,shoppingbasket);
            this.Hide();
            lights.Show();  
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Jackets mugs = new Jackets(this,shoppingbasket);
            this.Hide();
            mugs.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Pants figures = new Pants(this,shoppingbasket);
            this.Hide();
            figures.Show();
        }
    }
}
