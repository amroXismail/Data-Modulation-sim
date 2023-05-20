namespace WinFormsApp7
{
    partial class ATDForm
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
            this.showDataButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dMButton = new System.Windows.Forms.RadioButton();
            this.pCMButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // showDataButton
            // 
            this.showDataButton.Location = new System.Drawing.Point(279, 301);
            this.showDataButton.Name = "showDataButton";
            this.showDataButton.Size = new System.Drawing.Size(227, 62);
            this.showDataButton.TabIndex = 0;
            this.showDataButton.Text = "Show Data";
            this.showDataButton.UseVisualStyleBackColor = true;
            this.showDataButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dMButton);
            this.groupBox2.Controls.Add(this.pCMButton);
            this.groupBox2.Location = new System.Drawing.Point(268, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 125);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modulation";
            // 
            // dMButton
            // 
            this.dMButton.AutoSize = true;
            this.dMButton.Location = new System.Drawing.Point(49, 64);
            this.dMButton.Name = "dMButton";
            this.dMButton.Size = new System.Drawing.Size(54, 24);
            this.dMButton.TabIndex = 1;
            this.dMButton.TabStop = true;
            this.dMButton.Text = "DM";
            this.dMButton.UseVisualStyleBackColor = true;
            // 
            // pCMButton
            // 
            this.pCMButton.AutoSize = true;
            this.pCMButton.Location = new System.Drawing.Point(49, 34);
            this.pCMButton.Name = "pCMButton";
            this.pCMButton.Size = new System.Drawing.Size(60, 24);
            this.pCMButton.TabIndex = 0;
            this.pCMButton.TabStop = true;
            this.pCMButton.Text = "PCM";
            this.pCMButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 245);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 27);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Sine Wave Shift in Degrees°:";
            // 
            // ATDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp7.Properties.Resources.DDM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.showDataButton);
            this.DoubleBuffered = true;
            this.Name = "ATDForm";
            this.Text = "ATGForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button showDataButton;
        private GroupBox groupBox2;
        private RadioButton dMButton;
        private RadioButton pCMButton;
        private TextBox textBox1;
        private Label label1;
    }
}