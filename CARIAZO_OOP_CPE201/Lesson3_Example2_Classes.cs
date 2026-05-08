using CARIAZO_OOP_CPE201;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CARIAZO_OOP_CPE201
{
    public partial class Lesson3_Example2_Class : Form
    {
        // codes for accessing the class created earlier 
        // call then new name
        Price_Item_Values price_item_values = new Price_Item_Values();
        Variables variables = new Variables();


        public Lesson3_Example2_Class()

        {

            InitializeComponent();


        }

        private void computation_Formula_and_Display()
        {
            // function methods for the formulas needed in the program's computations
            variables.discounted_amt = (variables.quantity * variables.price) - variables.discount_amt;
            discount_total_txtbox.Text = variables.discount_amt.ToString("n");
            discounted_total_txtbox.Text = variables.discounted_amt.ToString("n");
        }
        //function with return value for item name and price textboxes
        public void GetPriceItemValue()
        {
            itemname_txtbox.Text = (price_item_values.GetItemName());
            price_txtbox.Text = (price_item_values.GetPrice());
        }
        // Function method for clearing the quantity textbox and automatically placing the cursor inside it

        private void quantityTextbox()
        {
            quantity_txtbox.Clear();
            quantity_txtbox.Focus();
        }
        // function method for converting quantity and price input from a string to numeric value 
        private void quantity_price_Convert()
        {

            variables.quantity = Convert.ToInt32(quantity_txtbox.Text);
            variables.price = Convert.ToDouble(price_txtbox.Text);
        }

        // Function method for the formula needed in the program's computations 

        //Function with a return value for the item name and price textboxes
        private void price_item_TextValue(string itemname, string price)
        {
            itemname_txtbox.Text = itemname;
            price_txtbox.Text = price;
        }


        private void Activity3_Load(object sender, EventArgs e)
        {
            int qty = 0;
            double discount_total = 0;
            double discounted_total = 0;
        }


        // codes for disabling the textboxes
        private void Activity4_Load(object sender, EventArgs e)
        {
            itemname_txtbox.Enabled = false;
            quantity_txtbox.Enabled = false;
            price_txtbox.Enabled = false;
            disc_ammount_txtbox.Enabled = false;
            Disct_ammount_txtbox.Enabled = false;
            total_quantity_txtbox.Enabled = false;
            discount_total_txtbox.Enabled = false;
            discounted_total_txtbox.Enabled = false;



            //codes for inserting picture or images inside the picture boxes tool
            pictureBox20.Image = Image.FromFile("C:\\Users\\mjbea\\OneDrive\\Pictures\\ScreenshotsScreenshot 2026-01-30 184401");
            pictureBox19.Image = Image.FromFile("C:\\Users\\mjbea\\OneDrive\\Pictures\\ScreenshotsScreenshot 2026-01-30 184324");
            pictureBox18.Image = Image.FromFile("C:\\Users\\mjbea\\OneDrive\\Pictures\\ScreenshotsScreenshot 2026-01-30 184222");
            pictureBox17.Image = Image.FromFile("C: \\Users\\mjbea\\OneDrive\\Pictures\\Screenshots Screenshot 2026 - 01 - 30 184130");
            pictureBox16.Image = Image.FromFile("C: \\Users\\mjbea\\OneDrive\\Pictures\\ScreenshotsScreenshot 2026 - 01 - 30 191720");


            //codes for inserting name of the image inside the label tool
            name1lbl.Text = "Combo meal A";
            name2lbl.Text = "Combo meal B";
            name3lbl.Text = "Combo meal C";
            name4lbl.Text = "Combo meal D";
            name5lbl.Text = "Combo meal E";
            name6lbl.Text = "Combo meal F";
            name7lbl.Text = "Combo meal G";
            name8lbl.Text = "Combo meal H";
            name9lbl.Text = "Combo meal I";
            name10lbl.Text = "Combo meal J";
            name11lbl.Text = "Combo meal K";
            name12lbl.Text = "Combo meal L";
            name13lbl.Text = "Combo meal M";
            name14lbl.Text = "Combo meal N";
            name15lbl.Text = "Combo meal O";
            name16lbl.Text = "Combo meal P";
            name17lbl.Text = "Combo meal Q";
            name18lbl.Text = "Combo meal R";
            name19lbl.Text = "Combo meal S";
            name20lbl.Text = "Combo meal T";

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0;

                computation_Formula_and_Display();

                RadioButton_SeniorCitezen.Checked = false;
                RadioButton_employeedisc.Checked = false;
                RadioButton_withdisccard.Checked = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTextbox();
            }


            /*
              try
            {

                int qty;
                double price, discount_amt, discounted_amt;
                //converting string data from textboxes to numeric and place it as value of the variable
                qty = Convert.ToInt32(quantity_txtbox.Text);
                price = Convert.ToDouble(price_txtbox.Text);
                //create a formula needed for computation
                discount_amt = (price * price) * 0;
                discounted_amt = (qty * price) - discount_amt;
                //converting numeric data to string and display it inside the textboxes
                disc_ammount_txtbox.Text = discount_amt.ToString("n");
                Disct_ammount_txtbox.Text = discounted_amt.ToString("n");
                //codes for unchecking the other radio buttons in the interface once no method executed
                RadioButton_SeniorCitezen.Checked = false;
                RadioButton_withdisccard.Checked = false;
                RadioButton_employeedisc.Checked = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantity_txtbox.Clear();
                quantity_txtbox.Focus();
            }
            */
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


            try

            {
                quantity_price_Convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0.30;

                computation_Formula_and_Display();

                RadioButton_SeniorCitezen.Checked = false;
                RadioButton_withdisccard.Checked = false;
                RadioButton_employeedisc.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");

                // access the function with methods for clearing the quantity textbox and automatically placing the cursor inside the textbox
                quantityTextbox();
            }

        }

        /*  try
          {
              // DEclaration of variables within a method of an object
              int qty;
              double price, discount_amt, discounted_amt;

              // convert string data from textboxes to numeric and place it as value of the variable
              qty = Convert.ToInt32(qty_txtbox.Text);
              price = Convert.ToDouble(pricetxtbox.Text);

              //create a formula needed for a computation 
              discount_amt = (qty * price) * 0.30;
              discounted_amt = (qty * price) - discount_amt;

              //converting numeric data to string and display it inside the textboxes
              disc_ammounttxtbox.Text = discount_amt.ToString("n");
              Disct_ammounttxtbox.Text = discounted_amt.ToString("n");

              //codes for unchecking the radio buttons in the interface once the senior citizen method executed


              RadioButton2.Checked = false;
              RadioButton3.Checked = false;
              RadioButton4.Checked = false;
          }
          catch (Exception)
          {
              MessageBox.Show("Input is invalid");
              qty_txtbox.Clear();
              qty_txtbox.Focus();
          } 


      }
        */

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                quantity_price_Convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0.10;

                computation_Formula_and_Display();

                RadioButton_SeniorCitezen.Checked = false;
                RadioButton_employeedisc.Checked = false;
                RadioButton_nodisc.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTextbox();
            }
            /* try
             {


                 int qty;
                 double price, discount_amt, discounted_amt;
                 //convert string data from textboxes to numeric and place it as value of the variable
                 qty = Convert.ToInt32(quantity_txtbox.Text);
                 price = Convert.ToDouble(price_txtbox.Text);
                 //create a formula needed for computation
                 discount_amt = (qty * price) * 0.10;
                 discounted_amt = (qty * price) - discount_amt;
                 //converting numeric data to string and display it inside the textboxes
                 disc_ammount_txtbox.Text = discount_amt.ToString("n");
                 Disct_ammount_txtbox.Text = discounted_amt.ToString("n");
                 //codes for unchecking the other radio buttons in the interface once with disc. card method
                 RadioButton_SeniorCitezen.Checked = false;
                 RadioButton_employeedisc.Checked = false;
                 RadioButton_nodisc.Checked = false;
             }

             catch (Exception)
             {
                 MessageBox.Show("Input is invalid");
                 quantity_txtbox.Clear();
                 quantity_txtbox.Focus();
             }
            */
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                quantity_price_Convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0.30;

                computation_Formula_and_Display();

                RadioButton_SeniorCitezen.Checked = false;
                RadioButton_withdisccard.Checked = false;
                RadioButton_nodisc.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Input is invalid");
                quantityTextbox();
            }
            /* try
             {


                 //Declaration of variables within a method of an object
                 int qty;
                 double price, discount_amt, discounted_amt;
                 //convert string data from textboxes to numeric and place it as value of the variable 
                 qty = Convert.ToInt32(quantity_txtbox.Text);
                 price = Convert.ToDouble(price_txtbox.Text);
                 //create a formula needed for computation
                 discount_amt = (qty * price) * 0.15;
                 discounted_amt = (qty * price) - discount_amt;
                 //converting numeric data to string and display it inside the text boxes
                 disc_ammount_txtbox.Text = discount_amt.ToString("n");
                 Disct_ammount_txtbox.Text = discounted_amt.ToString("n");
                 // codes for unchecking the other radio buttons in the interface once employee disc. method is executed
                 RadioButton_SeniorCitezen.Checked = false;
                 RadioButton_withdisccard.Checked = false;
                 RadioButton_nodisc.Checked = false;
             }
             catch (Exception)
             {
                 MessageBox.Show("Input is invalid");
                 quantity_txtbox.Clear();
                 quantity_txtbox.Focus();
             }
               */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                variables.quantity = Convert.ToInt32(quantity_txtbox.Text);
                variables.discount_amt = Convert.ToDouble(disc_ammount_txtbox.Text);
                variables.discounted_amt = Convert.ToDouble(Disct_ammount_txtbox.Text);
                variables.cash_given = Convert.ToDouble(cash_rendered_txtbox.Text);

                variables.qty_total += variables.quantity;
                variables.discount_totalgiven += variables.discount_amt;
                variables.discounted_total += variables.discounted_amt;
                variables.change = variables.cash_given - variables.discounted_amt;

                total_quantity_txtbox.Text = variables.qty_total.ToString();
                discount_total_txtbox.Text = variables.discount_totalgiven.ToString("n");
                discounted_total_txtbox.Text = variables.discounted_total.ToString("n");
                change_txtbox.Text = variables.change.ToString("n");
                cash_rendered_txtbox.Text = variables.cash_given.ToString("n");


                //// declaration of variables with data types
                //int qty;
                //double discount_amt, discounted_amt, cash_rendered, change;
                //
                //
                //qty = Convert.ToInt32(quantity_txtbox.Text);
                //
                //
                //discount_amt = Convert.ToDouble(disc_ammount_txtbox.Text);
                //discounted_amt = Convert.ToDouble(Disct_ammount_txtbox.Text);
                //cash_rendered = Convert.ToDouble(cash_rendered_txtbox.Text);
                //
                ////codes to accumulate the value of the quantity, discount given and discounted amount from one transaction to another 
                //int qty_total = qty;
                //double discount_total = discount_amt;
                //double discounted_total = discounted_amt;
                //change = cash_rendered - discounted_amt;
                //// converting string data from textboxes to numeric and place it as value of the variable
                //total_quantity_txtbox.Text = qty_total.ToString();
                //discount_total_txtbox.Text = discount_total.ToString("n");
                //discounted_total_txtbox.Text = discounted_total.ToString("n");
                //change_txtbox.Text = change.ToString("n");
                //cash_rendered_txtbox.Text = cash_rendered.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Make Sure cash given textbox is not empty invalid");
                cash_rendered_txtbox.Clear();
                cash_rendered_txtbox.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // codes for closing the form application once three button is clicked
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // codes for clearing specific pointed textbox
            itemname_txtbox.Clear();
            price_txtbox.Clear();
            quantity_txtbox.Clear();
            disc_ammount_txtbox.Clear();
            Disct_ammount_txtbox.Clear();
            change_txtbox.Clear();
            cash_rendered_txtbox.Clear();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //codes for inserting value text property from text box (item name and price)
            //Accessing a function with an assigned return value for the text property of the price and items name textboxes
            price_item_values.SetPriceItemValue("6 pc Chickenjoy", "89.50");

            /*  itemnametxtbox.Text = "6 pc Chickenjoy";
            pricetxtbox.Text = "89.50";*/
            //Accessing a function with methods for clearing the quantity textbox and automatically placing the cursor inside it 

            /*qty_txtbox.Clear();
            qty_txtbox.Focus();*/

            GetPriceItemValue();
            quantityTextbox();



            //codes for inserting value text property from text box (item name and price}



            // itemnametxtbox.Text = "6 pc Chickenjoy";
            // pricetxtbox.Text = "89.50";


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            price_item_values.SetPriceItemValue("4 pc Chickenjoy", "101.50");
            GetPriceItemValue();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {


            price_item_values.SetPriceItemValue("6 pc Chk J w/ Plb Fm", "100.50");
            quantityTextbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_values.SetPriceItemValue("6 pc Chk J w/ Spg Fm", "111.50");
            quantityTextbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_values.SetPriceItemValue("Family Meal", "120.50");
            quantityTextbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_values.SetPriceItemValue("Spg + Plb", "90.50");
            quantityTextbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_values.SetPriceItemValue("Chc Sundae", "101.50");
            quantityTextbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_values.SetPriceItemValue("Dbl Chs Brg", "123.50");
            quantityTextbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_values.SetPriceItemValue("Ic Cff", "188.00");
            quantityTextbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_values.SetPriceItemValue("Cggt Combo", "680.50");
            quantityTextbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_values.SetPriceItemValue("Kiddie Meal", "199.50");
            quantityTextbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_values.SetPriceItemValue("BF Sausage", "99.00");
            quantityTextbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_values.SetPriceItemValue("BF Tapa", "190.50");
            quantityTextbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_values.SetPriceItemValue("BF chicken", "121.50");
            quantityTextbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_values.SetPriceItemValue("BF Sandwich", "599.50");
            quantityTextbox();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_values.SetPriceItemValue("Chs Brg", "91.50");
            quantityTextbox();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_values.SetPriceItemValue("3 Chs Brg", "81.50");
            quantityTextbox();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_values.SetPriceItemValue("3 Ym Brg", "71.50");
            quantityTextbox();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_values.SetPriceItemValue("Ym Brg", "211.50");
            quantityTextbox();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_values.SetPriceItemValue("Chmp Brg", "576.50");
            quantityTextbox();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}


