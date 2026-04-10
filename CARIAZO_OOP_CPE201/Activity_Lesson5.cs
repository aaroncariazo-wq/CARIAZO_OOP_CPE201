using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARIAZO_OOP_CPE201
{
    public partial class Activity_Lesson5 : Form
    {
        // Declaration of global variables (since these needs to be used in different buttons.)
        double SSS;
        double PhilHealth;
        double PagIbig;
        double IncomeTax;
        double GrossIncome;

        public Activity_Lesson5()
        {
            InitializeComponent();
        }

        private void bIncomeIncomeTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Activity_Lesson5_Load(object sender, EventArgs e)
        {
            // Textboxes that need to be grayed out

            DepartmentTxtbox.Enabled = false;
            bIncomeIncomeTxtbox.Enabled = false;
            hIncomeIncomeTxtbox.Enabled = false;
            oIncomeIncomeTxtbox.Enabled = false;
            NetIncomeTxtbox.Enabled = false;
            SSScontributionTxtbox.Enabled = false;
            PhilHealthContributionTxtbox.Enabled = false;
            PagibigContributionTxtbox.Enabled = false;
            IncomeTaxContributionTxtbox.Enabled = false;
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            // Clear Textboxes when New Button clicked
            EmployeeNumberTxtbox.Clear();
            DepartmentTxtbox.Clear();

            bIncomeIncomeTxtbox.Clear();
            bIncomeRateTxtbox.Clear();
            bIncomeNoOfHoursTxtbox.Clear();

            hIncomeRateTxtbox.Clear();
            hIncomeNoOfHoursTxtbox.Clear();
            hIncomeIncomeTxtbox.Clear();

            oIncomeRateTxtbox.Clear();
            oIncomeIncomeTxtbox.Clear();
            oIncomeNoOfHoursTxtbox.Clear();

            GrossIncomeTxtbox.Clear();
            NetIncomeTxtbox.Clear();

            FirstNameTxtbox.Clear();
            MiddleNameTxtbox.Clear();
            SurnameTxtbox.Clear();
            CivilStatusTxtbox.Clear();
            QualifiedDependentsStatutsTxtbox.Clear();
            PaydateTxtbox.Clear();
            EmployeeStatusTxtbox.Clear();
            DesignationTxtbox.Clear();

            SSScontributionTxtbox.Clear();
            PhilHealthContributionTxtbox.Clear();
            PagibigContributionTxtbox.Clear();
            IncomeTaxContributionTxtbox.Clear();

            SSSloanTxtbox.Clear();
            PagibigLoanTxtbox.Clear();
            FacultySavingsLoanTxtbox.Clear();
            FacultySavingDepositTxtbox.Clear();
            SalaryLoanTxtbox.Clear();
            OtherLoanTxtbox.Clear();

            TotalDeductionTxtbox.Clear();

        }

        private void hIncomeIncomeTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void oIncomeIncomeTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GrossIncomeTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NetIncomeTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GrossIncomeBtn_Click(object sender, EventArgs e)
        {
            
            // Declaration for CutOff
            double bIncomeIncome;
            double hIncomeIncome;
            double oIncomeIncome;

            // Basic Income computation good
            double bIncomeRate = Double.Parse(bIncomeRateTxtbox.Text);
            double bIncomeNoOfHours = Double.Parse(bIncomeNoOfHoursTxtbox.Text);
            bIncomeIncome = bIncomeRate * bIncomeNoOfHours;

            // Honorary Income Computation 
            double hIncomeRate = Double.Parse(hIncomeRateTxtbox.Text);
            double hIncomeNoOfHours = Double.Parse(hIncomeNoOfHoursTxtbox.Text);
            hIncomeIncome = hIncomeRate * hIncomeNoOfHours;

            // Other Income Computation
            double oIncomeRate = Double.Parse(oIncomeRateTxtbox.Text);
            double oIncomeNoOfHours = Double.Parse(oIncomeNoOfHoursTxtbox.Text);
            oIncomeIncome = oIncomeRate * oIncomeNoOfHours;

            // Gross Income Computation
            GrossIncome = bIncomeIncome + hIncomeIncome + oIncomeIncome;

            // Net Income Computation


            // displaying computed values
            bIncomeIncomeTxtbox.Text = bIncomeIncome.ToString();
            hIncomeIncomeTxtbox.Text = hIncomeIncome.ToString();
            oIncomeIncomeTxtbox.Text = oIncomeIncome.ToString();
            GrossIncomeTxtbox.Text = GrossIncome.ToString();

            // REGULAR DEDUCTIONS
            // SSS Contribution Computations (table from book)
            SSS = 0;

            if (GrossIncome <= 5250)
                SSS = 250;
            else if (GrossIncome <= 5749.99)
                SSS = 275;
            else if (GrossIncome <= 6249.99)
                SSS = 300;
            else if (GrossIncome <= 6749.99)
                SSS = 325;
            else if (GrossIncome <= 7249.99)
                SSS = 350;
            else if (GrossIncome <= 7749.99)
                SSS = 375;
            else if (GrossIncome <= 8249.99)
                SSS = 400;
            else if (GrossIncome <= 8749.99)
                SSS = 425;
            else if (GrossIncome <= 9249.99)
                SSS = 450;
            else if (GrossIncome <= 9749.99)
                SSS = 475;
            else if (GrossIncome <= 10249.99)
                SSS = 500;
            else if (GrossIncome <= 10749.99)
                SSS = 525;
            else if (GrossIncome <= 11249.99)
                SSS = 550;
            else if (GrossIncome <= 11749.99)
                SSS = 575;
            else if (GrossIncome <= 12249.99)
                SSS = 600;
            else if (GrossIncome <= 12749.99)
                SSS = 625;
            else if (GrossIncome <= 13249.99)
                SSS = 650;
            else if (GrossIncome <= 13749.99)
                SSS = 675;
            else if (GrossIncome <= 14249.99)
                SSS = 700;
            else if (GrossIncome <= 14749.99)
                SSS = 725;
            else if (GrossIncome <= 15249.99)
                SSS = 750;
            else if (GrossIncome <= 15749.99)
                SSS = 775;
            else if (GrossIncome <= 16249.99)
                SSS = 800;
            else if (GrossIncome <= 16749.99)
                SSS = 825;
            else if (GrossIncome <= 17249.99)
                SSS = 850;
            else if (GrossIncome <= 17749.99)
                SSS = 875;
            else if (GrossIncome <= 18249.99)
                SSS = 900;
            else if (GrossIncome <= 18749.99)
                SSS = 925;
            else if (GrossIncome <= 19249.99)
                SSS = 950;
            else if (GrossIncome <= 19749.99)
                SSS = 975;
            else if (GrossIncome <= 20249.99)
                SSS = 1000;
            else if (GrossIncome <= 20749.99)
                SSS = 1025;
            else if (GrossIncome <= 21249.99)
                SSS = 1050;
            else if (GrossIncome <= 21749.99)
                SSS = 1075;
            else if (GrossIncome <= 22249.99)
                SSS = 1100;
            else if (GrossIncome <= 22749.99)
                SSS = 1125;
            else if (GrossIncome <= 23249.99)
                SSS = 1150;
            else if (GrossIncome <= 23749.99)
                SSS = 1175;
            else if (GrossIncome <= 24249.99)
                SSS = 1200;
            else if (GrossIncome <= 24749.99)
                SSS = 1225;
            else if (GrossIncome <= 25249.99)
                SSS = 1250;
            else if (GrossIncome <= 25749.99)
                SSS = 1275;
            else if (GrossIncome <= 26249.99)
                SSS = 1300;
            else if (GrossIncome <= 26749.99)
                SSS = 1325;
            else if (GrossIncome <= 27249.99)
                SSS = 1350;
            else if (GrossIncome <= 27749.99)
                SSS = 1375;
            else if (GrossIncome <= 28249.99)
                SSS = 1400;
            else if (GrossIncome <= 28749.99)
                SSS = 1425;
            else if (GrossIncome <= 29249.99)
                SSS = 1450;
            else if (GrossIncome <= 29749.99)
                SSS = 1475;
            else if (GrossIncome <= 30249.99)
                SSS = 1500;
            else if (GrossIncome <= 30749.99)
                SSS = 1525;
            else if (GrossIncome <= 31249.99)
                SSS = 1550;
            else if (GrossIncome <= 31749.99)
                SSS = 1575;
            else if (GrossIncome <= 32249.99)
                SSS = 1600;
            else if (GrossIncome <= 32749.99)
                SSS = 1625;
            else if (GrossIncome <= 33249.99)
                SSS = 1650;
            else if (GrossIncome <= 33749.99)
                SSS = 1675;
            else if (GrossIncome <= 34249.99)
                SSS = 1700;
            else if (GrossIncome <= 34749.99)
                SSS = 1725;
            else if (GrossIncome >= 34750)
                SSS = 1750;
            SSScontributionTxtbox.Text = SSS.ToString();


            // PhilHealth Contribution (0.025% of gross income)
            PhilHealth = GrossIncome * 0.025;
            PhilHealthContributionTxtbox.Text = PhilHealth.ToString();

            // PagIbig Contribution (fixed to 200)
            PagIbig = 200.00;
            PagibigContributionTxtbox.Text = PagIbig.ToString();

            // Income Tax Contribution (from book)
            IncomeTax = 0;
            if (GrossIncome <= 250000)
                IncomeTax = 0;
            else if (GrossIncome <= 400000)
                IncomeTax = (GrossIncome - 250000) * 0.15;
            else if (GrossIncome <= 800000)
                IncomeTax = ((GrossIncome - 400000) * 0.20) + 22500;
            else if (GrossIncome <= 2000000)
                IncomeTax = ((GrossIncome - 800000) * 0.25) + 102500;
            else if (GrossIncome <= 8000000)
                IncomeTax = ((GrossIncome - 2000000) * 0.30) + 402500;
            else if (GrossIncome >= 800000)
                IncomeTax = ((GrossIncome - 8000000) * 0.35) + 2202500;
            IncomeTaxContributionTxtbox.Text = IncomeTax.ToString();

        }

        private void NetIncomeBtn_Click(object sender, EventArgs e)
        {
            // NET INCOME BUTTON


            // Total Deductions
            double SSSloan = 0;
            double PagIbigLoan = 0;
            double FacultyDeposit = 0;
            double FacultyLoan = 0;
            double SalaryLoan = 0;
            double OtherLoan = 0;
            // So the textbox can be empty so use TryParse
            double.TryParse(SSSloanTxtbox.Text, out SSSloan);
            double.TryParse(PagibigLoanTxtbox.Text, out PagIbigLoan);
            double.TryParse(FacultySavingDepositTxtbox.Text, out FacultyDeposit);
            double.TryParse(FacultySavingsLoanTxtbox.Text, out FacultyLoan);
            double.TryParse(SalaryLoanTxtbox.Text, out SalaryLoan);
            double.TryParse(OtherLoanTxtbox.Text, out OtherLoan);

            double TotalDeduction = SSS + PhilHealth + PagIbig + IncomeTax + SSSloan + PagIbigLoan + FacultyDeposit + FacultyLoan + SalaryLoan + OtherLoan;
            TotalDeductionTxtbox.Text = TotalDeduction.ToString();

            // Net Income Computation
            double NetIncome;
            NetIncome = GrossIncome - TotalDeduction;
            NetIncomeTxtbox.Text = NetIncome.ToString();
        }
    }
}
