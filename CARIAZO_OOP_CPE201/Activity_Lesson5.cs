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
    public partial class Activity_Lesson5 : Form
    {
        public Activity_Lesson5()
        {
            InitializeComponent();
        }

        private void bIncomeIncomeTxtbox_TextChanged(object sender, EventArgs e)
        {
            // Basic Income computation
            double bIncomeRate = Double.Parse(bIncomeRateTxtbox.Text);
            double bIncomeNoOfHours = Double.Parse(bIncomeNoOfHoursTxtbox.Text);
            double bIncomeIncome = bIncomeRate * bIncomeNoOfHours;
            bIncomeIncomeTxtbox.Text = bIncomeIncome.ToString();
        }

        private void Activity_Lesson5_Load(object sender, EventArgs e)
        {

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
            // Honorary Income Computation
            double hIncomeRate = Double.Parse(hIncomeRateTxtbox.Text);
            double hIncomeNoOfHours = Double.Parse(hIncomeNoOfHoursTxtbox.Text);
            double hIncomeIncome = hIncomeRate * hIncomeNoOfHours;
            hIncomeIncomeTxtbox.Text = hIncomeIncome.ToString();
        }

        private void oIncomeIncomeTxtbox_TextChanged(object sender, EventArgs e)
        {
            // Other Income Computation
            double oIncomeRate = Double.Parse(oIncomeRateTxtbox.Text);
            double oIncomeNoOfHours = Double.Parse(oIncomeNoOfHoursTxtbox.Text);
            double oIncomeIncome = oIncomeRate * oIncomeNoOfHours;
            oIncomeIncomeTxtbox.Text = oIncomeIncome.ToString();
        }

        private void GrossIncomeTxtbox_TextChanged(object sender, EventArgs e)
        {
            // Gross Income Computation
            double bIncomeIncome = Double.Parse(bIncomeIncomeTxtbox.Text);
            double hIncomeIncome = Double.Parse(hIncomeIncomeTxtbox.Text);
            double oIncomeIncome = Double.Parse(oIncomeIncomeTxtbox.Text);
            double GrossIncome = bIncomeIncome + hIncomeIncome + oIncomeIncome;
            GrossIncomeTxtbox.Text = GrossIncomeTxtbox.ToString();
        }

        private void NetIncomeTxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
