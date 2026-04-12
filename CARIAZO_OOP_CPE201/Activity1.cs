using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARIAZO_OOP_CPE201
{
    public partial class Activity1 : Form
    {
        public Activity1()
        {
            InitializeComponent();
        }

        private void Activity1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ItemNameTxtbox.Text = "1-pc ChickenJoy";
            PriceTxtbox.Text = "121.30";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ItemNameTxtbox.Text = "1-pc ChickenJoy w/ Burger Steak";
            PriceTxtbox.Text = "391.90";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ItemNameTxtbox.Text = "1-pc ChickenJoy w/ Burger Steak & Drink";
            PriceTxtbox.Text = "191.00";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ItemNameTxtbox.Text = "1-pc ChickenJoy w/ Coke Float";
            PriceTxtbox.Text = "799.30";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ItemNameTxtbox.Text = "1-pc ChickenJoy w/ Drink";
            PriceTxtbox.Text = "91.30";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ItemNameTxtbox.Text = "1-pc ChickenJoy w/ Jolly Spaghetti";
            PriceTxtbox.Text = "95.30";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ItemNameTxtbox.Text = "1-pc ChickenJoy w/ Palabok & Drink";
            PriceTxtbox.Text = "138.50";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ItemNameTxtbox.Text = "2-pc ChickenJoy w/ Drink";
            PriceTxtbox.Text = "159.30";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ItemNameTxtbox.Text = "Friend Meal A";
            PriceTxtbox.Text = "799.30";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ItemNameTxtbox.Text = "4-pc ChickenJoy";
            PriceTxtbox.Text = "399.50";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            ItemNameTxtbox.Text = "6-pc ChickenJoy & Palabok Family Pan";
            PriceTxtbox.Text = "780.50";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ItemNameTxtbox.Text = "Double Cheeseburger w/ Drink";
            PriceTxtbox.Text = "135.30";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            ItemNameTxtbox.Text = "Burger Champ";
            PriceTxtbox.Text = "110.00";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            ItemNameTxtbox.Text = "6-pc ChickenNuggets";
            PriceTxtbox.Text = "165.00";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            ItemNameTxtbox.Text = "Sundae";
            PriceTxtbox.Text = "65.00";
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            ItemNameTxtbox.Clear();
            PriceTxtbox.Clear();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
