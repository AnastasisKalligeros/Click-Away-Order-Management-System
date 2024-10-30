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
    public partial class Pants : Form
    {
        ShoppingBasket shoppingbasket;
        Categories categories;
        public Pants(Categories categories,ShoppingBasket shoppingbasket)
        {
            InitializeComponent();
            this.shoppingbasket = shoppingbasket;
            this.categories = categories;

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            categories.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            shoppingbasket.Show();

        }
        
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        
            if (HomeP.Value > 0)
            {
                shoppingbasket.ItemAddingTable(13,"Home Pant", HomeP.Value, 24.99);
            }
            if (BlackP.Value > 0)
            {
                shoppingbasket.ItemAddingTable(14,"Black Pant", BlackP.Value, 24.99);
            }
            if (AwayP.Value > 0)
            {
                shoppingbasket.ItemAddingTable(15,"Away Pant", AwayP.Value, 24.99);
            }
            if (BlueP.Value > 0)
            {
                shoppingbasket.ItemAddingTable(16,"Blue Pant", BlueP.Value, 24.99);
            }

        }

        private void Figures_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
