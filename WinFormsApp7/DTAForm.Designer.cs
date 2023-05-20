namespace WinFormsApp7
{
    partial class DTAForm
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
            this.sKBox = new System.Windows.Forms.GroupBox();
            this.pSKButton = new System.Windows.Forms.RadioButton();
            this.fSKButton = new System.Windows.Forms.RadioButton();
            this.aSKButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.sKBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sKBox
            // 
            this.sKBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sKBox.Controls.Add(this.pSKButton);
            this.sKBox.Controls.Add(this.fSKButton);
            this.sKBox.Controls.Add(this.aSKButton);
            this.sKBox.Location = new System.Drawing.Point(248, 48);
            this.sKBox.Name = "sKBox";
            this.sKBox.Size = new System.Drawing.Size(250, 125);
            this.sKBox.TabIndex = 0;
            this.sKBox.TabStop = false;
            this.sKBox.Text = "Shift Keying";
            // 
            // pSKButton
            // 
            this.pSKButton.AutoSize = true;
            this.pSKButton.Location = new System.Drawing.Point(32, 88);
            this.pSKButton.Name = "pSKButton";
            this.pSKButton.Size = new System.Drawing.Size(55, 24);
            this.pSKButton.TabIndex = 2;
            this.pSKButton.Text = "PSK";
            this.pSKButton.UseVisualStyleBackColor = true;
            // 
            // fSKButton
            // 
            this.fSKButton.AutoSize = true;
            this.fSKButton.Location = new System.Drawing.Point(32, 58);
            this.fSKButton.Name = "fSKButton";
            this.fSKButton.Size = new System.Drawing.Size(54, 24);
            this.fSKButton.TabIndex = 1;
            this.fSKButton.Text = "FSK";
            this.fSKButton.UseVisualStyleBackColor = true;
            // 
            // aSKButton
            // 
            this.aSKButton.AutoSize = true;
            this.aSKButton.Location = new System.Drawing.Point(32, 26);
            this.aSKButton.Name = "aSKButton";
            this.aSKButton.Size = new System.Drawing.Size(57, 24);
            this.aSKButton.TabIndex = 0;
            this.aSKButton.Text = "ASK";
            this.aSKButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 299);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Digital Data:";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(267, 351);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(231, 58);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // DTAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp7.Properties.Resources.DDM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sKBox);
            this.DoubleBuffered = true;
            this.Name = "DTAForm";
            this.Text = "DTAForm";
            this.sKBox.ResumeLayout(false);
            this.sKBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox sKBox;
        private RadioButton pSKButton;
        private RadioButton fSKButton;
        private RadioButton aSKButton;
        private TextBox textBox1;
        private Label label1;
        private Button enterButton;
    }
}