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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            this.button1.Click += new EventHandler(Button__Click);
        }
        private void Button__Click(object sender, EventArgs e)
        {
            try
            {
                this.webBrowser1.Navigate("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
            }
            catch (Exception ex)
            {

            }
        }
    }
}
