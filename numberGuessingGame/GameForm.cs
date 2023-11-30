using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numberGuessingGame
{
    public partial class GameForm : Form
    {
        private int randInt;
        private int guesses = 0;
        public GameForm(int lowNumber, int highNumber)
        {
            InitializeComponent();
            Random rand = new Random();
            this.randInt = rand.Next(lowNumber, highNumber);
            this.progressBar1.Value = 45;
            this.timer1.Start();


            this.guessButton.Click += new EventHandler(GuessButton__Click);
            this.timer1.Tick += new EventHandler(Timer1__Tick);
        }

        private void GuessButton__Click(object sender, EventArgs e)
        {
            int guess = Int32.Parse(this.guessTextBox.Text);
            if(guess < this.randInt)
            {
                this.checkLabel.Text = guess + " is too low";
            }
            else if(guess > this.randInt)
            {
                this.checkLabel.Text = guess + " is too high";
            }
            else
            {
                MessageBox.Show($"Woohoo, you got it in {guesses} guesses!");
                this.timer1.Stop();
            }
            checkLabel.Visible = true;
            guesses++;
        }

        private void Timer1__Tick(object sender, EventArgs e)
        {
            --this.progressBar1.Value;
            if (this.progressBar1.Value == 0)
            {
                this.timer1.Stop();
                MessageBox.Show("Time's up!");
                this.Close();
            }
        }
    }
}
