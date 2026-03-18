using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CARIAZO_OOP_CPE201
{
    public partial class Activity6 : Form
    {
        private double total_amount = 0;
        private int total_qty = 0;

        public Activity6()
        {
            InitializeComponent();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Activity6_Load(object sender, EventArgs e)
        {
            priceTxtbox.Enabled = false;
            discountedamountTxtbox.Enabled = false;
            changeTxtbox.Enabled = false;
            totalbillsTxtbox.Enabled = false;
            discountamountTxtbox.Enabled = false;
            quantityTxtbox.Enabled = false;

            A_cokeCheckBox.Enabled = false;
            A_friedchickenCheckBox.Enabled = false;
            A_largefriesCheckBox.Enabled = false;
            A_sidedishesCheckBox.Enabled = false;
            A_pizzadelightsCheckBox.Enabled = false;
            B_carbonaraCheckBox.Enabled = false;
            B_friedchickenCheckBox.Enabled = false;
            B_halohaloCheckBox.Enabled = false;
            B_hawaiianpizzaCheckBox.Enabled = false;
            B_packfriesCheckBox.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foodaRadioBtn.Checked = false;
            foodbRadioBtn.Checked = false;

            orderimagePictureBox.Image = null;

            A_cokeCheckBox.Checked = false;
            A_friedchickenCheckBox.Checked = false;
            A_largefriesCheckBox.Checked = false;
            A_sidedishesCheckBox.Checked = false;
            A_pizzadelightsCheckBox.Checked = false;
            B_carbonaraCheckBox.Checked = false;
            B_friedchickenCheckBox.Checked = false;
            B_halohaloCheckBox.Checked = false;
            B_hawaiianpizzaCheckBox.Checked = false;
            B_packfriesCheckBox.Checked = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox10.Checked = false;
            checkBox9.Checked = false;
            checkBox8.Checked = false;
            checkBox7.Checked = false;
            checkBox6.Checked = false;

            listBox1.Items.Clear();

            double price = 0;
            double.TryParse(priceTxtbox.Text, out price);

            int qty = 0;
            int.TryParse(quantityTxtbox.Text, out qty);
        }

        private void foodaRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            this.BackColor = Color.LightCyan;

            foodbRadioBtn.Checked = false;

            pictureBox1.Image = Properties.Resources._21;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            A_cokeCheckBox.Enabled = true;
            A_friedchickenCheckBox.Enabled = true;
            A_largefriesCheckBox.Enabled = true;
            A_sidedishesCheckBox.Enabled = true;
            A_pizzadelightsCheckBox.Enabled = true;

            B_carbonaraCheckBox.Enabled = false;
            B_friedchickenCheckBox.Enabled = false;
            B_halohaloCheckBox.Enabled = false;
            B_hawaiianpizzaCheckBox.Enabled = false;
            B_packfriesCheckBox.Enabled = false;

            priceTxtbox.Text = "1,000.00";
            discountamountTxtbox.Text = "200.00";
            price = Convert.ToDouble(priceTxtbox.Text);

            listBox1.Items.Add(foodbRadioBtn.Text + "" + priceTxtbox.Text);
            listBox1.Items.Add("Discount Amount: " + "" + discountamountTxtbox.Text);
            quantityTxtbox.Text = "0";
            quantityTxtbox.Focus();
        }

        private void foodbRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            this.BackColor = Color.LightCyan;

            foodbRadioBtn.Checked = false;

            pictureBox1.Image = Properties.Resources._22;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            A_cokeCheckBox.Enabled = false;
            A_friedchickenCheckBox.Enabled = false;
            A_largefriesCheckBox.Enabled = false;
            A_sidedishesCheckBox.Enabled = false;
            A_pizzadelightsCheckBox.Enabled = false;

            B_carbonaraCheckBox.Enabled = true;
            B_friedchickenCheckBox.Enabled = true;
            B_halohaloCheckBox.Enabled = true;
            B_hawaiianpizzaCheckBox.Enabled = true;
            B_packfriesCheckBox.Enabled = true;

            priceTxtbox.Text = "1,299.00";
            discountamountTxtbox.Text = "(15% of the Price) P194.85";
            listBox1.Items.Add(foodaRadioBtn.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cash_given, change, total_amountPaid;
            cash_given = Convert.ToDouble(cashgivenTxtbox.Text);
            total_amountPaid = Convert.ToDouble(totalbillsTxtbox.Text);
            change = cash_given - total_amountPaid;
            changeTxtbox.Text = change.ToString("n");
            listBox1.Items.Add("Total Bills: " + "" + totalbillsTxtbox.Text);
            listBox1.Items.Add("Cash Given: " + "" + cashgivenTxtbox.Text);
            listBox1.Items.Add("Change: " + "" + changeTxtbox.Text);
            listBox1.Items.Add("Total No. of Items: " + "" + quantityTxtbox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Activity6 print = new Activity6();

            print.listBox1.Items.AddRange(this.listBox1.Items);

            print.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double price;

            discountamountTxtbox.Text = "0.00";
            priceTxtbox.Text = "500.99";

            price = Convert.ToDouble(priceTxtbox.Text);

            listBox1.Items.Add(checkBox1.Text + "" + priceTxtbox.Text);

            quantityTxtbox.Text = "0";

            quantityTxtbox.Focus();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
