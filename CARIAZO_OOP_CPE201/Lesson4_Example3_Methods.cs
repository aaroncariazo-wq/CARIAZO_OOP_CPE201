using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CARIAZO_OOP_CPE201
{
    public partial class Lesson4_Example3_Methods : Form
    {
        //code for declaring a variables that is acessible to the whole form and can be access for one object to another 

        private double total_amount = 0;
        private int total_qty = 0;

        int qty = 0;
        double price = 0;
        double discounted_amount = 0;
        double discount_amount = 0;






        public Lesson4_Example3_Methods()
        {
            InitializeComponent();
        }

        private void item_priceValue(string discount, string price)
        {
            Txtbox_Discount_Amount.Text = discount;
            Txtbox_Price.Text = price;
        }
        //function codes for clearing and  placing the curso inside the quantity textbox
        private void quantityTxtbox()
        {
            Txtbox_Quantity.Clear();
            Txtbox_Quantity.Focus();
        }

        /*
        private void quantity_price_convert()
        {
            qty = Convert.ToInt32(Txtbox_Quantity.Text);
            price = Convert.ToInt32(Txtbox_Price.Text);

        }

        private void computation_formula_and_displaydata()
        {

            discounted_amount = (qty * price) - discount_amount;
            Txtbox_Discount_Amount.Text = discount_amount.ToString();
            Txtbox_Discounted_Amount.Text = discounted_amount .ToString();

        }

        public void price_item_textvalue(string itemname, string price)
        {
            Txt

        }
        */


        private void Activity5_Load(object sender, EventArgs e)
        {
            //disabling textboxes
            Txtbox_Price.Enabled = false;
            Txtbox_Discounted_Amount.Enabled = false;
            Txtbox_Change.Enabled = false;
            Txtbox_Total_Bills.Enabled = false;
            Txtbox_Discount_Amount.Enabled = false;
            Txtbox_Total_Quantity.Enabled = false;


            //images


            //disabling checkboxes
            Checkbox_A_10pcsDFC.Enabled = false;
            Checkbox_A_2LargeFries.Enabled = false;
            Checkbox_A_15Coke.Enabled = false;
            Checkbox_A_4SideDishes.Enabled = false;
            Checkbox_A_SPD.Enabled = false;

            Checkbox_B_4CupsHaloHalo.Enabled = false;
            Checkbox_B_6pcsDFC.Enabled = false;
            Checkbox_B_FampackFries.Enabled = false;
            Checkbox_B_FPC.Enabled = false;
            Checkbox_B_MediumHawaiPizza.Enabled = false;

        }

        private void Radio_Button_A_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            // code for changing  the form background 
            this.BackColor = Color.LightCyan;
            // code for food bundle B not being selected 
            Radio_Button_B.Checked = false;
            // inserting image inside the picturebox
            // Picturebox_Display.Image = Image.FromFile()

            //codes to check the checkboxes
            Checkbox_A_10pcsDFC.Checked = true;
            Checkbox_A_15Coke.Checked = true;
            Checkbox_A_2LargeFries.Checked = true;
            Checkbox_A_4SideDishes.Checked = true;
            Checkbox_A_SPD.Checked = true;

            Checkbox_B_4CupsHaloHalo.Checked = false;
            Checkbox_B_6pcsDFC.Checked = false;
            Checkbox_B_FampackFries.Checked = false;
            Checkbox_B_FPC.Checked = false;
            Checkbox_B_MediumHawaiPizza.Checked = false;

            //codes for displaying data inside the text boxes
            Txtbox_Price.Text = "1,000.00";
            Txtbox_Discount_Amount.Text = "200.00";

            // price = Convert.ToDouble(Txtbox_Price);
            //codes for inserting data inside the listbox
            Listbox_Display.Items.Add(Radio_Button_B.Text + "" + Txtbox_Price.Text);
            Listbox_Display.Items.Add("    Discount Ammount: " + "  " + Txtbox_Discount_Amount.Text);
            Txtbox_Quantity.Text = "0";
            Txtbox_Quantity.Focus();

        }

        private void Radio_Button_B_CheckedChanged(object sender, EventArgs e)
        {

            this.BackColor = Color.LightCyan;

            Radio_Button_A.Checked = false;

            //Picturebox_Display.Image = Image.FromFile()



            Checkbox_A_10pcsDFC.Checked = false;
            Checkbox_A_15Coke.Checked = false;
            Checkbox_A_2LargeFries.Checked = false;
            Checkbox_A_4SideDishes.Checked = false;
            Checkbox_A_SPD.Checked = false;

            Checkbox_B_4CupsHaloHalo.Checked = true;
            Checkbox_B_6pcsDFC.Checked = true;
            Checkbox_B_FampackFries.Checked = true;
            Checkbox_B_FPC.Checked = true;
            Checkbox_B_MediumHawaiPizza.Checked = true;


            Txtbox_Price.Text = "1,299.00";
            Txtbox_Discount_Amount.Text = "(15% of the price) 194,85";

            Listbox_Display.Items.Add(Radio_Button_A.Text);

        }

        private void Button_Calculate_Bills_Click(object sender, EventArgs e)
        {
            try
            {

                double Cash_Given, Change, Total_Amount_Paid;
                Cash_Given = Convert.ToDouble(Txtbox_Cash_Given.Text);
                Total_Amount_Paid = Convert.ToDouble(Txtbox_Total_Bills.Text);
                Change = Cash_Given - Total_Amount_Paid;
                Txtbox_Change.Text = Change.ToString("n");
                Listbox_Display.Items.Add("Total Bills: " + " " + Txtbox_Total_Bills.Text);
                Listbox_Display.Items.Add("Cash Given: " + " " + Txtbox_Cash_Given.Text);
                Listbox_Display.Items.Add("Change: " + " " + Txtbox_Change.Text);
                Listbox_Display.Items.Add("Total No. of Items: " + " " + Txtbox_Total_Quantity.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid data in cash given textbox!");
                Txtbox_Cash_Given.Clear();
                Txtbox_Cash_Given.Focus();
            }
        }

        private void Button_Print_Transaction_Click(object sender, EventArgs e)
        {
            // codes for calling the other form connected to the current form

            //Activity5_PrintFrm print1 = new Activity5_PrintFrm();

            //Lesson2_example3_printfrm print = new lesson2_example3_printftm();


            // codes for displauing the contents of the listbox from other form to the current form
            // modifier = internal


            //print1.PrintDisplayListbox.Items.AddRange(this.Listbox_Display.Items);



            // codes to remove selected data inside the listbox
            // Listbox_Display.Items.RemoveAt(Listbox_Display.SelectedIndex);
            //print1.ShowDialog();
        }

        private void Button_Remove_Order_Click(object sender, EventArgs e)
        {


        }

        private void Button_New_Click(object sender, EventArgs e)
        {
            // codes to uncheck all given checkboxes

            Radio_Button_A.Checked = false;
            Radio_Button_B.Checked = false;

            // codes for inserting default image inside the picturebox
            // Picturebox_Display.Image = Image.FromFile();

            Checkbox_A_10pcsDFC.Checked = false;
            Checkbox_A_15Coke.Checked = false;
            Checkbox_A_2LargeFries.Checked = false;
            Checkbox_A_4SideDishes.Checked = false;
            Checkbox_A_SPD.Checked = false;

            Checkbox_B_4CupsHaloHalo.Checked = false;
            Checkbox_B_6pcsDFC.Checked = false;
            Checkbox_B_FampackFries.Checked = false;
            Checkbox_B_FPC.Checked = false;
            Checkbox_B_MediumHawaiPizza.Checked = false;

            // codes for checking the textboxes
            Txtbox_Price.Clear();
            Txtbox_Quantity.Clear();
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
            checkBox28.Checked = false;
            checkBox29.Checked = false;
            checkBox30.Checked = false;

            //removing the contents of a listbox

            Listbox_Display.Items.Clear();




        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txtbox_Quantity_TextChanged(object sender, EventArgs e)
        {
            try
            {


                double Price, Discounted_Amount, Discount_Amount;
                int qty;

                Price = Convert.ToDouble(Txtbox_Price.Text);
                qty = Convert.ToInt32(Txtbox_Quantity.Text);
                Discount_Amount = Convert.ToDouble(Txtbox_Discount_Amount.Text);
                Discounted_Amount = (Price * qty) - Discount_Amount;
                total_qty += qty;
                Txtbox_Total_Quantity.Text = total_qty.ToString();
                total_amount += Discounted_Amount;
                Txtbox_Total_Bills.Text = total_amount.ToString();
                Txtbox_Discounted_Amount.Text = Discounted_Amount.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter number of quantity ordered!");
                Txtbox_Cash_Given.Focus();
            }

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {


            // codes to declare a variable with a specific  data type
            // double Price;
            // codes for putting text property with specific value for the textbox
            //Txtbox_Discount_Amount.Text = "0.00";
            //Txtbox_Price.Text = "509.99";
            // codes to convert string data inside the textbox to numeric data to store inside the variable
            //Price = Convert.ToDouble(Txtbox_Price.Text);
            // codes to insert text property value of a checkbox inside the listbox
            // Listbox_Display.Items.Add(checkBox11.Text + "" + Txtbox_Price.Text);
            // codes for putting text property value if the textbox
            //Txtbox_Quantity.Text = "0";
            //codes for the cursor inside the textbox once the event if the object triggered
            //Txtbox_Quantity.Focus();

            //DiscountAmmountTextbox.Text = "0.00";
            //PriceTextbox.Text = "500.99";
            //price = Convert.ToDouble(PriceTextbox.Text);
            //calling a function with assigned values for items name and price inside the parameters

            item_priceValue("0.00", "500.99");
            Listbox_Display.Items.Add(Checkbox_A_10pcsDFC.Text + "" + Txtbox_Price.Text);
            quantityTxtbox();


        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "550.00");
            quantityTxtbox();
            //  double Price;
            //  Txtbox_Price.Text = "550.00";
            //  Txtbox_Discount_Amount.Text = "0.00";
            //  Price = Convert.ToDouble(Txtbox_Price.Text);
            //  Listbox_Display.Items.Add(checkBox12.Text + "" + Txtbox_Price.Text);
            // Txtbox_Quantity.Text = "0";
            // Txtbox_Quantity.Focus();
        }


        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "600.99");
            quantityTxtbox();
            //double Price;
            //Txtbox_Price.Text = "600.99";
            //Txtbox_Discount_Amount.Text = "0.00";
            //Price = Convert.ToDouble(Txtbox_Price.Text);
            //Listbox_Display.Items.Add(checkBox13.Text + "" + Txtbox_Price.Text);
            //Txtbox_Quantity.Text = "0";
            //Txtbox_Quantity.Focus();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

            item_priceValue("0.00", "700.50");
            quantityTxtbox();
            // double Price;
            // Txtbox_Price.Text = "700.50";
            // Txtbox_Discount_Amount.Text = "0.00";
            // Price = Convert.ToDouble(Txtbox_Price.Text);
            // Listbox_Display.Items.Add(checkBox14.Text + "" + Txtbox_Price.Text);
            // Txtbox_Quantity.Text = "0";
            // Txtbox_Quantity.Focus();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "500.00");
            quantityTxtbox();

            // double Price;
            // Txtbox_Price.Text = "500.00";
            // Txtbox_Discount_Amount.Text = "0.00";
            // Price = Convert.ToDouble(Txtbox_Price.Text);
            // Listbox_Display.Items.Add(checkBox15.Text + "" + Txtbox_Price.Text);
            // Txtbox_Quantity.Text = "0";
            // Txtbox_Quantity.Focus();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "750.00");
            quantityTxtbox();
            // double Price;
            // Txtbox_Price.Text = "750.00";
            // Txtbox_Discount_Amount.Text = "0.00";
            // Price = Convert.ToDouble(Txtbox_Price.Text);
            // Listbox_Display.Items.Add(checkBox16.Text + "" + Txtbox_Price.Text);
            // Txtbox_Quantity.Text = "0";
            // Txtbox_Quantity.Focus();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "700.00");
            quantityTxtbox();
            // double Price;
            // Txtbox_Price.Text = "700.00";
            // Txtbox_Discount_Amount.Text = "0.00";
            // Price = Convert.ToDouble(Txtbox_Price.Text);
            // Listbox_Display.Items.Add(checkBox17.Text + "" + Txtbox_Price.Text);
            // Txtbox_Quantity.Text = "0";
            // Txtbox_Quantity.Focus();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {

            item_priceValue("0.00", "850.00");
            quantityTxtbox();
            //double Price;
            //Txtbox_Price.Text = "850.00";
            //Txtbox_Discount_Amount.Text = "0.00";
            //Price = Convert.ToDouble(Txtbox_Price.Text);
            //Listbox_Display.Items.Add(checkBox18.Text + "" + Txtbox_Price.Text);
            //Txtbox_Quantity.Text = "0";
            //Txtbox_Quantity.Focus();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "450.00");
            quantityTxtbox();

            // double Price;
            // Txtbox_Price.Text = "450.00";
            // Txtbox_Discount_Amount.Text = "0.00";
            // Price = Convert.ToDouble(Txtbox_Price.Text);
            // Listbox_Display.Items.Add(checkBox19.Text + "" + Txtbox_Price.Text);
            // Txtbox_Quantity.Text = "0";
            // Txtbox_Quantity.Focus();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

            item_priceValue("0.00", "650.00");
            quantityTxtbox();

            //double Price;
            //Txtbox_Price.Text = "650.00";
            //Txtbox_Discount_Amount.Text = "0.00";
            //Price = Convert.ToDouble(Txtbox_Price.Text);
            //Listbox_Display.Items.Add(checkBox20.Text + "" + Txtbox_Price.Text);
            //Txtbox_Quantity.Text = "0";
            //Txtbox_Quantity.Focus();
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575.00");
            quantityTxtbox();
            //  double Price;
            //  Txtbox_Price.Text = "575.00";
            //  Txtbox_Discount_Amount.Text = "0.00";
            //  Price = Convert.ToDouble(Txtbox_Price.Text);
            //  Listbox_Display.Items.Add(checkBox21.Text + "" + Txtbox_Price.Text);
            //  Txtbox_Quantity.Text = "0";
            //  Txtbox_Quantity.Focus();
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {

            item_priceValue("0.00", "575.00");
            quantityTxtbox();

            // double Price;
            // Txtbox_Price.Text = "575.00";
            // Txtbox_Discount_Amount.Text = "0.00";
            // Price = Convert.ToDouble(Txtbox_Price.Text);
            // Listbox_Display.Items.Add(checkBox22.Text + "" + Txtbox_Price.Text);
            // Txtbox_Quantity.Text = "0";
            // Txtbox_Quantity.Focus();
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {

            item_priceValue("0.00", "575.00");
            quantityTxtbox();
            //double Price;
            //Txtbox_Price.Text = "575.00";
            //Txtbox_Discount_Amount.Text = "0.00";
            //Price = Convert.ToDouble(Txtbox_Price.Text);
            //Listbox_Display.Items.Add(checkBox23.Text + "" + Txtbox_Price.Text);
            //Txtbox_Quantity.Text = "0";
            //Txtbox_Quantity.Focus();
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {

            item_priceValue("0.00", "575.00");
            quantityTxtbox();
            // double Price;
            // Txtbox_Price.Text = "575.00";
            // Txtbox_Discount_Amount.Text = "0.00";
            // Price = Convert.ToDouble(Txtbox_Price.Text);
            // Listbox_Display.Items.Add(checkBox24.Text + "" + Txtbox_Price.Text);
            // Txtbox_Quantity.Text = "0";
            // Txtbox_Quantity.Focus();
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575.00");
            quantityTxtbox();
            // double Price;
            // Txtbox_Price.Text = "575.00";
            // Txtbox_Discount_Amount.Text = "0.00";
            // Price = Convert.ToDouble(Txtbox_Price.Text);
            // Listbox_Display.Items.Add(checkBox25.Text + "" + Txtbox_Price.Text);
            // Txtbox_Quantity.Text = "0";
            // Txtbox_Quantity.Focus();
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575.00");
            quantityTxtbox();
            // double Price;
            // Txtbox_Price.Text = "575.00";
            // Txtbox_Discount_Amount.Text = "0.00";
            // Price = Convert.ToDouble(Txtbox_Price.Text);
            // Listbox_Display.Items.Add(checkBox26.Text + "" + Txtbox_Price.Text);
            // Txtbox_Quantity.Text = "0";
            // Txtbox_Quantity.Focus();
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {

            item_priceValue("0.00", "575.00");
            quantityTxtbox();
            // double Price;
            // Txtbox_Price.Text = "575.00";
            // Txtbox_Discount_Amount.Text = "0.00";
            // Price = Convert.ToDouble(Txtbox_Price.Text);
            // Listbox_Display.Items.Add(checkBox27.Text + "" + Txtbox_Price.Text);
            // Txtbox_Quantity.Text = "0";
            // Txtbox_Quantity.Focus();
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575.00");
            quantityTxtbox();
            //double Price;
            //Txtbox_Price.Text = "575.00";
            //Txtbox_Discount_Amount.Text = "0.00";
            //Price = Convert.ToDouble(Txtbox_Price.Text);
            //Listbox_Display.Items.Add(checkBox28.Text + "" + Txtbox_Price.Text);
            //Txtbox_Quantity.Text = "0";
            //Txtbox_Quantity.Focus();
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575.00");
            quantityTxtbox();

            //double Price;
            //Txtbox_Price.Text = "575.00";
            //Txtbox_Discount_Amount.Text = "0.00";
            //Price = Convert.ToDouble(Txtbox_Price.Text);
            //Listbox_Display.Items.Add(checkBox29.Text + "" + Txtbox_Price.Text);
            //Txtbox_Quantity.Text = "0";
            //Txtbox_Quantity.Focus();
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "575.00");
            quantityTxtbox();

            // double Price;
            // Txtbox_Price.Text = "575.00";
            // Txtbox_Discount_Amount.Text = "0.00";
            // Price = Convert.ToDouble(Txtbox_Price.Text);
            // Listbox_Display.Items.Add(checkBox30.Text + "" + Txtbox_Price.Text);
            // Txtbox_Quantity.Text = "0";
            // Txtbox_Quantity.Focus();
        }

        private void Checkbox_A_10pcsDFC_CheckedChanged(object sender, EventArgs e)
        {
            //DiscountAmmountTextbox.Text = "0.00";
            //PriceTextbox.Text = "500.99";
            //price = Convert.ToDouble(PriceTextbox.Text);
            //calling a function with assigned values for items name and price inside the parameters

            //   item_priceValue ("0.00" , "500.99");
            //   Listbox_Display.Items.Add(Checkbox_A_10pcsDFC.Text + "" + Txtbox_Price.Text);
            //   quantityTxtbox();
        }

        private void Checkbox_A_2LargeFries_CheckedChanged(object sender, EventArgs e)
        {
            // 
            //  item_priceValue("0.00", "550.00");
            //  quantityTxtbox();
        }
    }
}
