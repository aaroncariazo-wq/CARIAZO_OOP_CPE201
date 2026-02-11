using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARIAZO_OOP_CPE201
{
    public partial class Acitivity3 : Form
    {
        public Acitivity3()
        {
            InitializeComponent();
        }

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void Acitivity3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Civil Engineering");
            comboBox1.Items.Add("Computer Engineering");
            comboBox1.Items.Add("Electrical Engineering");
            comboBox1.Items.Add("Electronics Engineering");
            comboBox1.Items.Add("Industrial Engineering");
            comboBox1.Items.Add("Mechanical Engineering");

            comboBox1.DroppedDown = true;


        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Course_numlistBox.Items.Add(Course_Numbertxtbox.Text);
            Course_CodelistBox.Items.Add(Course_Codetxtbox.Text);
            Course_DesclistBox.Items.Add(Course_Desctxtbox.Text);
            Unit_LeclistBox.Items.Add(Unit_Lecturetxtbox.Text);
            Unit_LablistBox.Items.Add(Credit_Unitstxtbox.Text);
            Credit_UnitlistBox.Items.Add(Credit_Unitstxtbox.Text);
            TimelistBox.Items.Add(Timetxtbox.Text);
            DaylistBox.Items.Add(Daytxtbox.Text);

            Total_tuitionlowaertxtbox.Text = Total_Numunittxtbox.Text;
            Total_Misclowertxtbox.Text = Total_Miscfeetxtbox.Text;

            Tot_Untxtbox.Text = Total_Numunittxtbox.Text;
            Tot_taftxtbox.Text = Total_Tuitionfeetxtbox.Text;

            Comp_labfeetxtbox.Text = Laboratory_Feetxtbox.Text;
            Cisc_labfeetxtbox.Text = Cisco_labfeetxtbox.Text;
            ExBtxtbox.Text = Exam_Booklettxtbox.Text;
            Tot_otherfeetxtbox.Text = Tot_otherfeetxtbox.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student_Nametxtbox.Clear();
            Student_Numbertxtbox.Clear();
            Year_Leveltxtbox.Clear();
            Scholartxtbox.Clear();
            Course_Numbertxtbox.Clear();
            Course_Codetxtbox.Clear();
            Unit_Lecturetxtbox.Clear();
            Unit_Laboratorytxtbox.Clear();
            Timetxtbox.Clear();
            Daytxtbox.Clear();
            Credit_Unitstxtbox.Clear();
            Total_Numunittxtbox.Clear();
            Laboratory_Feetxtbox.Clear();
            Total_Tuitionfeetxtbox.Clear();
            Total_Miscfeetxtbox.Clear();
            Cisco_labfeetxtbox.Clear();
            Exam_Booklettxtbox.Clear();
            Total_tuitionandfeetxtbox.Clear();
            Total_tuitionlowaertxtbox.Clear();
            Total_Misclowertxtbox.Clear();
            Comp_labfeetxtbox.Clear();
            Cisc_labfeetxtbox.Clear();
            ExBtxtbox.Clear();
            Tot_Untxtbox.Clear();
            Tot_Untxtbox.Clear();
            Tot_taftxtbox.Clear();
            Course_Desctxtbox.Clear();
            Course_numlistBox.Items.Clear();
            Course_CodelistBox.Items.Clear();
            Course_DesclistBox.Items.Clear();
            Unit_LeclistBox.Items.Clear();
            Unit_LablistBox.Items.Clear();
            Credit_UnitlistBox.Items.Clear();
            TimelistBox.Items.Clear();
            DaylistBox.Items.Clear();
        }
    }
}
