namespace GuessingGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.panelTextBox = new System.Windows.Forms.Panel();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblStats = new System.Windows.Forms.Label();
            this.lblSecretNumber = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.lblResult);
            this.panelMain.Controls.Add(this.panelTextBox);
            this.panelMain.Controls.Add(this.btnGuess);
            this.panelMain.Controls.Add(this.lblStats);
            this.panelMain.Controls.Add(this.lblSecretNumber);
            this.panelMain.Location = new System.Drawing.Point(9, 10);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.panelMain.Size = new System.Drawing.Size(282, 265);
            this.panelMain.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblResult.Location = new System.Drawing.Point(15, 16);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(250, 49);
            this.lblResult.TabIndex = 0;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTextBox
            // 
            this.panelTextBox.Controls.Add(this.txtGuess);
            this.panelTextBox.Location = new System.Drawing.Point(66, 81);
            this.panelTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTextBox.Name = "panelTextBox";
            this.panelTextBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTextBox.Size = new System.Drawing.Size(150, 32);
            this.panelTextBox.TabIndex = 1;
            // 
            // txtGuess
            // 
            this.txtGuess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGuess.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtGuess.Location = new System.Drawing.Point(4, 4);
            this.txtGuess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(142, 32);
            this.txtGuess.TabIndex = 0;
            this.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuess.TextChanged += new System.EventHandler(this.txtGuess_TextChanged);
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuess.Location = new System.Drawing.Point(66, 122);
            this.btnGuess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(150, 37);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess";
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStats.ForeColor = System.Drawing.Color.Gray;
            this.lblStats.Location = new System.Drawing.Point(9, 236);
            this.lblStats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(0, 15);
            this.lblStats.TabIndex = 3;
            // 
            // lblSecretNumber
            // 
            this.lblSecretNumber.Location = new System.Drawing.Point(0, 0);
            this.lblSecretNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecretNumber.Name = "lblSecretNumber";
            this.lblSecretNumber.Size = new System.Drawing.Size(75, 19);
            this.lblSecretNumber.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(300, 284);
            this.Controls.Add(this.panelMain);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Guessing Game";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelTextBox.ResumeLayout(false);
            this.panelTextBox.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTextBox;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblSecretNumber;
        private System.Windows.Forms.Label lblStats;
    }
}

