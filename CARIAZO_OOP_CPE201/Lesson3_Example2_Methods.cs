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
    public partial class Lesson3_Example2_Methods : Form
    {
        double qty = 0;
        double price = 0;
        double discount_amt = 0;
        double discounted_amt = 0;

        public Lesson3_Example2_Methods()
        {
            InitializeComponent();
        }

        private void quantityTextbox()
        {
            quantitytxtbox.Clear();
            quantitytxtbox.Focus();
        }

        private void quantity_price_convert()
        {

            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetxtbox.Text);
        }

        private void computation_Formula_and_Display()
        {
            discounted_amt = (qty * price) - discount_amt;
            discount_totaltxtbox.Text = discount_amt.ToString("n");
            discounted_totaltxtbox.Text = discounted_amt.ToString("n");
        }

        private void price_item_TextValue(string itemname, string price)
        {
            itemnametxtbox.Text = itemname;
            pricetxtbox.Text = price;
        }

        private void Activity3_Load(object sender, EventArgs e)
        {
            int qty = 0;
            double discount_total = 0;
            double discounted_total = 0;
        }

        private void EmployeeRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                discount_amt = (qty * price) * 0;

                computation_Formula_and_Display();

                radioButton1.Checked = false;
                regularRbtn.Checked = false;
                noTaxRdbtn.Checked = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTextbox();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            // declaration of variables within a method of an object
            //int qty;
            //double price, discount_amt, discounted_amt;
            // convert string data from textboxes to numeric and place it as value of the variable
            //qty = Convert.ToInt32(quantitytxtbox.Text);
            //price = Convert.ToDouble(pricetxtbox.Text);
            // create a formula needed for computation
            //discount_amt = (qty * price) * 0.15;
            //discounted_amt = (qty * price) - discount_amt;
            // converting numeric data to string and display it in the textboxes
            //discounttxtbox.Text = discount_amt.ToString("n");
            //discountedtxtbox.Text = discounted_amt.ToString("n");
            // codes for umchecking the other radio buttons in the interface once with employee disc. method executed
            //regularRbtn.Checked = false;
            //EmployeeRdbtn.Checked = false;
            //noTaxRdbtn.Checked = false;

            try
            {
                discount_amt = (qty * price) * 0;

                computation_Formula_and_Display();

                radioButton1.Checked = false;
                regularRbtn.Checked = false;
                noTaxRdbtn.Checked = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTextbox();
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Declaration of variables within a method of an object
            //int qty;
            //double price, discount_amt, discounted_amt;
            // convert string data from textboxes to numeric and place it as value of the variable
            //qty = Convert.ToInt32(quantitytxtbox.Text);
            //price = Convert.ToDouble(pricetxtbox.Text);
            // create a formula needed for computation
            //discount_amt = (qty * price) * 0.10;
            //discounted_amt = (qty * price) - discount_amt;
            // converting numeric data to string and display it in the textboxes
            //discounttxtbox.Text = discount_amt.ToString("n");
            //discountedtxtbox.Text = discounted_amt.ToString("n");
            // codes for umchecking the other radio buttons in the interface once with disc. card method executed
            //regularRbtn.Checked = false;
            //EmployeeRdbtn.Checked = false;
            //noTaxRdbtn.Checked = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //itemnametxtbox.Text = "Chicken Joy SuperMeal with Drink";
            //pricetxtbox.Text = "210.00";

            price_item_TextValue("Chicken Joy SuperMeal with Drink", "210.00");
            quantityTextbox();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void Activity4_Load(object sender, EventArgs e)
        {
            // codes for disabling the textboxes
            itemnametxtbox.Enabled = false;
            pricetxtbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;
            discounttxtbox.Enabled = false;
            // codes for inserting picture or image inside the picturebox tool



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //itemnametxtbox.Text = "Chickenjoy with Spaghetti and Drink";
            //pricetxtbox.Text = "180.00";

            price_item_TextValue("Chickenjoy with Spaghetti and Drink", "180.00");
            quantityTextbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "1-pc. Chickenjoy w/ Drink";
            pricetxtbox.Text = "120.00";

            price_item_TextValue("1-pc. Chickenjoy w/ Drink", "120.00");
            quantityTextbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "2-pc. Chickenjoy w/ Drink";
            pricetxtbox.Text = "160.00";

            price_item_TextValue("2-pc. Chickenjoy w/ Drink", "160.00");
            quantityTextbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "1-pc. Chickenjoy w/ Coke Float";
            pricetxtbox.Text = "140.00";

            price_item_TextValue("1-pc. Chickenjoy w/ Coke Float", "140.00");
            quantityTextbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Spaghetti Family Pan";
            pricetxtbox.Text = "150.00";

            price_item_TextValue("Spaghetti Family Pan", "150.00");
            quantityTextbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Chicken Joy Bucket and Spaghetti Family Pan";
            pricetxtbox.Text = "420.00";

            price_item_TextValue("Chicken Joy Bucket and Spaghetti Family Pan", "420.00");
            quantityTextbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Spaghetti w/ Fries and Drink";
            pricetxtbox.Text = "95.00";

            price_item_TextValue("Spaghetti w/ Fries and Drink", "95.00");
            quantityTextbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Spaghetti w/ Yumburger and Drink";
            pricetxtbox.Text = "100.00";

            price_item_TextValue("Spaghetti w/ Yumburger and Drink", "100.00");
            quantityTextbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Group Meal for 4";
            pricetxtbox.Text = "550.00";

            price_item_TextValue("Group Meal for 4", "550.00");
            quantityTextbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Yumburger w/ Fries and Drink";
            pricetxtbox.Text = "90.00";

            price_item_TextValue("Yumburger w/ Fries and Drink", "90.00");
            quantityTextbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Cheesy Yumburger w/ Fries and Drink";
            pricetxtbox.Text = "120.00";

            price_item_TextValue("Cheesy Yumburger w/ Fries and Drink", "120.00");
            quantityTextbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Cheesy Bacon Yumburger w/ Fries and Drink";
            pricetxtbox.Text = "145.00";

            price_item_TextValue("Cheesy Bacon Yumburger w/ Fries and Drink", "145.00");
            quantityTextbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Aloha Champ w/ Fries and Drink";
            pricetxtbox.Text = "170.00";

            price_item_TextValue("Aloha Champ w/ Fries and Drink", "170.00");
            quantityTextbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Double Cheesy Yumburger w/ Fries and Drink";
            pricetxtbox.Text = "150.00";

            price_item_TextValue("Double Cheesy Yumburger w/ Fries and Drink", "150.00");
            quantityTextbox();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Iced Coffee";
            pricetxtbox.Text = "60.00";

            price_item_TextValue("Iced Coffee", "60.00");
            quantityTextbox();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Hot Espresso";
            pricetxtbox.Text = "40.00";

            price_item_TextValue("Hot Espresso", "40.00");
            quantityTextbox();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Iced Tea";
            pricetxtbox.Text = "50.00";

            price_item_TextValue("Iced Tea", "50.00");
            quantityTextbox();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Coke";
            pricetxtbox.Text = "50.00";

            price_item_TextValue("Coke", "50.00");
            quantityTextbox();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Royal";
            pricetxtbox.Text = "50.00";

            price_item_TextValue("Royal", "50.00");
            quantityTextbox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // declaration of variables with data types
                int qty;
                double discount_amt, discounted_amt, cash_rendered, change;


                qty = Convert.ToInt32(quantitytxtbox.Text);


                discount_amt = Convert.ToDouble(discounttxtbox.Text);
                discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
                cash_rendered = Convert.ToDouble(cashre_renderedtxtbox.Text);

                //codes to accumulate the value of the quantity, discount given and discounted amount from one transaction to another 
                int qty_total = qty;
                double discount_total = discount_amt;
                double discounted_total = discounted_amt;
                change = cash_rendered - discounted_amt;
                // converting string data from textboxes to numeric and place it as value of the variable
                qty_totaltxtbox.Text = qty_total.ToString();
                discount_totaltxtbox.Text = discount_total.ToString("n");
                discounted_totaltxtbox.Text = discounted_total.ToString("n");
                changetxtbox.Text = change.ToString("n");
                cashre_renderedtxtbox.Text = cash_rendered.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Make Sure cash given textbox is not empty invalid");
                cashre_renderedtxtbox.Clear();
                cashre_renderedtxtbox.Focus();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // codes for clearing specific pointed textboxes
            itemnametxtbox.Clear();
            pricetxtbox.Clear();
            quantitytxtbox.Clear();
            discountedtxtbox.Clear();
            discounttxtbox.Clear();
            changetxtbox.Clear();
            cashre_renderedtxtbox.Clear();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Declaration of variables within a method of an object
            //int qty;
            //double price, discount_amt, discounted_amt;
            // convert string data from textboxes to numeric and place it as value of the variable
            //qty = Convert.ToInt32(quantitytxtbox.Text);
            //price = Convert.ToDouble(pricetxtbox.Text);
            // create a formula needed for computation
            //discount_amt = (qty * price) * 0.30;
            //discounted_amt = (qty * price) - discount_amt;
            // converting numeric data to string and display it in the textboxes
            //discounttxtbox.Text = discount_amt.ToString("n");
            //discountedtxtbox.Text = discounted_amt.ToString("n");
            // codes for umchecking the other radio buttons in the interface once the senio citizen method executed
            //regularRbtn.Checked = false;
            //EmployeeRdbtn.Checked = false;
            //noTaxRdbtn.Checked = false;

            try
            {
                discount_amt = (qty * price) * 0;

                computation_Formula_and_Display();

                EmployeeRdbtn.Checked = false;
                regularRbtn.Checked = false;
                noTaxRdbtn.Checked = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTextbox();
            }




        }

        private void noTaxRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            // declaration of variables within a method of an object
            //int qty;
            //double price, discount_amt, discounted_amt;
            // convert string data from textboxes to numeric and place it as value of the variable
            //qty = Convert.ToInt32(quantitytxtbox.Text);
            //price = Convert.ToDouble(pricetxtbox.Text);
            // create a formula needed for computation
            //discount_amt = (qty * price) * 0;
            //discounted_amt = (qty * price) - discount_amt;
            // converting numeric data to string and display it in the textboxes
            //discounttxtbox.Text = discount_amt.ToString("n");
            //discountedtxtbox.Text = discounted_amt.ToString("n");
            // codes for umchecking the other radio buttons in the interface once no method executed
            //regularRbtn.Checked = false;
            //EmployeeRdbtn.Checked = false;
            //noTaxRdbtn.Checked = false;

            try
            {
                discount_amt = (qty * price) * 0;

                computation_Formula_and_Display();

                radioButton1.Checked = false;
                regularRbtn.Checked = false;
                EmployeeRdbtn.Checked = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTextbox();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
