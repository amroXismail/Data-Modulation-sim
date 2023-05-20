namespace WinFormsApp7
{
    partial class DgtlToDgtlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.polarity = new System.Windows.Forms.GroupBox();
            this.bipolarButton = new System.Windows.Forms.RadioButton();
            this.unipolarButton = new System.Windows.Forms.RadioButton();
            this.rZNRZ = new System.Windows.Forms.GroupBox();
            this.nrzButton = new System.Windows.Forms.RadioButton();
            this.rzButton = new System.Windows.Forms.RadioButton();
            this.polarity.SuspendLayout();
            this.rZNRZ.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 227);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 27);
            this.textBox1.TabIndex = 0;
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.enterButton.Location = new System.Drawing.Point(306, 306);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(190, 62);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Digital Data:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // polarity
            // 
            this.polarity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.polarity.Controls.Add(this.bipolarButton);
            this.polarity.Controls.Add(this.unipolarButton);
            this.polarity.Location = new System.Drawing.Point(39, 26);
            this.polarity.Name = "polarity";
            this.polarity.Size = new System.Drawing.Size(250, 125);
            this.polarity.TabIndex = 3;
            this.polarity.TabStop = false;
            this.polarity.Text = "Polarity:";
            // 
            // bipolarButton
            // 
            this.bipolarButton.AutoSize = true;
            this.bipolarButton.Location = new System.Drawing.Point(55, 63);
            this.bipolarButton.Name = "bipolarButton";
            this.bipolarButton.Size = new System.Drawing.Size(82, 24);
            this.bipolarButton.TabIndex = 1;
            this.bipolarButton.TabStop = true;
            this.bipolarButton.Text = "Bi-Polar";
            this.bipolarButton.UseVisualStyleBackColor = true;
            // 
            // unipolarButton
            // 
            this.unipolarButton.AutoSize = true;
            this.unipolarButton.Location = new System.Drawing.Point(55, 33);
            this.unipolarButton.Name = "unipolarButton";
            this.unipolarButton.Size = new System.Drawing.Size(91, 24);
            this.unipolarButton.TabIndex = 0;
            this.unipolarButton.TabStop = true;
            this.unipolarButton.Text = "Uni-Polar";
            this.unipolarButton.UseVisualStyleBackColor = true;
            // 
            // rZNRZ
            // 
            this.rZNRZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rZNRZ.Controls.Add(this.nrzButton);
            this.rZNRZ.Controls.Add(this.rzButton);
            this.rZNRZ.Location = new System.Drawing.Point(446, 26);
            this.rZNRZ.Name = "rZNRZ";
            this.rZNRZ.Size = new System.Drawing.Size(250, 125);
            this.rZNRZ.TabIndex = 4;
            this.rZNRZ.TabStop = false;
            this.rZNRZ.Text = "Return/Non-Return to Zero:";
            // 
            // nrzButton
            // 
            this.nrzButton.AutoSize = true;
            this.nrzButton.Location = new System.Drawing.Point(38, 63);
            this.nrzButton.Name = "nrzButton";
            this.nrzButton.Size = new System.Drawing.Size(72, 24);
            this.nrzButton.TabIndex = 1;
            this.nrzButton.Text = "NRZ-L";
            this.nrzButton.UseVisualStyleBackColor = true;
            // 
            // rzButton
            // 
            this.rzButton.AutoSize = true;
            this.rzButton.Location = new System.Drawing.Point(38, 33);
            this.rzButton.Name = "rzButton";
            this.rzButton.Size = new System.Drawing.Size(48, 24);
            this.rzButton.TabIndex = 0;
            this.rzButton.Text = "RZ";
            this.rzButton.UseVisualStyleBackColor = true;
            // 
            // DgtlToDgtlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp7.Properties.Resources.DDM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rZNRZ);
            this.Controls.Add(this.polarity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Name = "DgtlToDgtlForm";
            this.Text = "DgtlToDgtlForm";
            this.polarity.ResumeLayout(false);
            this.polarity.PerformLayout();
            this.rZNRZ.ResumeLayout(false);
            this.rZNRZ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button enterButton;
        private Label label1;
        private GroupBox polarity;
        private RadioButton bipolarButton;
        private RadioButton unipolarButton;
        private GroupBox rZNRZ;
        private RadioButton nrzButton;
        private RadioButton rzButton;
    }
}