namespace WinFormsApp7
{
    public partial class DDMMainForm : Form
    {
        public DDMMainForm()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void dgtlToDgtlButton_Click(object sender, EventArgs e)
        {
            DgtlToDgtlForm dgtlToDgtlForm = new DgtlToDgtlForm();
            dgtlToDgtlForm.ShowDialog();
        }

        private void dTAButton_Click(object sender, EventArgs e)
        {
            DTAForm dTAForm = new DTAForm();
            dTAForm.ShowDialog();
        }

        private void aTGButton_Click(object sender, EventArgs e)
        {
            ATDForm aTGForm = new ATDForm();
            aTGForm.ShowDialog();
        }
    }
}