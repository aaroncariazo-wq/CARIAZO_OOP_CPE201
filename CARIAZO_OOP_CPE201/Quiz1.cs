namespace CARIAZO_OOP_CPE201
{
    public partial class Quiz1 : Form
    {
        public Quiz1()
        {
            InitializeComponent();
        }

        double CompLabFee = 2500;
        double SAPFee = 2000;
        double CISCOLabFee = 4500;
        double ExamBookletFee = 450;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Quiz1_Load(object sender, EventArgs e)
        {

            yearlevelCombobox.Items.Add("1st Year");
            yearlevelCombobox.Items.Add("2nd Year");
            yearlevelCombobox.Items.Add("3rd Year");
            yearlevelCombobox.Items.Add("4th Year");

            scholarCombobox.Items.Add("Academic Scholar");
            scholarCombobox.Items.Add("None");


            programCombobox.Items.Add("BS Information Technology");
            programCombobox.Items.Add("BS Computer Engineering");
            programCombobox.Items.Add("BS Electrical Engineering");
            programCombobox.Items.Add("BS Computer Science");
            programCombobox.Items.Add("BS Mechanical Engineering");
            programCombobox.Items.Add("BS Industrial Engineering");



            textBox6.Text = CompLabFee.ToString();
            textBox5.Text = SAPFee.ToString();
            textBox8.Text = CISCOLabFee.ToString();
            textBox7.Text = ExamBookletFee.ToString();


            modeCombobox.Items.Add("Installment");
            textBox13.Text = "Installment";
            textBox11.Text = "8000";
        }

        private void LU1_TextChanged(object sender, EventArgs e)
        {
            if (LU1.Text != "" && LabU1.Text != "")
            {
                CU1.Text = (Convert.ToInt32(LU1.Text) + Convert.ToInt32(LabU1.Text)).ToString();
            }
        }

        private void LU2_TextChanged(object sender, EventArgs e)
        {
            if (LU2.Text != "" && LabU2.Text != "")
            {
                CU2.Text = (Convert.ToInt32(LU2.Text) + Convert.ToInt32(LabU2.Text)).ToString();
            }
        }

        private void LabU1_TextChanged(object sender, EventArgs e)
        {
            if (LU1.Text != "" && LabU1.Text != "")
            {
                CU1.Text = (Convert.ToInt32(LU1.Text) + Convert.ToInt32(LabU1.Text)).ToString();
            }
        }

        private void LabU2_TextChanged(object sender, EventArgs e)
        {
            if (LU2.Text != "" && LabU2.Text != "")
            {
                CU2.Text = (Convert.ToInt32(LU2.Text) + Convert.ToInt32(LabU2.Text)).ToString();
            }
        }

        private void LU3_TextChanged(object sender, EventArgs e)
        {
            if (LU3.Text != "" && LabU3.Text != "")
            {
                CU3.Text = (Convert.ToInt32(LU3.Text) + Convert.ToInt32(LabU3.Text)).ToString();
            }
        }

        private void LabU3_TextChanged(object sender, EventArgs e)
        {
            if (LU3.Text != "" && LabU3.Text != "")
            {
                CU3.Text = (Convert.ToInt32(LU3.Text) + Convert.ToInt32(LabU3.Text)).ToString();
            }
        }

        private void LU4_TextChanged(object sender, EventArgs e)
        {
            if (LU4.Text != "" && LabU4.Text != "")
            {
                CU4.Text = (Convert.ToInt32(LU4.Text) + Convert.ToInt32(LabU4.Text)).ToString();
            }
        }

        private void LabU4_TextChanged(object sender, EventArgs e)
        {
            if (LU4.Text != "" && LabU4.Text != "")
            {
                CU4.Text = (Convert.ToInt32(LU4.Text) + Convert.ToInt32(LabU4.Text)).ToString();
            }
        }

        private void LU5_TextChanged(object sender, EventArgs e)
        {
            if (LU5.Text != "" && LabU5.Text != "")
            {
                CU5.Text = (Convert.ToInt32(LU5.Text) + Convert.ToInt32(LabU5.Text)).ToString();
            }
        }

        private void LabU5_TextChanged(object sender, EventArgs e)
        {
            if (LU5.Text != "" && LabU5.Text != "")
            {
                CU5.Text = (Convert.ToInt32(LU5.Text) + Convert.ToInt32(LabU5.Text)).ToString();
            }
        }

        private void LU6_TextChanged(object sender, EventArgs e)
        {
            if (LU6.Text != "" && LabU6.Text != "")
            {
                CU6.Text = (Convert.ToInt32(LU6.Text) + Convert.ToInt32(LabU6.Text)).ToString();
            }
        }

        private void LabU6_TextChanged(object sender, EventArgs e)
        {
            if (LU6.Text != "" && LabU6.Text != "")
            {
                CU6.Text = (Convert.ToInt32(LU6.Text) + Convert.ToInt32(LabU6.Text)).ToString();
            }
        }

        private void LU7_TextChanged(object sender, EventArgs e)
        {
            if (LU7.Text != "" && LabU7.Text != "")
            {
                CU7.Text = (Convert.ToInt32(LU7.Text) + Convert.ToInt32(LabU7.Text)).ToString();
            }
        }

        private void LabU7_TextChanged(object sender, EventArgs e)
        {
            if (LU7.Text != "" && LabU7.Text != "")
            {
                CU7.Text = (Convert.ToInt32(LU7.Text) + Convert.ToInt32(LabU7.Text)).ToString();
            }
        }

        private void CU7_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                totalcredunitsTxtbox.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU6_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                totalcredunitsTxtbox.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU5_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                totalcredunitsTxtbox.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU4_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                totalcredunitsTxtbox.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU3_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                totalcredunitsTxtbox.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU2_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                totalcredunitsTxtbox.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void CU1_TextChanged(object sender, EventArgs e)
        {
            if (CU7.Text != "" && CU6.Text != "" && CU5.Text != "" && CU4.Text != "" && CU3.Text != "" && CU2.Text != "" && CU1.Text != "")
            {
                totalcredunitsTxtbox.Text = (Convert.ToInt32(CU1.Text) + Convert.ToInt32(CU2.Text) + Convert.ToInt32(CU3.Text) + Convert.ToInt32(CU4.Text) + Convert.ToInt32(CU5.Text) + Convert.ToInt32(CU6.Text) + Convert.ToInt32(CU7.Text)).ToString();
            }
        }

        private void clrstudentinfoBtn_Click(object sender, EventArgs e)
        {
            studentnameTxtbox.Clear();
            studentnumberTxtbox.Clear();
            programCombobox.SelectedIndex = -1;
            yearlevelCombobox.SelectedIndex = -1;
            programCombobox.SelectedIndex = -1;
            scholarCombobox.SelectedIndex = -1;
        }

        private void clrschedcoursesBtn_Click(object sender, EventArgs e)
        {
            // clear all course code
            CC1.Clear();
            CC2.Clear();
            CC3.Clear();
            CC4.Clear();
            CC5.Clear();
            CC6.Clear();
            CC7.Clear();

            // Clear all section
            S1.Clear();
            S2.Clear();
            S3.Clear();
            S4.Clear();
            S5.Clear();
            S6.Clear();
            S7.Clear();

            // clear all desc
            D1.Clear();
            D2.Clear();
            D3.Clear();
            D4.Clear();
            D5.Clear();
            D6.Clear();
            D7.Clear();

            // clear all lec
            LU1.Clear();
            LU2.Clear();
            LU3.Clear();
            LU4.Clear();
            LU5.Clear();
            LU6.Clear();
            LU7.Clear();

            // clear all lab
            LabU1.Clear();
            LabU2.Clear();
            LabU3.Clear();
            LabU4.Clear();
            LabU5.Clear();
            LabU6.Clear();
            LabU7.Clear();

            // Clear all credit unit
            CU1.Clear();
            CU2.Clear();
            CU3.Clear();
            CU4.Clear();
            CU5.Clear();
            CU6.Clear();
            CU7.Clear();
            totalcredunitsTxtbox.Clear();

            // clear all time
            T1.Clear();
            T2.Clear();
            T3.Clear();
            T4.Clear();
            T5.Clear();
            T6.Clear();
            T7.Clear();

            // clear all day
            D1.Clear();
            D2.Clear();
            D3.Clear();
            D4.Clear();
            D5.Clear();
            D6.Clear();
            D7.Clear();

            // clear all room
            R1.Clear();
            R2.Clear();
            R3.Clear();
            R4.Clear();
            R5.Clear();
            R6.Clear();
            R7.Clear();
        }

        private void computefeesBtn_Click(object sender, EventArgs e)
        {

            double total_lecunits = Convert.ToInt32(LU1.Text) + Convert.ToInt32(LU2.Text) + Convert.ToInt32(LU3.Text) + Convert.ToInt32(LU4.Text) + Convert.ToInt32(LU5.Text) + Convert.ToInt32(LU6.Text) + Convert.ToInt32(LU7.Text);
            double totalTuition = Convert.ToInt32(totalcredunitsTxtbox.Text) * 1500;
            textBox3.Text = totalTuition.ToString();


            double total_labunits = Convert.ToInt32(LabU1.Text) + Convert.ToInt32(LabU2.Text) + Convert.ToInt32(LabU3.Text) + Convert.ToInt32(LabU4.Text) + Convert.ToInt32(LabU5.Text) + Convert.ToInt32(LabU6.Text) + Convert.ToInt32(LabU7.Text);
            CompLabFee = 2500 * (total_labunits);
            textBox6.Text = CompLabFee.ToString();
            double totalMisc = CompLabFee + SAPFee + CISCOLabFee + ExamBookletFee;


            textBox4.Text = totalMisc.ToString();
            textBox9.Text = totalMisc.ToString();


            CompLabFee = (Convert.ToDouble(LabU1.Text) + Convert.ToDouble(LabU2.Text) + Convert.ToDouble(LabU3.Text) + Convert.ToDouble(LabU4.Text) + Convert.ToDouble(LabU5.Text) + Convert.ToDouble(LabU6.Text) + Convert.ToDouble(LabU7.Text)) * 2500;


            double total_tuition_and_fees = totalTuition + totalMisc;
            textBox14.Text = total_tuition_and_fees.ToString();

            double installment_fee = (total_tuition_and_fees - 8000) / 3;
            textBox16.Text = installment_fee.ToString("C");
            textBox15.Text = installment_fee.ToString("C");
            textBox10.Text = installment_fee.ToString("C");
        }
    }
}
