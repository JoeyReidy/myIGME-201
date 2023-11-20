namespace Chats
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.chatLabel = new System.Windows.Forms.Label();
            this.favoriteLabel = new System.Windows.Forms.Label();
            this.gameButton1 = new System.Windows.Forms.Button();
            this.gameButton2 = new System.Windows.Forms.Button();
            this.gameButton3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.meetupLabel = new System.Windows.Forms.Label();
            this.meetup1Label = new System.Windows.Forms.Label();
            this.meetupButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(630, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(170, 450);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // chatLabel
            // 
            this.chatLabel.AutoSize = true;
            this.chatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatLabel.Location = new System.Drawing.Point(202, 50);
            this.chatLabel.Name = "chatLabel";
            this.chatLabel.Size = new System.Drawing.Size(227, 42);
            this.chatLabel.TabIndex = 1;
            this.chatLabel.Text = "Game Chats";
            this.chatLabel.Click += new System.EventHandler(this.chatLabel_Click);
            // 
            // favoriteLabel
            // 
            this.favoriteLabel.AutoSize = true;
            this.favoriteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favoriteLabel.Location = new System.Drawing.Point(230, 130);
            this.favoriteLabel.Name = "favoriteLabel";
            this.favoriteLabel.Size = new System.Drawing.Size(0, 25);
            this.favoriteLabel.TabIndex = 2;
            // 
            // gameButton1
            // 
            this.gameButton1.Location = new System.Drawing.Point(67, 127);
            this.gameButton1.Name = "gameButton1";
            this.gameButton1.Size = new System.Drawing.Size(110, 23);
            this.gameButton1.TabIndex = 3;
            this.gameButton1.Text = "Sons of the Forest";
            this.gameButton1.UseVisualStyleBackColor = true;
            this.gameButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gameButton2
            // 
            this.gameButton2.Location = new System.Drawing.Point(257, 127);
            this.gameButton2.Name = "gameButton2";
            this.gameButton2.Size = new System.Drawing.Size(111, 23);
            this.gameButton2.TabIndex = 4;
            this.gameButton2.Text = "Rainbow Six Seige";
            this.gameButton2.UseVisualStyleBackColor = true;
            // 
            // gameButton3
            // 
            this.gameButton3.Location = new System.Drawing.Point(456, 127);
            this.gameButton3.Name = "gameButton3";
            this.gameButton3.Size = new System.Drawing.Size(75, 23);
            this.gameButton3.TabIndex = 5;
            this.gameButton3.Text = "Valorant";
            this.gameButton3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(76, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Counter-Strike";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(276, 274);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Roblox";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(456, 274);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "VRChat";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // meetupLabel
            // 
            this.meetupLabel.AutoSize = true;
            this.meetupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetupLabel.Location = new System.Drawing.Point(635, 50);
            this.meetupLabel.Name = "meetupLabel";
            this.meetupLabel.Size = new System.Drawing.Size(162, 42);
            this.meetupLabel.TabIndex = 13;
            this.meetupLabel.Text = "Meetups";
            // 
            // meetup1Label
            // 
            this.meetup1Label.AutoSize = true;
            this.meetup1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetup1Label.Location = new System.Drawing.Point(638, 130);
            this.meetup1Label.Name = "meetup1Label";
            this.meetup1Label.Size = new System.Drawing.Size(159, 20);
            this.meetup1Label.TabIndex = 14;
            this.meetup1Label.Text = "Valorant Watch Party";
            // 
            // meetupButton1
            // 
            this.meetupButton1.Location = new System.Drawing.Point(679, 153);
            this.meetupButton1.Name = "meetupButton1";
            this.meetupButton1.Size = new System.Drawing.Size(75, 23);
            this.meetupButton1.TabIndex = 15;
            this.meetupButton1.Text = "sign up";
            this.meetupButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.meetupButton1);
            this.Controls.Add(this.meetup1Label);
            this.Controls.Add(this.meetupLabel);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.gameButton3);
            this.Controls.Add(this.gameButton2);
            this.Controls.Add(this.gameButton1);
            this.Controls.Add(this.favoriteLabel);
            this.Controls.Add(this.chatLabel);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label chatLabel;
        private System.Windows.Forms.Label favoriteLabel;
        private System.Windows.Forms.Button gameButton1;
        private System.Windows.Forms.Button gameButton2;
        private System.Windows.Forms.Button gameButton3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label meetupLabel;
        private System.Windows.Forms.Label meetup1Label;
        private System.Windows.Forms.Button meetupButton1;
    }
}

