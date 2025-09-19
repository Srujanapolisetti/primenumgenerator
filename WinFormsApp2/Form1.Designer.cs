namespace WinFormsApp2
{
    partial class Form1
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
            label1 = new System.Windows.Forms.Label();
            txtDigits = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnGenerate = new System.Windows.Forms.Button();
            lblPrimeResult = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(123, 110);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(128, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter number of digits:";
            // 
            // txtDigits
            // 
            txtDigits.BackColor = System.Drawing.SystemColors.Window;
            txtDigits.Location = new System.Drawing.Point(274, 107);
            txtDigits.Name = "txtDigits";
            txtDigits.Size = new System.Drawing.Size(164, 23);
            txtDigits.TabIndex = 1;
            txtDigits.TextChanged += txtDigits_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(123, 161);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Prime Number :";
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            btnGenerate.Location = new System.Drawing.Point(274, 251);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new System.Drawing.Size(164, 23);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Generate Prime";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += button1_Click;
            // 
            // lblPrimeResult
            // 
            lblPrimeResult.AutoSize = true;
            lblPrimeResult.Location = new System.Drawing.Point(274, 161);
            lblPrimeResult.Name = "lblPrimeResult";
            lblPrimeResult.Size = new System.Drawing.Size(38, 15);
            lblPrimeResult.TabIndex = 4;
            lblPrimeResult.Text = "prime";
            lblPrimeResult.Click += lblPrimeResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.InactiveCaption;
            ClientSize = new System.Drawing.Size(641, 337);
            Controls.Add(lblPrimeResult);
            Controls.Add(btnGenerate);
            Controls.Add(label2);
            Controls.Add(txtDigits);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDigits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblPrimeResult;
    }
}
