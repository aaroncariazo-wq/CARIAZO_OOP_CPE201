using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CARIAZO_OOP_CPE201
{
    partial class Lesson4_Example3_Methods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Radio_Button_A = new RadioButton();
            Radio_Button_B = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            Listbox_Display = new ListBox();
            Picturebox_Display = new PictureBox();
            pictureBox20 = new PictureBox();
            pictureBox19 = new PictureBox();
            pictureBox18 = new PictureBox();
            pictureBox17 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox21 = new PictureBox();
            Checkbox_A_10pcsDFC = new CheckBox();
            Checkbox_A_2LargeFries = new CheckBox();
            Checkbox_A_15Coke = new CheckBox();
            Checkbox_A_4SideDishes = new CheckBox();
            Checkbox_A_SPD = new CheckBox();
            Checkbox_B_4CupsHaloHalo = new CheckBox();
            Checkbox_B_6pcsDFC = new CheckBox();
            Checkbox_B_FPC = new CheckBox();
            Checkbox_B_FampackFries = new CheckBox();
            Checkbox_B_MediumHawaiPizza = new CheckBox();
            Txtbox_Price = new TextBox();
            Txtbox_Quantity = new TextBox();
            Txtbox_Discount_Amount = new TextBox();
            Txtbox_Discounted_Amount = new TextBox();
            Txtbox_Total_Bills = new TextBox();
            Txtbox_Total_Quantity = new TextBox();
            Txtbox_Cash_Given = new TextBox();
            Txtbox_Change = new TextBox();
            label13 = new Label();
            label14 = new Label();
            Button_Calculate_Bills = new Button();
            Button_Print_Transaction = new Button();
            Button_Remove_Order = new Button();
            Button_New = new Button();
            Button_Exit = new Button();
            label15 = new Label();
            checkBox11 = new CheckBox();
            checkBox12 = new CheckBox();
            checkBox13 = new CheckBox();
            checkBox14 = new CheckBox();
            checkBox15 = new CheckBox();
            checkBox16 = new CheckBox();
            checkBox17 = new CheckBox();
            checkBox18 = new CheckBox();
            checkBox19 = new CheckBox();
            checkBox20 = new CheckBox();
            checkBox21 = new CheckBox();
            checkBox22 = new CheckBox();
            checkBox23 = new CheckBox();
            checkBox24 = new CheckBox();
            checkBox25 = new CheckBox();
            checkBox26 = new CheckBox();
            checkBox27 = new CheckBox();
            checkBox28 = new CheckBox();
            checkBox29 = new CheckBox();
            checkBox30 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)Picturebox_Display).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 93);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Food Choices";
            // 
            // Radio_Button_A
            // 
            Radio_Button_A.AutoSize = true;
            Radio_Button_A.Location = new Point(31, 132);
            Radio_Button_A.Name = "Radio_Button_A";
            Radio_Button_A.Size = new Size(128, 24);
            Radio_Button_A.TabIndex = 1;
            Radio_Button_A.TabStop = true;
            Radio_Button_A.Text = "Food Bundle A";
            Radio_Button_A.UseVisualStyleBackColor = true;
            Radio_Button_A.CheckedChanged += Radio_Button_A_CheckedChanged;
            // 
            // Radio_Button_B
            // 
            Radio_Button_B.AutoSize = true;
            Radio_Button_B.Location = new Point(31, 162);
            Radio_Button_B.Name = "Radio_Button_B";
            Radio_Button_B.Size = new Size(127, 24);
            Radio_Button_B.TabIndex = 2;
            Radio_Button_B.TabStop = true;
            Radio_Button_B.Text = "Food Bundle B";
            Radio_Button_B.UseVisualStyleBackColor = true;
            Radio_Button_B.CheckedChanged += Radio_Button_B_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 202);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 3;
            label2.Text = "Order Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 235);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 4;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 268);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 5;
            label4.Text = "Quantity:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 301);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 6;
            label5.Text = "Discount Amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 335);
            label6.Name = "label6";
            label6.Size = new Size(137, 20);
            label6.TabIndex = 7;
            label6.Text = "Disounted Amount:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 368);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 8;
            label7.Text = "Total Bills:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 400);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 9;
            label8.Text = "Total Quantity:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 434);
            label9.Name = "label9";
            label9.Size = new Size(84, 20);
            label9.TabIndex = 10;
            label9.Text = "Cash Given:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(31, 467);
            label10.Name = "label10";
            label10.Size = new Size(62, 20);
            label10.TabIndex = 11;
            label10.Text = "Change:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(346, 122);
            label11.Name = "label11";
            label11.Size = new Size(107, 20);
            label11.TabIndex = 12;
            label11.Text = "Food Bundle A";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(346, 334);
            label12.Name = "label12";
            label12.Size = new Size(106, 20);
            label12.TabIndex = 13;
            label12.Text = "Food Bundle B";
            // 
            // Listbox_Display
            // 
            Listbox_Display.FormattingEnabled = true;
            Listbox_Display.Location = new Point(16, 531);
            Listbox_Display.Name = "Listbox_Display";
            Listbox_Display.Size = new Size(290, 244);
            Listbox_Display.TabIndex = 14;
            // 
            // Picturebox_Display
            // 
            Picturebox_Display.Location = new Point(334, 531);
            Picturebox_Display.Name = "Picturebox_Display";
            Picturebox_Display.Size = new Size(226, 216);
            Picturebox_Display.TabIndex = 15;
            Picturebox_Display.TabStop = false;
            // 
            // pictureBox20
            // 
            pictureBox20.BorderStyle = BorderStyle.Fixed3D;
            pictureBox20.InitialImage = null;
            pictureBox20.Location = new Point(1206, 573);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(122, 82);
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox20.TabIndex = 54;
            pictureBox20.TabStop = false;
            // 
            // pictureBox19
            // 
            pictureBox19.BorderStyle = BorderStyle.Fixed3D;
            pictureBox19.InitialImage = null;
            pictureBox19.Location = new Point(1060, 573);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(122, 82);
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox19.TabIndex = 53;
            pictureBox19.TabStop = false;
            // 
            // pictureBox18
            // 
            pictureBox18.BorderStyle = BorderStyle.Fixed3D;
            pictureBox18.InitialImage = null;
            pictureBox18.Location = new Point(917, 573);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(122, 82);
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox18.TabIndex = 52;
            pictureBox18.TabStop = false;
            // 
            // pictureBox17
            // 
            pictureBox17.BorderStyle = BorderStyle.Fixed3D;
            pictureBox17.InitialImage = null;
            pictureBox17.Location = new Point(774, 573);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(122, 82);
            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox17.TabIndex = 51;
            pictureBox17.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.BorderStyle = BorderStyle.Fixed3D;
            pictureBox16.InitialImage = null;
            pictureBox16.Location = new Point(635, 573);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(122, 82);
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox16.TabIndex = 50;
            pictureBox16.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(633, 101);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 82);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(774, 101);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(122, 82);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 36;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Location = new Point(915, 101);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(122, 82);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 37;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Location = new Point(1058, 101);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(122, 82);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 38;
            pictureBox5.TabStop = false;
            // 
            // pictureBox15
            // 
            pictureBox15.BorderStyle = BorderStyle.Fixed3D;
            pictureBox15.Location = new Point(1206, 411);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(122, 82);
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox15.TabIndex = 49;
            pictureBox15.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            pictureBox6.Location = new Point(1206, 101);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(122, 82);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 39;
            pictureBox6.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.BorderStyle = BorderStyle.Fixed3D;
            pictureBox14.Location = new Point(1058, 411);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(122, 82);
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.TabIndex = 48;
            pictureBox14.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BorderStyle = BorderStyle.Fixed3D;
            pictureBox7.Location = new Point(633, 248);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(122, 82);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 40;
            pictureBox7.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BorderStyle = BorderStyle.Fixed3D;
            pictureBox13.Location = new Point(915, 411);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(122, 82);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 47;
            pictureBox13.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BorderStyle = BorderStyle.Fixed3D;
            pictureBox8.Location = new Point(774, 248);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(122, 82);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 41;
            pictureBox8.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.BorderStyle = BorderStyle.Fixed3D;
            pictureBox12.Location = new Point(774, 411);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(122, 82);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 46;
            pictureBox12.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BorderStyle = BorderStyle.Fixed3D;
            pictureBox9.Location = new Point(915, 248);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(122, 82);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 42;
            pictureBox9.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BorderStyle = BorderStyle.Fixed3D;
            pictureBox11.Location = new Point(633, 411);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(122, 82);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 45;
            pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BorderStyle = BorderStyle.Fixed3D;
            pictureBox10.Location = new Point(1058, 248);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(122, 82);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 43;
            pictureBox10.TabStop = false;
            // 
            // pictureBox21
            // 
            pictureBox21.BorderStyle = BorderStyle.Fixed3D;
            pictureBox21.Location = new Point(1206, 248);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(122, 82);
            pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox21.TabIndex = 44;
            pictureBox21.TabStop = false;
            // 
            // Checkbox_A_10pcsDFC
            // 
            Checkbox_A_10pcsDFC.AutoSize = true;
            Checkbox_A_10pcsDFC.Location = new Point(346, 148);
            Checkbox_A_10pcsDFC.Name = "Checkbox_A_10pcsDFC";
            Checkbox_A_10pcsDFC.Size = new Size(237, 24);
            Checkbox_A_10pcsDFC.TabIndex = 57;
            Checkbox_A_10pcsDFC.Text = "10 pcs. Deleicous Fried Chicken";
            Checkbox_A_10pcsDFC.UseVisualStyleBackColor = true;
            Checkbox_A_10pcsDFC.CheckedChanged += Checkbox_A_10pcsDFC_CheckedChanged;
            // 
            // Checkbox_A_2LargeFries
            // 
            Checkbox_A_2LargeFries.AutoSize = true;
            Checkbox_A_2LargeFries.Location = new Point(346, 174);
            Checkbox_A_2LargeFries.Name = "Checkbox_A_2LargeFries";
            Checkbox_A_2LargeFries.Size = new Size(114, 24);
            Checkbox_A_2LargeFries.TabIndex = 58;
            Checkbox_A_2LargeFries.Text = "2 Large Fries";
            Checkbox_A_2LargeFries.UseVisualStyleBackColor = true;
            Checkbox_A_2LargeFries.CheckedChanged += Checkbox_A_2LargeFries_CheckedChanged;
            // 
            // Checkbox_A_15Coke
            // 
            Checkbox_A_15Coke.AutoSize = true;
            Checkbox_A_15Coke.Location = new Point(346, 203);
            Checkbox_A_15Coke.Name = "Checkbox_A_15Coke";
            Checkbox_A_15Coke.Size = new Size(87, 24);
            Checkbox_A_15Coke.TabIndex = 59;
            Checkbox_A_15Coke.Text = "1.5 Coke";
            Checkbox_A_15Coke.UseVisualStyleBackColor = true;
            // 
            // Checkbox_A_4SideDishes
            // 
            Checkbox_A_4SideDishes.AutoSize = true;
            Checkbox_A_4SideDishes.Location = new Point(346, 233);
            Checkbox_A_4SideDishes.Name = "Checkbox_A_4SideDishes";
            Checkbox_A_4SideDishes.Size = new Size(119, 24);
            Checkbox_A_4SideDishes.TabIndex = 60;
            Checkbox_A_4SideDishes.Text = "4 Side Dishes";
            Checkbox_A_4SideDishes.UseVisualStyleBackColor = true;
            // 
            // Checkbox_A_SPD
            // 
            Checkbox_A_SPD.AutoSize = true;
            Checkbox_A_SPD.Location = new Point(346, 263);
            Checkbox_A_SPD.Name = "Checkbox_A_SPD";
            Checkbox_A_SPD.Size = new Size(176, 24);
            Checkbox_A_SPD.TabIndex = 61;
            Checkbox_A_SPD.Text = "Special Pizza Delights";
            Checkbox_A_SPD.UseVisualStyleBackColor = true;
            // 
            // Checkbox_B_4CupsHaloHalo
            // 
            Checkbox_B_4CupsHaloHalo.AutoSize = true;
            Checkbox_B_4CupsHaloHalo.Location = new Point(346, 357);
            Checkbox_B_4CupsHaloHalo.Name = "Checkbox_B_4CupsHaloHalo";
            Checkbox_B_4CupsHaloHalo.Size = new Size(252, 24);
            Checkbox_B_4CupsHaloHalo.TabIndex = 62;
            Checkbox_B_4CupsHaloHalo.Text = "4 cups Special Halo Halo Regular";
            Checkbox_B_4CupsHaloHalo.UseVisualStyleBackColor = true;
            // 
            // Checkbox_B_6pcsDFC
            // 
            Checkbox_B_6pcsDFC.AutoSize = true;
            Checkbox_B_6pcsDFC.Location = new Point(346, 381);
            Checkbox_B_6pcsDFC.Name = "Checkbox_B_6pcsDFC";
            Checkbox_B_6pcsDFC.Size = new Size(225, 24);
            Checkbox_B_6pcsDFC.TabIndex = 63;
            Checkbox_B_6pcsDFC.Text = "6 pcs. Delicious Fried Chicken";
            Checkbox_B_6pcsDFC.UseVisualStyleBackColor = true;
            // 
            // Checkbox_B_FPC
            // 
            Checkbox_B_FPC.AutoSize = true;
            Checkbox_B_FPC.Location = new Point(346, 411);
            Checkbox_B_FPC.Name = "Checkbox_B_FPC";
            Checkbox_B_FPC.Size = new Size(191, 24);
            Checkbox_B_FPC.TabIndex = 64;
            Checkbox_B_FPC.Text = "1 Family Pack Carbonara";
            Checkbox_B_FPC.UseVisualStyleBackColor = true;
            // 
            // Checkbox_B_FampackFries
            // 
            Checkbox_B_FampackFries.AutoSize = true;
            Checkbox_B_FampackFries.Location = new Point(346, 437);
            Checkbox_B_FampackFries.Name = "Checkbox_B_FampackFries";
            Checkbox_B_FampackFries.Size = new Size(152, 24);
            Checkbox_B_FampackFries.TabIndex = 65;
            Checkbox_B_FampackFries.Text = "1 Family Pack Fries";
            Checkbox_B_FampackFries.UseVisualStyleBackColor = true;
            // 
            // Checkbox_B_MediumHawaiPizza
            // 
            Checkbox_B_MediumHawaiPizza.AutoSize = true;
            Checkbox_B_MediumHawaiPizza.Location = new Point(346, 467);
            Checkbox_B_MediumHawaiPizza.Name = "Checkbox_B_MediumHawaiPizza";
            Checkbox_B_MediumHawaiPizza.Size = new Size(202, 24);
            Checkbox_B_MediumHawaiPizza.TabIndex = 66;
            Checkbox_B_MediumHawaiPizza.Text = "1 Medium Hawaiian Pizza";
            Checkbox_B_MediumHawaiPizza.UseVisualStyleBackColor = true;
            // 
            // Txtbox_Price
            // 
            Txtbox_Price.Location = new Point(174, 234);
            Txtbox_Price.Name = "Txtbox_Price";
            Txtbox_Price.Size = new Size(153, 27);
            Txtbox_Price.TabIndex = 67;
            // 
            // Txtbox_Quantity
            // 
            Txtbox_Quantity.Location = new Point(174, 267);
            Txtbox_Quantity.Name = "Txtbox_Quantity";
            Txtbox_Quantity.Size = new Size(153, 27);
            Txtbox_Quantity.TabIndex = 68;
            Txtbox_Quantity.TextChanged += Txtbox_Quantity_TextChanged;
            // 
            // Txtbox_Discount_Amount
            // 
            Txtbox_Discount_Amount.Location = new Point(174, 300);
            Txtbox_Discount_Amount.Name = "Txtbox_Discount_Amount";
            Txtbox_Discount_Amount.Size = new Size(153, 27);
            Txtbox_Discount_Amount.TabIndex = 69;
            // 
            // Txtbox_Discounted_Amount
            // 
            Txtbox_Discounted_Amount.Location = new Point(174, 334);
            Txtbox_Discounted_Amount.Name = "Txtbox_Discounted_Amount";
            Txtbox_Discounted_Amount.Size = new Size(153, 27);
            Txtbox_Discounted_Amount.TabIndex = 70;
            // 
            // Txtbox_Total_Bills
            // 
            Txtbox_Total_Bills.Location = new Point(174, 367);
            Txtbox_Total_Bills.Name = "Txtbox_Total_Bills";
            Txtbox_Total_Bills.Size = new Size(153, 27);
            Txtbox_Total_Bills.TabIndex = 71;
            // 
            // Txtbox_Total_Quantity
            // 
            Txtbox_Total_Quantity.Location = new Point(174, 400);
            Txtbox_Total_Quantity.Name = "Txtbox_Total_Quantity";
            Txtbox_Total_Quantity.Size = new Size(153, 27);
            Txtbox_Total_Quantity.TabIndex = 72;
            // 
            // Txtbox_Cash_Given
            // 
            Txtbox_Cash_Given.Location = new Point(173, 433);
            Txtbox_Cash_Given.Name = "Txtbox_Cash_Given";
            Txtbox_Cash_Given.Size = new Size(153, 27);
            Txtbox_Cash_Given.TabIndex = 73;
            // 
            // Txtbox_Change
            // 
            Txtbox_Change.Location = new Point(174, 466);
            Txtbox_Change.Name = "Txtbox_Change";
            Txtbox_Change.Size = new Size(153, 27);
            Txtbox_Change.TabIndex = 74;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(625, 68);
            label13.Name = "label13";
            label13.Size = new Size(113, 20);
            label13.TabIndex = 75;
            label13.Text = "PIZZA CHOICES";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(396, 750);
            label14.Name = "label14";
            label14.Size = new Size(96, 20);
            label14.TabIndex = 76;
            label14.Text = "Order Image:";
            // 
            // Button_Calculate_Bills
            // 
            Button_Calculate_Bills.Location = new Point(648, 731);
            Button_Calculate_Bills.Name = "Button_Calculate_Bills";
            Button_Calculate_Bills.Size = new Size(132, 44);
            Button_Calculate_Bills.TabIndex = 77;
            Button_Calculate_Bills.Text = "CALCULATE BILLS";
            Button_Calculate_Bills.UseVisualStyleBackColor = true;
            Button_Calculate_Bills.Click += Button_Calculate_Bills_Click;
            // 
            // Button_Print_Transaction
            // 
            Button_Print_Transaction.Location = new Point(786, 731);
            Button_Print_Transaction.Name = "Button_Print_Transaction";
            Button_Print_Transaction.Size = new Size(163, 44);
            Button_Print_Transaction.TabIndex = 78;
            Button_Print_Transaction.Text = "PRINT TRANSACTION";
            Button_Print_Transaction.UseVisualStyleBackColor = true;
            Button_Print_Transaction.Click += Button_Print_Transaction_Click;
            // 
            // Button_Remove_Order
            // 
            Button_Remove_Order.Location = new Point(955, 731);
            Button_Remove_Order.Name = "Button_Remove_Order";
            Button_Remove_Order.Size = new Size(132, 44);
            Button_Remove_Order.TabIndex = 79;
            Button_Remove_Order.Text = "REMOVE ORDER";
            Button_Remove_Order.UseVisualStyleBackColor = true;
            Button_Remove_Order.Click += Button_Remove_Order_Click;
            // 
            // Button_New
            // 
            Button_New.Location = new Point(1093, 731);
            Button_New.Name = "Button_New";
            Button_New.Size = new Size(107, 44);
            Button_New.TabIndex = 80;
            Button_New.Text = "NEW";
            Button_New.UseVisualStyleBackColor = true;
            Button_New.Click += Button_New_Click;
            // 
            // Button_Exit
            // 
            Button_Exit.Location = new Point(1206, 731);
            Button_Exit.Name = "Button_Exit";
            Button_Exit.Size = new Size(107, 44);
            Button_Exit.TabIndex = 81;
            Button_Exit.Text = "EXIT";
            Button_Exit.UseVisualStyleBackColor = true;
            Button_Exit.Click += Button_Exit_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(75, 22);
            label15.Name = "label15";
            label15.Size = new Size(252, 20);
            label15.TabIndex = 82;
            label15.Text = "4JEE FOOD ORDERING APPLICATION";
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(633, 189);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(93, 24);
            checkBox11.TabIndex = 83;
            checkBox11.Text = "Hawaiian";
            checkBox11.UseVisualStyleBackColor = true;
            checkBox11.CheckedChanged += checkBox11_CheckedChanged;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(775, 189);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(129, 24);
            checkBox12.TabIndex = 84;
            checkBox12.Text = "New York Style";
            checkBox12.UseVisualStyleBackColor = true;
            checkBox12.CheckedChanged += checkBox12_CheckedChanged;
            // 
            // checkBox13
            // 
            checkBox13.AutoSize = true;
            checkBox13.Location = new Point(917, 189);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(98, 24);
            checkBox13.TabIndex = 85;
            checkBox13.Text = "Pepperoni";
            checkBox13.UseVisualStyleBackColor = true;
            checkBox13.CheckedChanged += checkBox13_CheckedChanged;
            // 
            // checkBox14
            // 
            checkBox14.AutoSize = true;
            checkBox14.Location = new Point(1060, 189);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(143, 24);
            checkBox14.TabIndex = 86;
            checkBox14.Text = "Cauliflower Crust";
            checkBox14.UseVisualStyleBackColor = true;
            checkBox14.CheckedChanged += checkBox14_CheckedChanged;
            // 
            // checkBox15
            // 
            checkBox15.AutoSize = true;
            checkBox15.Location = new Point(1206, 189);
            checkBox15.Name = "checkBox15";
            checkBox15.Size = new Size(85, 24);
            checkBox15.TabIndex = 87;
            checkBox15.Text = "Domino";
            checkBox15.UseVisualStyleBackColor = true;
            checkBox15.CheckedChanged += checkBox15_CheckedChanged;
            // 
            // checkBox16
            // 
            checkBox16.AutoSize = true;
            checkBox16.Location = new Point(635, 337);
            checkBox16.Name = "checkBox16";
            checkBox16.Size = new Size(135, 24);
            checkBox16.TabIndex = 88;
            checkBox16.Text = "Pizza Special A ";
            checkBox16.UseVisualStyleBackColor = true;
            checkBox16.CheckedChanged += checkBox16_CheckedChanged;
            // 
            // checkBox17
            // 
            checkBox17.AutoSize = true;
            checkBox17.Location = new Point(775, 336);
            checkBox17.Name = "checkBox17";
            checkBox17.Size = new Size(130, 24);
            checkBox17.TabIndex = 89;
            checkBox17.Text = "Pizza Special B";
            checkBox17.UseVisualStyleBackColor = true;
            checkBox17.CheckedChanged += checkBox17_CheckedChanged;
            // 
            // checkBox18
            // 
            checkBox18.AutoSize = true;
            checkBox18.Location = new Point(917, 337);
            checkBox18.Name = "checkBox18";
            checkBox18.Size = new Size(130, 24);
            checkBox18.TabIndex = 90;
            checkBox18.Text = "Pizza Special C";
            checkBox18.UseVisualStyleBackColor = true;
            checkBox18.CheckedChanged += checkBox18_CheckedChanged;
            // 
            // checkBox19
            // 
            checkBox19.AutoSize = true;
            checkBox19.Location = new Point(1058, 333);
            checkBox19.Name = "checkBox19";
            checkBox19.Size = new Size(132, 24);
            checkBox19.TabIndex = 91;
            checkBox19.Text = "Pizza Special D";
            checkBox19.UseVisualStyleBackColor = true;
            checkBox19.CheckedChanged += checkBox19_CheckedChanged;
            // 
            // checkBox20
            // 
            checkBox20.AutoSize = true;
            checkBox20.Location = new Point(1206, 337);
            checkBox20.Name = "checkBox20";
            checkBox20.Size = new Size(133, 24);
            checkBox20.TabIndex = 92;
            checkBox20.Text = "Pizza Barbeque";
            checkBox20.UseVisualStyleBackColor = true;
            checkBox20.CheckedChanged += checkBox20_CheckedChanged;
            // 
            // checkBox21
            // 
            checkBox21.AutoSize = true;
            checkBox21.Location = new Point(635, 499);
            checkBox21.Name = "checkBox21";
            checkBox21.Size = new Size(77, 24);
            checkBox21.TabIndex = 93;
            checkBox21.Text = "Pizza 1";
            checkBox21.UseVisualStyleBackColor = true;
            checkBox21.CheckedChanged += checkBox21_CheckedChanged;
            // 
            // checkBox22
            // 
            checkBox22.AutoSize = true;
            checkBox22.Location = new Point(775, 499);
            checkBox22.Name = "checkBox22";
            checkBox22.Size = new Size(77, 24);
            checkBox22.TabIndex = 94;
            checkBox22.Text = "Pizza 2";
            checkBox22.UseVisualStyleBackColor = true;
            checkBox22.CheckedChanged += checkBox22_CheckedChanged;
            // 
            // checkBox23
            // 
            checkBox23.AutoSize = true;
            checkBox23.Location = new Point(917, 499);
            checkBox23.Name = "checkBox23";
            checkBox23.Size = new Size(77, 24);
            checkBox23.TabIndex = 95;
            checkBox23.Text = "Pizza 3";
            checkBox23.UseVisualStyleBackColor = true;
            checkBox23.CheckedChanged += checkBox23_CheckedChanged;
            // 
            // checkBox24
            // 
            checkBox24.AutoSize = true;
            checkBox24.Location = new Point(1058, 499);
            checkBox24.Name = "checkBox24";
            checkBox24.Size = new Size(77, 24);
            checkBox24.TabIndex = 96;
            checkBox24.Text = "Pizza 4";
            checkBox24.UseVisualStyleBackColor = true;
            checkBox24.CheckedChanged += checkBox24_CheckedChanged;
            // 
            // checkBox25
            // 
            checkBox25.AutoSize = true;
            checkBox25.Location = new Point(1206, 499);
            checkBox25.Name = "checkBox25";
            checkBox25.Size = new Size(77, 24);
            checkBox25.TabIndex = 96;
            checkBox25.Text = "Pizza 5";
            checkBox25.UseVisualStyleBackColor = true;
            checkBox25.CheckedChanged += checkBox25_CheckedChanged;
            // 
            // checkBox26
            // 
            checkBox26.AutoSize = true;
            checkBox26.Location = new Point(635, 661);
            checkBox26.Name = "checkBox26";
            checkBox26.Size = new Size(77, 24);
            checkBox26.TabIndex = 97;
            checkBox26.Text = "Pizza 6";
            checkBox26.UseVisualStyleBackColor = true;
            checkBox26.CheckedChanged += checkBox26_CheckedChanged;
            // 
            // checkBox27
            // 
            checkBox27.AutoSize = true;
            checkBox27.Location = new Point(775, 661);
            checkBox27.Name = "checkBox27";
            checkBox27.Size = new Size(77, 24);
            checkBox27.TabIndex = 98;
            checkBox27.Text = "Pizza 7";
            checkBox27.UseVisualStyleBackColor = true;
            checkBox27.CheckedChanged += checkBox27_CheckedChanged;
            // 
            // checkBox28
            // 
            checkBox28.AutoSize = true;
            checkBox28.Location = new Point(917, 661);
            checkBox28.Name = "checkBox28";
            checkBox28.Size = new Size(77, 24);
            checkBox28.TabIndex = 99;
            checkBox28.Text = "Pizza 8";
            checkBox28.UseVisualStyleBackColor = true;
            checkBox28.CheckedChanged += checkBox28_CheckedChanged;
            // 
            // checkBox29
            // 
            checkBox29.AutoSize = true;
            checkBox29.Location = new Point(1060, 661);
            checkBox29.Name = "checkBox29";
            checkBox29.Size = new Size(77, 24);
            checkBox29.TabIndex = 100;
            checkBox29.Text = "Pizza 9";
            checkBox29.UseVisualStyleBackColor = true;
            checkBox29.CheckedChanged += checkBox29_CheckedChanged;
            // 
            // checkBox30
            // 
            checkBox30.AutoSize = true;
            checkBox30.Location = new Point(1206, 661);
            checkBox30.Name = "checkBox30";
            checkBox30.Size = new Size(132, 24);
            checkBox30.TabIndex = 101;
            checkBox30.Text = "Armanos Pizza ";
            checkBox30.UseVisualStyleBackColor = true;
            checkBox30.CheckedChanged += checkBox30_CheckedChanged;
            // 
            // Lesson4_Example3_Methods
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 792);
            Controls.Add(checkBox30);
            Controls.Add(checkBox29);
            Controls.Add(checkBox28);
            Controls.Add(checkBox27);
            Controls.Add(checkBox26);
            Controls.Add(checkBox25);
            Controls.Add(checkBox24);
            Controls.Add(checkBox23);
            Controls.Add(checkBox22);
            Controls.Add(checkBox21);
            Controls.Add(checkBox20);
            Controls.Add(checkBox19);
            Controls.Add(checkBox18);
            Controls.Add(checkBox17);
            Controls.Add(checkBox16);
            Controls.Add(checkBox15);
            Controls.Add(checkBox14);
            Controls.Add(checkBox13);
            Controls.Add(checkBox12);
            Controls.Add(checkBox11);
            Controls.Add(label15);
            Controls.Add(Button_Exit);
            Controls.Add(Button_New);
            Controls.Add(Button_Remove_Order);
            Controls.Add(Button_Print_Transaction);
            Controls.Add(Button_Calculate_Bills);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(Txtbox_Change);
            Controls.Add(Txtbox_Cash_Given);
            Controls.Add(Txtbox_Total_Quantity);
            Controls.Add(Txtbox_Total_Bills);
            Controls.Add(Txtbox_Discounted_Amount);
            Controls.Add(Txtbox_Discount_Amount);
            Controls.Add(Txtbox_Quantity);
            Controls.Add(Txtbox_Price);
            Controls.Add(Checkbox_B_MediumHawaiPizza);
            Controls.Add(Checkbox_B_FampackFries);
            Controls.Add(Checkbox_B_FPC);
            Controls.Add(Checkbox_B_6pcsDFC);
            Controls.Add(Checkbox_B_4CupsHaloHalo);
            Controls.Add(Checkbox_A_SPD);
            Controls.Add(Checkbox_A_4SideDishes);
            Controls.Add(Checkbox_A_15Coke);
            Controls.Add(Checkbox_A_2LargeFries);
            Controls.Add(Checkbox_A_10pcsDFC);
            Controls.Add(pictureBox20);
            Controls.Add(pictureBox19);
            Controls.Add(pictureBox18);
            Controls.Add(pictureBox17);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox21);
            Controls.Add(Picturebox_Display);
            Controls.Add(Listbox_Display);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Radio_Button_B);
            Controls.Add(Radio_Button_A);
            Controls.Add(label1);
            Name = "Lesson4_Example3_Methods";
            Text = "Activity5";
            Load += Activity5_Load;
            ((System.ComponentModel.ISupportInitialize)Picturebox_Display).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton Radio_Button_A;
        private RadioButton Radio_Button_B;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ListBox Listbox_Display;
        private PictureBox Picturebox_Display;
        private PictureBox pictureBox20;
        private PictureBox pictureBox19;
        private PictureBox pictureBox18;
        private PictureBox pictureBox17;
        private PictureBox pictureBox16;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox15;
        private PictureBox pictureBox6;
        private PictureBox pictureBox14;
        private PictureBox pictureBox7;
        private PictureBox pictureBox13;
        private PictureBox pictureBox8;
        private PictureBox pictureBox12;
        private PictureBox pictureBox9;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private PictureBox pictureBox21;
        private CheckBox Checkbox_A_10pcsDFC;
        private CheckBox Checkbox_A_2LargeFries;
        private CheckBox Checkbox_A_15Coke;
        private CheckBox Checkbox_A_4SideDishes;
        private CheckBox Checkbox_A_SPD;
        private CheckBox Checkbox_B_4CupsHaloHalo;
        private CheckBox Checkbox_B_6pcsDFC;
        private CheckBox Checkbox_B_FPC;
        private CheckBox Checkbox_B_FampackFries;
        private CheckBox Checkbox_B_MediumHawaiPizza;
        private TextBox Txtbox_Price;
        private TextBox Txtbox_Quantity;
        private TextBox Txtbox_Discount_Amount;
        private TextBox Txtbox_Discounted_Amount;
        private TextBox Txtbox_Total_Bills;
        private TextBox Txtbox_Total_Quantity;
        private TextBox Txtbox_Cash_Given;
        private TextBox Txtbox_Change;
        private Label label13;
        private Label label14;
        private Button Button_Calculate_Bills;
        private Button Button_Print_Transaction;
        private Button Button_Remove_Order;
        private Button Button_New;
        private Button Button_Exit;
        private Label label15;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private CheckBox checkBox13;
        private CheckBox checkBox14;
        private CheckBox checkBox15;
        private CheckBox checkBox16;
        private CheckBox checkBox17;
        private CheckBox checkBox18;
        private CheckBox checkBox19;
        private CheckBox checkBox20;
        private CheckBox checkBox21;
        private CheckBox checkBox22;
        private CheckBox checkBox23;
        private CheckBox checkBox24;
        private CheckBox checkBox25;
        private CheckBox checkBox26;
        private CheckBox checkBox27;
        private CheckBox checkBox28;
        private CheckBox checkBox29;
        private CheckBox checkBox30;
    }
}