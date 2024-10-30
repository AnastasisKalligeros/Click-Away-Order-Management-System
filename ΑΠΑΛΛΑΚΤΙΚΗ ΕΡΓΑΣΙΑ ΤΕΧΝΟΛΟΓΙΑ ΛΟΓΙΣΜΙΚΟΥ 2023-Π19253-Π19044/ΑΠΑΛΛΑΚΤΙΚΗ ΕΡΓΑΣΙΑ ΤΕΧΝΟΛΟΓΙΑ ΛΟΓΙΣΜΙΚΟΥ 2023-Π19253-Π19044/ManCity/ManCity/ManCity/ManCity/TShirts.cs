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
    public partial class TShirts : Form
    {
        Categories categories;
        ShoppingBasket shoppingbasket;
        public TShirts(Categories categories, ShoppingBasket shoppingbasket)
        {
            InitializeComponent();
            this.categories = categories; 
            this.shoppingbasket = shoppingbasket;
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
            if (PinkWhiteT.Value > 0)
            {
                shoppingbasket.ItemAddingTable(5,"Pink White T-Shirt", PinkWhiteT.Value, 19.99);
            }
            if (BlueT.Value > 0)
            {
                shoppingbasket.ItemAddingTable(6,"Blue T-Shirt", BlueT.Value, 19.99);
            }
            if (GreenT.Value > 0)
            {
                shoppingbasket.ItemAddingTable(7,"Green T-Shirt", GreenT.Value, 19.99);
            }
            if (BlackT.Value > 0)
            {
                shoppingbasket.ItemAddingTable(8,"Black T-Shirt", BlackT.Value, 19.99);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
