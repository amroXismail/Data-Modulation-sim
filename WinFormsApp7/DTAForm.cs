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
    public partial class DTAForm : Form
    {
        public DTAForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] != '0' && textBox1.Text[i] != '1')
                {
                    MessageBox.Show("Invalid input, input should be binary data");
                    valid = false;
                    break;
                }
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter binary data");
                valid = false;
            }
            if (!aSKButton.Checked && !fSKButton.Checked && !pSKButton.Checked)
            {
                MessageBox.Show("Please choose a Shift Keying Method");
                valid = false;
            }
            if (valid)
            {
                DTADiagram dTADiagram = new DTADiagram();
                dTADiagram.digitalData = textBox1.Text;
                if (aSKButton.Checked)
                {
                    dTADiagram.sK = 1;
                }
                else if (fSKButton.Checked)
                {
                    dTADiagram.sK = 2;
                }
                else
                {
                    dTADiagram.sK = 3;
                }
                dTADiagram.ShowDialog();

            }
        }
    }
}
