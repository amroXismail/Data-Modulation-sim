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
    public partial class DgtlToDgtlForm : Form
    {
        public DgtlToDgtlForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            for(int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] != '0'&& textBox1.Text[i] != '1')
                {
                    MessageBox.Show("Invalid input, input should be binary data");
                    valid = false;
                    break;
                }
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter binary data");
                valid=false;
            }
            if (!unipolarButton.Checked && !bipolarButton.Checked)
            {
                MessageBox.Show("Please choose a Polarity");
                valid = false;
            }
            if(!rzButton.Checked && !nrzButton.Checked)
            {
                MessageBox.Show("Please choose RZ or NRZ");
                valid = false;
            }
            if (valid)
            {
                dgtlDiagram dgtldiagram = new dgtlDiagram();
                dgtldiagram.digitalData = textBox1.Text;
                if (unipolarButton.Checked)
                {
                    dgtldiagram.polarity = 1;
                }
                else
                {
                    dgtldiagram.polarity = 2;
                }
                if (rzButton.Checked)
                {
                    dgtldiagram.zState = 0;
                }
                else
                {
                    dgtldiagram.zState = 1;
                }
                dgtldiagram.ShowDialog();
            }
        }
    }
}
