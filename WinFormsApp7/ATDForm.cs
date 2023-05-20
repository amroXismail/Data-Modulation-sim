using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class ATDForm : Form
    {
        public ATDForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ATDDiagram diagram = new ATDDiagram();
            bool valid = true;
            if (!pCMButton.Checked && !dMButton.Checked)
            {
                MessageBox.Show("Please choose a Modulation");
                valid = false;
            }
            valid = int.TryParse(textBox1.Text, out diagram.shift);
            if (!valid)
            {
                MessageBox.Show("Please enter an integer");
            }
           
            if (valid)
            {
                
                if (pCMButton.Checked)
                {
                    diagram.modulation = false;
                }
                else
                {
                    diagram.modulation = true;
                }
                diagram.ShowDialog();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
