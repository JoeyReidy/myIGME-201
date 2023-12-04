using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFromHell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.exitButton.Click += new EventHandler(ExitButton__Click);
            this.enterButton.Click += new EventHandler(EnterButton__Click);
            this.timer1.Tick += new EventHandler(Timer__Tick);
        }
        private void Timer__Tick(object sender, EventArgs e)
        {
            this.progressBar1.Value--;
            if (this.progressBar1.Value <= 0)
            {
                this.timer1.Stop();
                this.textBox1.Visible = true;
                this.label2.Visible = false;
            }
        }
        private void ExitButton__Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EnterButton__Click(Object sender, EventArgs e)
        {
            if(this.textBox1.Text == "password")
            {
                Form form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                this.progressBar1.Value = 100;
                this.timer1.Start();
                this.textBox1.Visible = false;
                this.label2.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
