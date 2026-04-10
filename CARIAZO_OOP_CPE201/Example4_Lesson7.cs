using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARIAZO_OOP_CPE201
{
    public partial class Example4_Lesson7 : Form
    {
        // global variables
        private Double BasicNetIncome = 0.00;
        private Double BasicCutoff = 0.00;
        private Double BasicRate = 0.00;
        private Double HonorariumNetIncome = 0.00;
        private Double HonorariumCutoff = 0.00;
        private Double HonorariumRate = 0.00;
        private Double OtherNetIncome = 0.00;
        private Double OtherCutoff = 0.00;
        private Double OtherRate = 0.00;
        private Double GrossIncome = 0.00;
        private Double Tax = 0.00;

        private Double SSScontribution;
        private Double PagIbigContribution;
        private Double PhilhealthContribution;
        private Double TotalDeductions;
        private Double NetIncome;

        public Example4_Lesson7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Example4_Lesson7_Load(object sender, EventArgs e)
        {
            // codes for disabling
            BasicIncomeTxtbox.Enabled = false;
            TotalHonorariumTxtbox.Enabled = false;
            TotalOtherTxtbox.Enabled = false;
            NetIncomeTxtbox.Enabled = false;
            GrossIncomeTxtbox.Enabled = false;
            TotalDeductionsTxtbox.Enabled = false;
            SSScontributionTxtbox.Enabled = false;
            PagibigContributionTxtbox.Enabled = false;
            PhilhealthContributionTxtbox.Enabled = false;
            TaxTxtbox.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BasicCutoffTxtbox_Leave(object sender, EventArgs e)
        {
            try
            {
                BasicCutoff = Convert.ToDouble(BasicCutoffTxtbox.Text);
                BasicRate = Convert.ToDouble(BasicRateTxtbox.Text);
                BasicNetIncome = BasicCutoff * BasicRate;
                BasicIncomeTxtbox.Text = BasicNetIncome.ToString("n");

                GrossIncome = BasicNetIncome + HonorariumNetIncome + OtherNetIncome;
                GrossIncomeTxtbox.Text = GrossIncome.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please Contact your administrator!");
            }

        }

        private void HonorariumCutoffTxtbox_Leave(object sender, EventArgs e)
        {
            try
            {
                HonorariumCutoff = Convert.ToDouble(HonorariumCutoffTxtbox.Text);
                HonorariumRate = Convert.ToDouble(HonorariumRateTxtbox.Text);
                HonorariumNetIncome = HonorariumCutoff * HonorariumRate;
                TotalHonorariumTxtbox.Text = HonorariumNetIncome.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please Contact your administrator!");
            }
        }

        private void OtherCutoffTxtbox_Leave(object sender, EventArgs e)
        {
            try
            {
                OtherCutoff = Convert.ToDouble(OtherCutoffTxtbox.Text);
                OtherRate = Convert.ToDouble(OtherRateTxtbox.Text);
                OtherNetIncome = OtherCutoff * OtherRate;
                TotalOtherTxtbox.Text = OtherNetIncome.ToString("n");

                GrossIncome = BasicNetIncome + HonorariumNetIncome + OtherNetIncome;
                GrossIncomeTxtbox.Text = GrossIncome.ToString("n");

                // computation for philhealth contributions
                double PhilHealth_value = 0;

                if (GrossIncome < 10000)
                {
                    PhilHealth_value = 137.50;
                }
                else
                {
                    double PhilHealth_employshare = 137.50;

                    for (int x = 10000; x <= 40000; x += 1000)
                    {
                        if (GrossIncome >= x && GrossIncome < x + 1000 || GrossIncome > x + 1000);
                        {
                            PhilHealth_value = PhilHealth_employshare;
                        }
                        PhilHealth_employshare += 13.75;
                    }
                }
                PhilhealthContributionTxtbox.Text = PhilHealth_value.ToString("N");

                // computation for SSS contributions
                double SSS_value = 0;
                if (GrossIncome <= 1000)
                {
                    SSS_value = 36.30;
                }
                else
                {
                    double SSS_employshare = 36.30;

                    for (int x = 1000; x <= 15750; x += 500)
                    {
                        if (GrossIncome >= x && GrossIncome < x + 500 || GrossIncome > x + 500)
                        {
                            SSS_value = SSS_employshare;
                        }
                        SSS_employshare += 18.20;
                    }
                }
                SSScontributionTxtbox.Text = SSS_value.ToString("N");

                // tax contribution per month based from new table of TAX 2019
                if (GrossIncome < (250000 / 24))
                {
                    TaxTxtbox.Text = "0.00";
                }
                else if (GrossIncome > 10416.67 && GrossIncome <= 16666.67)
                {
                    Tax = ((((GrossIncome * 24) - 250000) * 0.20) / 24);
                    TaxTxtbox.Text = Tax.ToString("n");
                }
                else if (GrossIncome > 16666.67 && GrossIncome <= 33333.33)
                {
                    Tax = (((((GrossIncome * 24) - 400000) * 0.25) + 30000) / 24);
                    TaxTxtbox.Text = Tax.ToString("n");
                }
                else if (GrossIncome > 33333.33 && GrossIncome <= 83333.33)
                {
                    Tax = (((((GrossIncome * 24) - 800000) * 0.30) + 130000) / 24);
                    TaxTxtbox.Text = Tax.ToString("n");
                }
                else if (GrossIncome > 83333.33 && GrossIncome <= 333333.33)
                {
                    Tax = (((((GrossIncome * 24) - 2000000) * 0.32) + 490000) / 24);
                    TaxTxtbox.Text = Tax.ToString("n");
                }
                else
                {
                    Tax = (((((GrossIncome * 24) - 8000000) * 0.35) + 2410000) / 24);
                    TaxTxtbox.Text = Tax.ToString("n");
                }
                PagibigContributionTxtbox.Text = "100";
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please Contact your administrator!");
            }
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SSScontribution = Convert.ToDouble(SSScontributionTxtbox.Text);
                PagIbigContribution = Convert.ToDouble(PagibigContributionTxtbox.Text);
                PhilhealthContribution = Convert.ToDouble(PhilhealthContributionTxtbox.Text);
                Tax = Convert.ToDouble(TaxTxtbox.Text);
                TotalDeductions = SSScontribution + PagIbigContribution + PhilhealthContribution + Tax;
                NetIncome = GrossIncome - TotalDeductions;
                NetIncomeTxtbox.Text = NetIncome.ToString("C", new CultureInfo("en-PH"));
                TotalDeductionsTxtbox.Text = TotalDeductions.ToString("C", new CultureInfo("en-PH"));
                GrossIncomeTxtbox.Text = GrossIncome.ToString("C", new CultureInfo("en-PH"));
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please Contact your administrator!");
            }
        }
    }
}
