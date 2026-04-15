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
    public partial class while_loop2 : Form
    {
        public while_loop2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int InitialValue = 0;
            int numTimesDisplay;
            numTimesDisplay = Convert.ToInt32(numTimesDisplayTextbox.Text);
            do
            {
                displayListBox.Items.Add(countryCombobox.Text);
                InitialValue++;
            } while (InitialValue <= numTimesDisplay);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void while_loop2_Load(object sender, EventArgs e)
        {
            countryCombobox.Items.Add("Japan");
            countryCombobox.Items.Add("Canada");
            countryCombobox.Items.Add("China");
            countryCombobox.Items.Add("Taiwan");
            countryCombobox.Items.Add("Philippines");
            countryCombobox.Items.Add("India");
            countryCombobox.Items.Add("Russia");
            countryCombobox.Items.Add("USA");
        }
    }
}
