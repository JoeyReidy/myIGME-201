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
    public partial class Form2 : Form
    {
        private int index = 0;
        public Form2()
        {
            InitializeComponent();

            this.redRadioButton.Click += new EventHandler(RedRadioButton__Click);
            this.greenRadioButton.Click += new EventHandler(GreenRadioButton__Click);
            this.orangeRadioButton.Click += new EventHandler(OrangeRadioButton__Click);
            this.whiteRadioButton.Click += new EventHandler(WhiteRadioButton__Click);

            this.button1.Click += new EventHandler(Button__Click);

            this.pictureBox1.Click += new EventHandler(PictureBox__Click);

        }
        private void PictureBox__Click(object sender, EventArgs e)
        {
            if(this.progressBar1.Value <= 3)
            {
                this.progressBar1.Value++;
            }

            if(index == 0)
            {
                this.pictureBox1.Location = new Point(100, 80);
            }
            if (index == 1)
            {
                this.pictureBox1.Location = new Point(300, 40);
            }
            if (index == 2)
            {
                this.pictureBox1.Location = new Point(200, 200);
            }
            index++;
            if(this.progressBar1.Value == 3)
            {
                Form form3 = new Form3();
                form3.ShowDialog();
            }
        }

        private void RedRadioButton__Click(object sender, EventArgs e)
        {
            greenRadioButton.Checked = true;
        }
        private void GreenRadioButton__Click(object sender, EventArgs e)
        {
            orangeRadioButton.Checked = true;
        }
        private void OrangeRadioButton__Click(object sender, EventArgs e)
        {
            whiteRadioButton.Checked = true;
        }
        private void WhiteRadioButton__Click(object sender, EventArgs e)
        {
            redRadioButton.Checked = true;
        }

        private void Button__Click(object sender, EventArgs e)
        {
            if(orangeRadioButton.Checked)
            {
                this.label2.Visible = true;
                this.pictureBox1.Visible = true;
            }
        }
    } 
}
