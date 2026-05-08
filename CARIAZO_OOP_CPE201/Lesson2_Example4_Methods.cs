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
    public partial class Lesson2_Example4_Methods : Form
    {
        public Lesson2_Example4_Methods()
        {
            InitializeComponent();
        }

        private void displayTxtbox(string itemname, string price)
        {
            ItemNameTxtbox.Text = itemname;
            PriceTxtbox.Text = price;
        }
        private void quantityTxtbox()
        {
            displayTxtbox("1-pc ChickenJoy", "121.30");
            //QuantityTxtbox.Clear();
            //QuantityTxtbox.Focus();
            quantityTxtbox();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //ItemNameTxtbox.Text = "1-pc ChickenJoy";
            //PriceTxtbox.Text = "121.30";
            displayTxtbox("1-pc ChickenJoy", "121.30");
            quantityTxtbox();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //ItemNameTxtbox.Text = "1-pc ChickenJoy w/ Burger Steak";
            //riceTxtbox.Text = "391.90";
            displayTxtbox("1-pc ChickenJoy w/ Burger Steak", "391.90");
            quantityTxtbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //ItemNameTxtbox.Text = "1-pc ChickenJoy w/ Burger Steak & Drink";
            //PriceTxtbox.Text = "191.00";
            displayTxtbox("1-pc ChickenJoy w/ Burger Steak & Drink", "191.00");
            quantityTxtbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //ItemNameTxtbox.Text = "1-pc ChickenJoy w/ Coke Float";
            //PriceTxtbox.Text = "799.30";
            displayTxtbox("1-pc ChickenJoy w/ Coke Float", "799.30");
            quantityTxtbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //ItemNameTxtbox.Text = "1-pc ChickenJoy w/ Drink";
            //PriceTxtbox.Text = "91.30";
            displayTxtbox("1-pc ChickenJoy w/ Drink", "91.30");
            quantityTxtbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //ItemNameTxtbox.Text = "1-pc ChickenJoy w/ Jolly Spaghetti";
            //PriceTxtbox.Text = "95.30";
            displayTxtbox("1-pc ChickenJoy w/ Jolly Spaghetti", "95.30");
            quantityTxtbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //ItemNameTxtbox.Text = "1-pc ChickenJoy w/ Palabok & Drink";
            //PriceTxtbox.Text = "138.50";
            displayTxtbox("1-pc ChickenJoy w/ Palabok & Drink", "138.50");
            quantityTxtbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //ItemNameTxtbox.Text = "2-pc ChickenJoy w/ Drink";
            //PriceTxtbox.Text = "159.30";
            displayTxtbox("2-pc ChickenJoy w/ Drink", "159.30");
            quantityTxtbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //ItemNameTxtbox.Text = "Friend Meal A";
            //PriceTxtbox.Text = "799.30";
            displayTxtbox("Friend Meal A", "799.30");
            quantityTxtbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //ItemNameTxtbox.Text = "4-pc ChickenJoy";
            //PriceTxtbox.Text = "399.50";
            displayTxtbox("4-pc ChickenJoy", "399.50");
            quantityTxtbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //ItemNameTxtbox.Text = "6-pc ChickenJoy & Palabok Family Pan";
            //PriceTxtbox.Text = "780.50";
            displayTxtbox("6-pc ChickenJoy & Palabok Family Pan", "780.50");
            quantityTxtbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            //ItemNameTxtbox.Text = "Double Cheeseburger w/ Drink";
            //PriceTxtbox.Text = "135.30";
            displayTxtbox("Double Cheeseburger w/ Drink", "135.30");
            quantityTxtbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            //ItemNameTxtbox.Text = "Burger Champ";
            //PriceTxtbox.Text = "110.00";
            displayTxtbox("Burger Champ", "110.00");
            quantityTxtbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            //ItemNameTxtbox.Text = "6-pc ChickenNuggets";
            //PriceTxtbox.Text = "165.00";
            displayTxtbox("6-pc ChickenNuggets", "165.00");
            quantityTxtbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            //ItemNameTxtbox.Text = "Sundae";
            //PriceTxtbox.Text = "65.00";
            displayTxtbox("Sundae", "65.00");
            quantityTxtbox();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            //ItemNameTxtbox.Clear();
            //PriceTxtbox.Clear();

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lesson2_Example4_Methods_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
