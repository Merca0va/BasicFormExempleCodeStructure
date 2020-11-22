using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0va_Informative_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton Rb = sender as RadioButton;

            if (Rb.Checked)
              {
                MessageBox.Show("Age confirmed. You can proceed.");
              }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string St = "You can code using ";

            if (checkBox1.Checked) { St = St + " " + checkBox1.Text ; }
            if (checkBox2.Checked) { St = St + " " + checkBox2.Text ; }
            if (checkBox3.Checked) { St = St + " " + checkBox3.Text ; }
            if (checkBox4.Checked) { St = St + " " + checkBox4.Text ; }
            if (checkBox5.Checked) { St = St + " " + checkBox5.Text ; }

            MessageBox.Show(St);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your preparation date ends on " + dateTimePicker1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Home");
            treeView1.Nodes.Add("Work");
            treeView1.Nodes.Add("Income");

            treeView1.Nodes[0].Nodes.Add("Location");
            treeView1.Nodes[0].Nodes.Add("Rent");
            treeView1.Nodes[1].Nodes.Add("Sector");
            treeView1.Nodes[1].Nodes.Add("Position");
            treeView1.Nodes[2].Nodes.Add("Salary");
            treeView1.Nodes[2].Nodes.Add("Savings");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }
    }
}
