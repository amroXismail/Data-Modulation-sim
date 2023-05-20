namespace WinFormsApp7
{
    partial class DDMMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgtlToDgtlButton = new System.Windows.Forms.Button();
            this.dTAButton = new System.Windows.Forms.Button();
            this.aTGButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dgtlToDgtlButton
            // 
            this.dgtlToDgtlButton.Location = new System.Drawing.Point(712, 279);
            this.dgtlToDgtlButton.Name = "dgtlToDgtlButton";
            this.dgtlToDgtlButton.Size = new System.Drawing.Size(230, 89);
            this.dgtlToDgtlButton.TabIndex = 0;
            this.dgtlToDgtlButton.Text = "Digital to Digital";
            this.dgtlToDgtlButton.UseVisualStyleBackColor = true;
            this.dgtlToDgtlButton.Click += new System.EventHandler(this.dgtlToDgtlButton_Click);
            // 
            // dTAButton
            // 
            this.dTAButton.Location = new System.Drawing.Point(178, 279);
            this.dTAButton.Name = "dTAButton";
            this.dTAButton.Size = new System.Drawing.Size(230, 89);
            this.dTAButton.TabIndex = 1;
            this.dTAButton.Text = "Digital To Analog";
            this.dTAButton.UseVisualStyleBackColor = true;
            this.dTAButton.Click += new System.EventHandler(this.dTAButton_Click);
            // 
            // aTGButton
            // 
            this.aTGButton.Location = new System.Drawing.Point(446, 438);
            this.aTGButton.Name = "aTGButton";
            this.aTGButton.Size = new System.Drawing.Size(230, 89);
            this.aTGButton.TabIndex = 2;
            this.aTGButton.Text = "Analog To Digital";
            this.aTGButton.UseVisualStyleBackColor = true;
            this.aTGButton.Click += new System.EventHandler(this.aTGButton_Click);
            // 
            // DDMMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::WinFormsApp7.Properties.Resources.DDMMain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1216, 748);
            this.Controls.Add(this.aTGButton);
            this.Controls.Add(this.dTAButton);
            this.Controls.Add(this.dgtlToDgtlButton);
            this.DoubleBuffered = true;
            this.Name = "DDMMainForm";
            this.Text = "Digital Data Modulator";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private Button dgtlToDgtlButton;
        private Button dTAButton;
        private Button aTGButton;
    }
}