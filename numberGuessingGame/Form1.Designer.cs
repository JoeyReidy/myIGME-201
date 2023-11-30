namespace numberGuessingGame
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
            this.startButton = new System.Windows.Forms.Button();
            this.lowTextBox = new System.Windows.Forms.TextBox();
            this.highTextBox = new System.Windows.Forms.TextBox();
            this.lowLabel = new System.Windows.Forms.Label();
            this.highLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(94, 142);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // lowTextBox
            // 
            this.lowTextBox.Location = new System.Drawing.Point(103, 50);
            this.lowTextBox.Name = "lowTextBox";
            this.lowTextBox.Size = new System.Drawing.Size(100, 20);
            this.lowTextBox.TabIndex = 1;
            this.lowTextBox.Text = "1";
            // 
            // highTextBox
            // 
            this.highTextBox.Location = new System.Drawing.Point(103, 83);
            this.highTextBox.Name = "highTextBox";
            this.highTextBox.Size = new System.Drawing.Size(100, 20);
            this.highTextBox.TabIndex = 2;
            this.highTextBox.Text = "100";
            // 
            // lowLabel
            // 
            this.lowLabel.AutoSize = true;
            this.lowLabel.Location = new System.Drawing.Point(12, 53);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(70, 13);
            this.lowLabel.TabIndex = 3;
            this.lowLabel.Text = "Low Number:";
            // 
            // highLabel
            // 
            this.highLabel.AutoSize = true;
            this.highLabel.Location = new System.Drawing.Point(12, 86);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(69, 13);
            this.highLabel.TabIndex = 4;
            this.highLabel.Text = "High Number";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(60, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(159, 13);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Enter Range of Values to Guess";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 177);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.highTextBox);
            this.Controls.Add(this.lowTextBox);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox lowTextBox;
        private System.Windows.Forms.TextBox highTextBox;
        private System.Windows.Forms.Label lowLabel;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}

