namespace CARIAZO_OOP_CPE201
{
    partial class Example4_Lesson7
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
            label2 = new Label();
            BasicRateTxtbox = new TextBox();
            BasicCutoffTxtbox = new TextBox();
            label3 = new Label();
            BasicIncomeTxtbox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            TotalHonorariumTxtbox = new TextBox();
            label6 = new Label();
            HonorariumCutoffTxtbox = new TextBox();
            label7 = new Label();
            HonorariumRateTxtbox = new TextBox();
            label8 = new Label();
            TotalOtherTxtbox = new TextBox();
            label9 = new Label();
            OtherCutoffTxtbox = new TextBox();
            label10 = new Label();
            OtherRateTxtbox = new TextBox();
            label11 = new Label();
            label12 = new Label();
            PagibigContributionTxtbox = new TextBox();
            label13 = new Label();
            PhilhealthContributionTxtbox = new TextBox();
            label14 = new Label();
            SSScontributionTxtbox = new TextBox();
            label15 = new Label();
            label16 = new Label();
            TaxTxtbox = new TextBox();
            label17 = new Label();
            NetIncomeTxtbox = new TextBox();
            label18 = new Label();
            GrossIncomeTxtbox = new TextBox();
            label19 = new Label();
            TotalDeductionsTxtbox = new TextBox();
            label20 = new Label();
            label21 = new Label();
            CalculateBtn = new Button();
            NewBtn = new Button();
            ExitBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "BASIC PAY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 80);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 1;
            label2.Text = "Rate / Hour:";
            // 
            // BasicRateTxtbox
            // 
            BasicRateTxtbox.Location = new Point(144, 73);
            BasicRateTxtbox.Name = "BasicRateTxtbox";
            BasicRateTxtbox.Size = new Size(370, 27);
            BasicRateTxtbox.TabIndex = 2;
            BasicRateTxtbox.TextChanged += textBox1_TextChanged;
            // 
            // BasicCutoffTxtbox
            // 
            BasicCutoffTxtbox.Location = new Point(200, 106);
            BasicCutoffTxtbox.Name = "BasicCutoffTxtbox";
            BasicCutoffTxtbox.Size = new Size(314, 27);
            BasicCutoffTxtbox.TabIndex = 4;
            BasicCutoffTxtbox.Leave += BasicCutoffTxtbox_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 113);
            label3.Name = "label3";
            label3.Size = new Size(157, 20);
            label3.TabIndex = 3;
            label3.Text = "No. of Hours / Cut Off:";
            // 
            // BasicIncomeTxtbox
            // 
            BasicIncomeTxtbox.Location = new Point(200, 139);
            BasicIncomeTxtbox.Name = "BasicIncomeTxtbox";
            BasicIncomeTxtbox.Size = new Size(314, 27);
            BasicIncomeTxtbox.TabIndex = 6;
            BasicIncomeTxtbox.Leave += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 146);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 5;
            label4.Text = "Income Per Cut Off:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 198);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 7;
            label5.Text = "HONORARIUM";
            // 
            // TotalHonorariumTxtbox
            // 
            TotalHonorariumTxtbox.Location = new Point(219, 291);
            TotalHonorariumTxtbox.Name = "TotalHonorariumTxtbox";
            TotalHonorariumTxtbox.Size = new Size(295, 27);
            TotalHonorariumTxtbox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 298);
            label6.Name = "label6";
            label6.Size = new Size(155, 20);
            label6.TabIndex = 12;
            label6.Text = "Total Honorarium Pay:";
            // 
            // HonorariumCutoffTxtbox
            // 
            HonorariumCutoffTxtbox.Location = new Point(200, 258);
            HonorariumCutoffTxtbox.Name = "HonorariumCutoffTxtbox";
            HonorariumCutoffTxtbox.Size = new Size(314, 27);
            HonorariumCutoffTxtbox.TabIndex = 11;
            HonorariumCutoffTxtbox.Leave += HonorariumCutoffTxtbox_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 265);
            label7.Name = "label7";
            label7.Size = new Size(157, 20);
            label7.TabIndex = 10;
            label7.Text = "No. of Hours / Cut Off:";
            // 
            // HonorariumRateTxtbox
            // 
            HonorariumRateTxtbox.Location = new Point(144, 225);
            HonorariumRateTxtbox.Name = "HonorariumRateTxtbox";
            HonorariumRateTxtbox.Size = new Size(370, 27);
            HonorariumRateTxtbox.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 232);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 8;
            label8.Text = "Rate / Hour:";
            // 
            // TotalOtherTxtbox
            // 
            TotalOtherTxtbox.Location = new Point(219, 429);
            TotalOtherTxtbox.Name = "TotalOtherTxtbox";
            TotalOtherTxtbox.Size = new Size(295, 27);
            TotalOtherTxtbox.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 436);
            label9.Name = "label9";
            label9.Size = new Size(165, 20);
            label9.TabIndex = 19;
            label9.Text = "Total Other Income Pay:";
            // 
            // OtherCutoffTxtbox
            // 
            OtherCutoffTxtbox.Location = new Point(200, 396);
            OtherCutoffTxtbox.Name = "OtherCutoffTxtbox";
            OtherCutoffTxtbox.Size = new Size(314, 27);
            OtherCutoffTxtbox.TabIndex = 18;
            OtherCutoffTxtbox.Leave += OtherCutoffTxtbox_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 403);
            label10.Name = "label10";
            label10.Size = new Size(157, 20);
            label10.TabIndex = 17;
            label10.Text = "No. of Hours / Cut Off:";
            // 
            // OtherRateTxtbox
            // 
            OtherRateTxtbox.Location = new Point(144, 363);
            OtherRateTxtbox.Name = "OtherRateTxtbox";
            OtherRateTxtbox.Size = new Size(370, 27);
            OtherRateTxtbox.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(37, 370);
            label11.Name = "label11";
            label11.Size = new Size(89, 20);
            label11.TabIndex = 15;
            label11.Text = "Rate / Hour:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(12, 336);
            label12.Name = "label12";
            label12.Size = new Size(120, 20);
            label12.TabIndex = 14;
            label12.Text = "OTHER INCOME";
            // 
            // PagibigContributionTxtbox
            // 
            PagibigContributionTxtbox.Location = new Point(729, 139);
            PagibigContributionTxtbox.Name = "PagibigContributionTxtbox";
            PagibigContributionTxtbox.Size = new Size(336, 27);
            PagibigContributionTxtbox.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(574, 146);
            label13.Name = "label13";
            label13.Size = new Size(149, 20);
            label13.TabIndex = 26;
            label13.Text = "PagIbig Contribution:";
            // 
            // PhilhealthContributionTxtbox
            // 
            PhilhealthContributionTxtbox.Location = new Point(747, 106);
            PhilhealthContributionTxtbox.Name = "PhilhealthContributionTxtbox";
            PhilhealthContributionTxtbox.Size = new Size(318, 27);
            PhilhealthContributionTxtbox.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(574, 113);
            label14.Name = "label14";
            label14.Size = new Size(167, 20);
            label14.TabIndex = 24;
            label14.Text = "PhilHealth Contribution:";
            // 
            // SSScontributionTxtbox
            // 
            SSScontributionTxtbox.Location = new Point(703, 73);
            SSScontributionTxtbox.Name = "SSScontributionTxtbox";
            SSScontributionTxtbox.Size = new Size(362, 27);
            SSScontributionTxtbox.TabIndex = 23;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(574, 80);
            label15.Name = "label15";
            label15.Size = new Size(123, 20);
            label15.TabIndex = 22;
            label15.Text = "SSS Contribution:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(549, 46);
            label16.Name = "label16";
            label16.Size = new Size(177, 20);
            label16.TabIndex = 21;
            label16.Text = "REGULAR DEDUCTIONS";
            // 
            // TaxTxtbox
            // 
            TaxTxtbox.Location = new Point(729, 172);
            TaxTxtbox.Name = "TaxTxtbox";
            TaxTxtbox.Size = new Size(336, 27);
            TaxTxtbox.TabIndex = 29;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(690, 179);
            label17.Name = "label17";
            label17.Size = new Size(33, 20);
            label17.TabIndex = 28;
            label17.Text = "Tax:";
            // 
            // NetIncomeTxtbox
            // 
            NetIncomeTxtbox.Location = new Point(703, 347);
            NetIncomeTxtbox.Name = "NetIncomeTxtbox";
            NetIncomeTxtbox.Size = new Size(365, 27);
            NetIncomeTxtbox.TabIndex = 36;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(574, 354);
            label18.Name = "label18";
            label18.Size = new Size(99, 20);
            label18.TabIndex = 35;
            label18.Text = "NET INCOME:";
            // 
            // GrossIncomeTxtbox
            // 
            GrossIncomeTxtbox.Location = new Point(703, 314);
            GrossIncomeTxtbox.Name = "GrossIncomeTxtbox";
            GrossIncomeTxtbox.Size = new Size(365, 27);
            GrossIncomeTxtbox.TabIndex = 34;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(574, 321);
            label19.Name = "label19";
            label19.Size = new Size(118, 20);
            label19.TabIndex = 33;
            label19.Text = "GROSS INCOME:";
            // 
            // TotalDeductionsTxtbox
            // 
            TotalDeductionsTxtbox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalDeductionsTxtbox.Location = new Point(724, 265);
            TotalDeductionsTxtbox.Name = "TotalDeductionsTxtbox";
            TotalDeductionsTxtbox.Size = new Size(344, 43);
            TotalDeductionsTxtbox.TabIndex = 32;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(574, 282);
            label20.Name = "label20";
            label20.Size = new Size(148, 20);
            label20.TabIndex = 31;
            label20.Text = "TOTAL DEDUCTIONS:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(549, 238);
            label21.Name = "label21";
            label21.Size = new Size(149, 20);
            label21.TabIndex = 30;
            label21.Text = "INCOME SUMMARY";
            // 
            // CalculateBtn
            // 
            CalculateBtn.Location = new Point(549, 422);
            CalculateBtn.Name = "CalculateBtn";
            CalculateBtn.Size = new Size(169, 34);
            CalculateBtn.TabIndex = 37;
            CalculateBtn.Text = "CALCULATE";
            CalculateBtn.UseVisualStyleBackColor = true;
            CalculateBtn.Click += CalculateBtn_Click;
            // 
            // NewBtn
            // 
            NewBtn.Location = new Point(724, 422);
            NewBtn.Name = "NewBtn";
            NewBtn.Size = new Size(169, 34);
            NewBtn.TabIndex = 38;
            NewBtn.Text = "NEW";
            NewBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(899, 422);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(169, 34);
            ExitBtn.TabIndex = 39;
            ExitBtn.Text = "EXIT";
            ExitBtn.UseVisualStyleBackColor = true;
            // 
            // Example4_Lesson7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 510);
            Controls.Add(ExitBtn);
            Controls.Add(NewBtn);
            Controls.Add(CalculateBtn);
            Controls.Add(NetIncomeTxtbox);
            Controls.Add(label18);
            Controls.Add(GrossIncomeTxtbox);
            Controls.Add(label19);
            Controls.Add(TotalDeductionsTxtbox);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(TaxTxtbox);
            Controls.Add(label17);
            Controls.Add(PagibigContributionTxtbox);
            Controls.Add(label13);
            Controls.Add(PhilhealthContributionTxtbox);
            Controls.Add(label14);
            Controls.Add(SSScontributionTxtbox);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(TotalOtherTxtbox);
            Controls.Add(label9);
            Controls.Add(OtherCutoffTxtbox);
            Controls.Add(label10);
            Controls.Add(OtherRateTxtbox);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(TotalHonorariumTxtbox);
            Controls.Add(label6);
            Controls.Add(HonorariumCutoffTxtbox);
            Controls.Add(label7);
            Controls.Add(HonorariumRateTxtbox);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(BasicIncomeTxtbox);
            Controls.Add(label4);
            Controls.Add(BasicCutoffTxtbox);
            Controls.Add(label3);
            Controls.Add(BasicRateTxtbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Example4_Lesson7";
            Text = "Example4_Lesson7";
            Load += Example4_Lesson7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox BasicRateTxtbox;
        private TextBox BasicCutoffTxtbox;
        private Label label3;
        private TextBox BasicIncomeTxtbox;
        private Label label4;
        private Label label5;
        private TextBox TotalHonorariumTxtbox;
        private Label label6;
        private TextBox HonorariumCutoffTxtbox;
        private Label label7;
        private TextBox HonorariumRateTxtbox;
        private Label label8;
        private TextBox TotalOtherTxtbox;
        private Label label9;
        private TextBox OtherCutoffTxtbox;
        private Label label10;
        private TextBox OtherRateTxtbox;
        private Label label11;
        private Label label12;
        private TextBox PagibigContributionTxtbox;
        private Label label13;
        private TextBox PhilhealthContributionTxtbox;
        private Label label14;
        private TextBox SSScontributionTxtbox;
        private Label label15;
        private Label label16;
        private TextBox TaxTxtbox;
        private Label label17;
        private TextBox NetIncomeTxtbox;
        private Label label18;
        private TextBox GrossIncomeTxtbox;
        private Label label19;
        private TextBox TotalDeductionsTxtbox;
        private Label label20;
        private Label label21;
        private Button CalculateBtn;
        private Button NewBtn;
        private Button ExitBtn;
    }
}