using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CARIAZO_OOP_CPE201
{
    public partial class Activity6_prelim : Form
    {
        // declaration of global variables
        private string picpath;
        private Double basic_netincome = 0.00,
        basic_numhrs = 0.00,
        basic_rate = 0.00,
        hono_netincome = 0.00,
        hono_numhrs = 0.00,
        hono_rate = 0.00,
        other_netincome = 0.00,
        other_numhrs = 0.00,
        other_rate = 0.00;
        private Double netincome = 0.00,
        grossincome = 0.00,
        sss_contrib = 0.00,
        pagibig_contrib = 0.00,
        philhealth_contrib = 0.00,
        tax_contrib = 0.00;
        private Double sss_loan = 0.00,
        pagibig_loan = 0.00,
        salary_loan = 0.00,
        salary_savings = 0.00,
        faculty_sav_loan = 0.00,
        other_deduction = 0.00,
        total_deduction = 0.00,
        total_contrib = 0.00,
        total_loan = 0.00;

        public Activity6_prelim()
        {
            InitializeComponent();
        }

        private void OtherCutoffTxtbox_TextChanged(object sender, EventArgs e)
        {
            other_numhrs = Convert.ToDouble(OtherCutoffTxtbox.Text);
            other_rate = Convert.ToDouble(OtherRateTxtbox.Text);
            other_netincome = other_numhrs * other_rate;
            OtherIncomeTxtbox.Text = other_rate.ToString("n");
            grossincome = basic_netincome + hono_netincome + other_netincome;
            GrossIncomeTxtbox.Text = grossincome.ToString("n");

        }

        private void Activity6_prelim_Load(object sender, EventArgs e)
        {
            //codes for disabling
            BasicIncomeTxtbox.Enabled = false;
            HonorariumIncomeTxtbox.Enabled = false;
            OtherIncomeTxtbox.Enabled = false;
            NetIncomeTxtbox.Enabled = false;
            GrossIncomeTxtbox.Enabled = false;
            TotalDeductionsTxtbox.Enabled = false;
            SSScontributionTxtbox.Text = "0.00";
            PagibigContributionTxtbox.Text = "0.00";
            PhilhealthContributionTxtbox.Text = "0.00";
            IncomeTaxTxtbox.Text = "0.00";
            SSSloanTxtbox.Text = "0.00";
            PagibigLoanTxtbox.Text = "0.00";
            FacultyDepositTxtbox.Text = "0.00";
            FacultyLoanTxtbox.Text = "0.00";
            SalaryLoanTxtbox.Text = "0.00";
            OtherLoanTxtBox.Text = "0.00";
            OtherComboBox.Text = "Select other deduction";
            OtherComboBox.Items.Add("Other 1");
            OtherComboBox.Items.Add("Other 2");
            OtherComboBox.Items.Add("Other 3");
            OtherComboBox.Items.Add("Other 4");
            //picpathTxtbox.Hide();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            //codes for converting input data from textboxes as string to numeric //codes for putting data from textboxes to variables
            sss_contrib = Convert.ToDouble(SSScontributionTxtbox.Text);
            pagibig_contrib = Convert.ToDouble(PagibigContributionTxtbox.Text);
            philhealth_contrib = Convert.ToDouble(PhilhealthContributionTxtbox.Text);
            tax_contrib = Convert.ToDouble(IncomeTaxTxtbox.Text);
            sss_loan = Convert.ToDouble(SSSloanTxtbox.Text);
            pagibig_loan = Convert.ToDouble(PagibigLoanTxtbox.Text);
            salary_loan = Convert.ToDouble(SalaryLoanTxtbox.Text);
            faculty_sav_loan = Convert.ToDouble(FacultyLoanTxtbox.Text);
            salary_savings = Convert.ToDouble(FacultyDepositTxtbox.Text);
            other_deduction = Convert.ToDouble(OtherLoanTxtBox.Text);
            // formula to compute the desired data to be computed
            total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib +
            tax_contrib;
            total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan +
            salary_savings + other_deduction;
            total_deduction = total_contrib + total_loan;
            //codes for converting numeric data to string and displayed it inside the textboxes
            TotalDeductionsTxtbox.Text = total_deduction.ToString("n");
            netincome = grossincome - total_deduction;
            NetIncomeTxtbox.Text = netincome.ToString("n");

        }

        private void PreviewPayslipDetailsBtn_Click(object sender, EventArgs e)
        {
            payslip_viewListBox.Items.Add("Employee Number: " + "" + EmployeeNumberTxtbox.Text);
            payslip_viewListBox.Items.Add("Firstname: " + "" + FirstNameTxtbox.Text);
            payslip_viewListBox.Items.Add("Middlename: " + "" + MiddleNameTxtbox.Text);
            payslip_viewListBox.Items.Add("Surname: " + "" + SurnameTxtbox.Text);
            payslip_viewListBox.Items.Add("Designation: " + "" + DesignationTxtbox.Text);
            payslip_viewListBox.Items.Add("Employee Status: " + "" + EmployeeStatusTxtbox.Text);
            payslip_viewListBox.Items.Add("Department: " + "" + DepartmentTxtbox.Text);
            payslip_viewListBox.Items.Add("Pay Date: " + "" + dateTimePicker1.Text);
            payslip_viewListBox.Items.Add("-------------------------------");
            payslip_viewListBox.Items.Add("BP Num. of Hrs.: " + " P " + BasicCutoffTxtbox.Text);
            payslip_viewListBox.Items.Add("BP Rate / Hr.: " + " P " + BasicRateTxtbox.Text);
            payslip_viewListBox.Items.Add("Basic Pay Income " + " P " + BasicIncomeTxtbox.Text);
            payslip_viewListBox.Items.Add("");
            payslip_viewListBox.Items.Add("HI Num. of Hrs.: " + " P " + HonorariumCutoffTxtbox.Text);
            payslip_viewListBox.Items.Add("HI Rate / Hr.: " + " P " + HonorariumRateTxtbox.Text);
            payslip_viewListBox.Items.Add("Honorarium Income " + " P " + HonorariumIncomeTxtbox.Text);
            payslip_viewListBox.Items.Add("");
            payslip_viewListBox.Items.Add("OTI Num. of Hrs.: " + " P " + OtherCutoffTxtbox.Text);
            payslip_viewListBox.Items.Add("OTI Rate / Hr.: " + " P " + OtherRateTxtbox.Text);
            payslip_viewListBox.Items.Add("Other Income " + " P " + OtherIncomeTxtbox.Text);
            payslip_viewListBox.Items.Add("--------------------------------");
            payslip_viewListBox.Items.Add("SSS Contribution: " + " P " + SSScontributionTxtbox.Text);
            payslip_viewListBox.Items.Add("PhilHealth Contribution " + " P " + PhilhealthContributionTxtbox.Text);
            payslip_viewListBox.Items.Add("Pag-IBIG Contribution: " + " P " + PagibigContributionTxtbox.Text);
            payslip_viewListBox.Items.Add("Tax Contribution: " + " P " + IncomeTaxTxtbox.Text);
            payslip_viewListBox.Items.Add("SSS Loan: " + " P " + SSSloanTxtbox.Text);
            payslip_viewListBox.Items.Add("Pag-IBIG Loan: " + " P " + PagibigLoanTxtbox.Text);
            payslip_viewListBox.Items.Add("Faculty Savings Deposit: " + " P " + FacultyDepositTxtbox.Text);
            payslip_viewListBox.Items.Add("Faculty Savings Loan: " + " P " + FacultyLoanTxtbox.Text);
            payslip_viewListBox.Items.Add("Salary Loan: " + " P " + SalaryLoanTxtbox.Text);
            payslip_viewListBox.Items.Add("Other Loan: " + " P " + OtherLoanTxtBox.Text);
            payslip_viewListBox.Items.Add("--------------------------------");
            payslip_viewListBox.Items.Add("Total Deduction: " + " P " + TotalDeductionsTxtbox.Text);
            payslip_viewListBox.Items.Add("Gross Income: " + " P " + GrossIncomeTxtbox.Text);
            payslip_viewListBox.Items.Add("Net Income: " + " P " + NetIncomeTxtbox.Text);
        }

        private void PrintPayslipBtn_Click(object sender, EventArgs e)
        {
            Activity6_prelim print1 = new Activity6_prelim();
            print1.payslip_viewListBox.Items.AddRange(this.payslip_viewListBox.Items);

            print1.Show();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            EmployeeNumberTxtbox.Clear();
            FirstNameTxtbox.Clear();
            MiddleNameTxtbox.Clear();
            SurnameTxtbox.Clear();
            CivilStatusTxtbox.Clear();
            DesignationTxtbox.Clear();
            NumberOfDependentsTxtbox.Clear();
            EmployeeStatusTxtbox.Clear();
            DepartmentTxtbox.Clear();
            BasicIncomeTxtbox.Clear();
            BasicCutoffTxtbox.Clear();
            BasicRateTxtbox.Clear();
            HonorariumRateTxtbox.Clear();
            HonorariumIncomeTxtbox.Clear();
            HonorariumCutoffTxtbox.Clear();
            OtherIncomeTxtbox.Clear();
            OtherCutoffTxtbox.Clear();
            OtherRateTxtbox.Clear();
            NetIncomeTxtbox.Clear();
            GrossIncomeTxtbox.Clear();
            SSScontributionTxtbox.Clear();
            PagibigContributionTxtbox.Clear();
            PhilhealthContributionTxtbox.Clear();
            IncomeTaxTxtbox.Clear();
            SSSloanTxtbox.Clear();
            PagibigLoanTxtbox.Clear();
            FacultyDepositTxtbox.Clear();
            FacultyLoanTxtbox.Clear();
            SalaryLoanTxtbox.Clear();
            OtherLoanTxtBox.Clear();
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File|*.gif;*.jpg;*.png;*.bmp";
            openFileDialog.Title = "Select Employee Picture";
            openFileDialog.ShowDialog();
            picpath = openFileDialog.FileName;
            PicpathTxtbox.Text = picpath;
            pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BasicCutoffTxtbox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(BasicCutoffTxtbox.Text, out basic_numhrs) && double.TryParse(BasicRateTxtbox.Text, out basic_rate))
            {
                basic_netincome = basic_numhrs * basic_rate;
                BasicIncomeTxtbox.Text = basic_netincome.ToString("n");
            }
            else
            {
                BasicIncomeTxtbox.Text = "0.00";
            }
        }

        private void HonorariumCutoffTxtbox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(HonorariumCutoffTxtbox.Text, out hono_numhrs) && double.TryParse(HonorariumRateTxtbox.Text, out hono_rate))
            {
                hono_netincome = hono_numhrs * hono_rate;
                HonorariumIncomeTxtbox.Text = hono_netincome.ToString("n");
            }
            else
            {
                HonorariumIncomeTxtbox.Text = "0.00";
            }
        }

        private void OtherIncomeTxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
