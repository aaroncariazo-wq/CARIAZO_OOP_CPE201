namespace CARIAZO_OOP_CPE201
{
    partial class while_loop2
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
            numTimesDisplayTextbox = new TextBox();
            button1 = new Button();
            label2 = new Label();
            countryCombobox = new ComboBox();
            displayListBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 46);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter a number:";
            // 
            // numTimesDisplayTextbox
            // 
            numTimesDisplayTextbox.Location = new Point(184, 43);
            numTimesDisplayTextbox.Name = "numTimesDisplayTextbox";
            numTimesDisplayTextbox.Size = new Size(100, 23);
            numTimesDisplayTextbox.TabIndex = 1;
            numTimesDisplayTextbox.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(301, 43);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "SHOW";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 100);
            label2.Name = "label2";
            label2.Size = new Size(267, 15);
            label2.TabIndex = 3;
            label2.Text = "SELECT A COUNTRY TO DISPLAY AT THE LIST BOX";
            // 
            // countryCombobox
            // 
            countryCombobox.FormattingEnabled = true;
            countryCombobox.Location = new Point(99, 129);
            countryCombobox.Name = "countryCombobox";
            countryCombobox.Size = new Size(267, 23);
            countryCombobox.TabIndex = 4;
            // 
            // displayListBox
            // 
            displayListBox.FormattingEnabled = true;
            displayListBox.ItemHeight = 15;
            displayListBox.Location = new Point(87, 158);
            displayListBox.Name = "displayListBox";
            displayListBox.Size = new Size(289, 259);
            displayListBox.TabIndex = 5;
            // 
            // while_loop2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 452);
            Controls.Add(displayListBox);
            Controls.Add(countryCombobox);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(numTimesDisplayTextbox);
            Controls.Add(label1);
            Name = "while_loop2";
            Text = "while_loop2";
            Load += while_loop2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox numTimesDisplayTextbox;
        private Button button1;
        private Label label2;
        private ComboBox countryCombobox;
        private ListBox displayListBox;
    }
}