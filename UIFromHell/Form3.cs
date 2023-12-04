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
                this.webBrowser1.Navigate("https://www.google.com/search?sca_esv=587563184&sxsrf=AM9HkKk5nhx0xR0sT2NehpJVLk1FdZcpaA:1701660595696&q=rick+astley&tbm=isch&source=lnms&sa=X&ved=2ahUKEwiAt9ba6_SCAxU9AHkGHd3sAiwQ0pQJegQIEBAB&biw=1920&bih=923&dpr=1");
            }
            catch (Exception ex)
            {

            }
        }
    }
}
