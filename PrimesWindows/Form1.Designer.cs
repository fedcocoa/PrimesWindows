namespace PrimesWindows
{
    partial class Form1
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
            this.PrimeNoLabel = new System.Windows.Forms.Label();
            this.NumberSelection = new System.Windows.Forms.NumericUpDown();
            this.StartButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumberSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // PrimeNoLabel
            // 
            this.PrimeNoLabel.AutoSize = true;
            this.PrimeNoLabel.Location = new System.Drawing.Point(13, 13);
            this.PrimeNoLabel.Name = "PrimeNoLabel";
            this.PrimeNoLabel.Size = new System.Drawing.Size(90, 13);
            this.PrimeNoLabel.TabIndex = 1;
            this.PrimeNoLabel.Text = "Number of Primes";
            // 
            // NumberSelection
            // 
            this.NumberSelection.Location = new System.Drawing.Point(16, 30);
            this.NumberSelection.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.NumberSelection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberSelection.Name = "NumberSelection";
            this.NumberSelection.Size = new System.Drawing.Size(120, 20);
            this.NumberSelection.TabIndex = 2;
            this.NumberSelection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberSelection.ValueChanged += new System.EventHandler(this.NumberSelection_ValueChanged);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(16, 57);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(120, 23);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 426);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(560, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(143, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(429, 408);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(46, 87);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(13, 13);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.NumberSelection);
            this.Controls.Add(this.PrimeNoLabel);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "Primes - Rohan Dewan";
            ((System.ComponentModel.ISupportInitialize)(this.NumberSelection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PrimeNoLabel;
        private System.Windows.Forms.NumericUpDown NumberSelection;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimeLabel;
    }
}

