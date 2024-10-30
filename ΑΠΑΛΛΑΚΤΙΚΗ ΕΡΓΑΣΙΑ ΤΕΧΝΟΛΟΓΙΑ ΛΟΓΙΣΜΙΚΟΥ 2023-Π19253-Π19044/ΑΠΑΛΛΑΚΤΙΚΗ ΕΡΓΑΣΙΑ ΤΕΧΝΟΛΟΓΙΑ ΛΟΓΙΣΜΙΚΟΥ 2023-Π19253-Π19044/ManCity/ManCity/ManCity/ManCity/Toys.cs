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
    public partial class Toys : Form
    {
        Categories categories;
        ShoppingBasket shoppingbasket;
        public Toys(Categories categories, ShoppingBasket shoppingbasket)
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
            if (ManCityBear.Value > 0)
            {
                shoppingbasket.ItemAddingTable(1,"Man City Bear ", ManCityBear.Value, 14.99);
            }
            if (Foden.Value > 0)
            {
                shoppingbasket.ItemAddingTable(2,"Funko Pop Foden ", Foden.Value, 14.99);
            }
            if (Haaland.Value > 0)
            {
                shoppingbasket.ItemAddingTable(3,"Haaland ", Haaland.Value, 14.99);
            }
            if (ManCityLego.Value > 0)
            {
                shoppingbasket.ItemAddingTable(4,"Man City Lego ", ManCityLego.Value, 14.99);
            }
        }

        private void Toys_Load(object sender, EventArgs e)
        {

        }
    }
}
