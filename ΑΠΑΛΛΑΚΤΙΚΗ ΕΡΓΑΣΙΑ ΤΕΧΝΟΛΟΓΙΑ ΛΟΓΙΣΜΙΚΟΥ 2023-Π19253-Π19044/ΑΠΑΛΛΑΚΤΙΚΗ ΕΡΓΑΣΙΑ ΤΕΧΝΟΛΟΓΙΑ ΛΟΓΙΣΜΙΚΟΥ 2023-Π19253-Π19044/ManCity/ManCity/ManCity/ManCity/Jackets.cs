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
    public partial class Jackets : Form
    {
        Categories categories;
        ShoppingBasket shoppingbasket;
        public Jackets(Categories categories,ShoppingBasket shoppingbasket)
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
            if (BlueJ.Value > 0)
            {
                shoppingbasket.ItemAddingTable(9,"Blue Jacket", BlueJ.Value, 9.99);
            }
            if (BlueCJ.Value > 0)
            {
                shoppingbasket.ItemAddingTable(10,"Blue Camo Jacket", BlueCJ.Value, 9.99);
            }
            if (PinkWhiteJ.Value > 0)
            {
                shoppingbasket.ItemAddingTable(11,"Pink White Jacket", PinkWhiteJ.Value, 9.99);
            }
            if (BlackJ.Value > 0)
            {
                shoppingbasket.ItemAddingTable(12,"Black Jacket", BlackJ.Value, 9.99);
            }
        }

        private void Mugs_Load(object sender, EventArgs e)
        {

        }
    }
}
