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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }

        private void activity1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity1 newMDIChild = new Activity1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void activity2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity2 newMDIChild = new Activity2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void activity3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acitivity3 newMDIChild = new Acitivity3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void activity4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity4 newMDIChild = new Activity4();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void activity5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity5 newMDIChild = new Activity5();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void activity6prelimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity6_prelim newMDIChild = new Activity6_prelim();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void exampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Example5_Lesson7 newMDIChild = new Example5_Lesson7();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void example4Lesson7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Example4_Lesson7 newMDIChild = new Example4_Lesson7();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void example6Lesson7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while_loop2 newMDIChild = new while_loop2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
