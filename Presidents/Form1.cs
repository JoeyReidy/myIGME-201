using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presidents
{
    public partial class Form1 : Form
    {
        private bool[] answers = new bool[16];
        public Form1()
        {
            Console.WriteLine("test");
            InitializeComponent();
            this.harrisonRadioButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
            this.dRooseveltRadioButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
            this.clintonRadioButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
            this.buchananRadioButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
            this.pierceRadioButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
            this.bushRadioButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
            this.obamaRadioButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
            this.kennedyRadioButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
            this.mckinleyRadioButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
            this.reaganRadioButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
            this.eisenhowerRadioButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
            this.vanburenRadioButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
            this.washingtonRadioButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
            this.adamsRadioButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
            this.tRooseveltRadioButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);
            this.jeffersonRadioButton.CheckedChanged += new EventHandler(PresidentRadioButton__CheckedChanged);

            this.harrisonTextBox.TextChanged += new EventHandler(HarrisonTextBox__TextChanged);
            this.dRooseveltTextBox.TextChanged += new EventHandler(DRooseveltTextBox__TextChanged);
            this.clintonTextBox.TextChanged += new EventHandler(ClintonTextBox__TextChanged);
            this.buchananTextBox.TextChanged += new EventHandler(BuchananTextBox__TextChanged);
            this.pierceTextBox.TextChanged += new EventHandler(PierceTextBox__TextChanged);
            this.bushTextBox.TextChanged += new EventHandler(BushTextBox__TextChanged);
            this.obamaTextBox.TextChanged += new EventHandler(ObamaTextBox__TextChanged);
            this.kennedyTextBox.TextChanged += new EventHandler(KennedyTextBox__TextChanged);
            this.mckinleyTextBox.TextChanged += new EventHandler(MckinleyTextBox__TextChanged);
            this.reaganTextBox.TextChanged += new EventHandler(ReaganTextBox__TextChanged);
            this.eisenhowerTextBox.TextChanged += new EventHandler(EisenhowerTextBox__TextChanged);
            this.vanburenTextBox.TextChanged += new EventHandler(VanburenTextBox__TextChanged);
            this.washingtonTextBox.TextChanged += new EventHandler(WashingtonTextBox__TextChanged);
            this.adamsTextBox.TextChanged += new EventHandler(AdamsTextBox__TextChanged);
            this.tRooseveltextBox.TextChanged += new EventHandler(TRooseveltTextBox__TextChanged);
            this.jeffersonTextBox.TextChanged += new EventHandler(JeffersonTextBox__TextChanged);

            this.harrisonTextBox.KeyPress += new KeyPressEventHandler(Textbox__KeyPress);
            this.dRooseveltTextBox.KeyPress += new KeyPressEventHandler(Textbox__KeyPress);
            this.clintonTextBox.KeyPress += new KeyPressEventHandler(Textbox__KeyPress);
            this.buchananTextBox.KeyPress += new KeyPressEventHandler(Textbox__KeyPress);
            this.pierceTextBox.KeyPress += new KeyPressEventHandler(Textbox__KeyPress);
            this.bushTextBox.KeyPress += new KeyPressEventHandler(Textbox__KeyPress);
            this.obamaTextBox.KeyPress += new KeyPressEventHandler(Textbox__KeyPress);
            this.kennedyTextBox.KeyPress += new KeyPressEventHandler(Textbox__KeyPress);
            this.mckinleyTextBox.KeyPress += new KeyPressEventHandler(Textbox__KeyPress);
            this.reaganTextBox.KeyPress += new KeyPressEventHandler(Textbox__KeyPress);
            this.eisenhowerTextBox.KeyPress += new KeyPressEventHandler(Textbox__KeyPress);
            this.vanburenTextBox.KeyPress += new KeyPressEventHandler(Textbox__KeyPress);
            this.washingtonTextBox.KeyPress += new KeyPressEventHandler(Textbox__KeyPress);
            this.adamsTextBox.KeyPress += new KeyPressEventHandler(Textbox__KeyPress);
            this.tRooseveltextBox.KeyPress += new KeyPressEventHandler(Textbox__KeyPress);
            this.jeffersonTextBox.KeyPress += new KeyPressEventHandler(Textbox__KeyPress);

            this.pictureBox.MouseEnter += new EventHandler(pictureBox__MouseEnter);
            this.pictureBox.MouseLeave += new EventHandler(pictureBox__MouseLeave);

            this.allRadioButton.CheckedChanged += new EventHandler(AllRadioButton__CheckChanged);
            this.democratRadioButton.CheckedChanged += new EventHandler(DemocratRadioButton__CheckChanged);
            this.republicanRadioButton.CheckedChanged += new EventHandler(RepublicanRadioButton__CheckChanged);
            this.drRadioButton.CheckedChanged += new EventHandler(DRRadioButton__CheckChanged);
            this.federalistRadioButton.CheckedChanged += new EventHandler(FederalistRadioButton__CheckChanged);

            this.timer1.Tick += new EventHandler(Timer__Tick);
            this.timer1.Start();
        }

        private void AllRadioButton__CheckChanged(object sender, EventArgs e)
        {
            this.harrisonRadioButton.Visible = true;
            this.dRooseveltRadioButton.Visible = true;
            this.clintonRadioButton.Visible = true;
            this.buchananRadioButton.Visible = true;
            this.pierceRadioButton.Visible = true;
            this.bushRadioButton.Visible = true;
            this.obamaRadioButton.Visible = true;
            this.kennedyRadioButton.Visible = true;
            this.mckinleyRadioButton.Visible = true;
            this.reaganRadioButton.Visible = true;
            this.eisenhowerRadioButton.Visible = true;
            this.vanburenRadioButton.Visible = true;
            this.washingtonRadioButton.Visible = true;
            this.adamsRadioButton.Visible = true;
            this.tRooseveltRadioButton.Visible = true;
            this.jeffersonRadioButton.Visible = true;
        }
        private void DemocratRadioButton__CheckChanged(object sender, EventArgs e)
        {
            this.harrisonRadioButton.Visible = false;
            this.dRooseveltRadioButton.Visible = true;
            this.clintonRadioButton.Visible = true;
            this.buchananRadioButton.Visible = true;
            this.pierceRadioButton.Visible = true;
            this.bushRadioButton.Visible = false;
            this.obamaRadioButton.Visible = true;
            this.kennedyRadioButton.Visible = true;
            this.mckinleyRadioButton.Visible = false;
            this.reaganRadioButton.Visible = false;
            this.eisenhowerRadioButton.Visible = false;
            this.vanburenRadioButton.Visible = true;
            this.washingtonRadioButton.Visible = false;
            this.adamsRadioButton.Visible = false;
            this.tRooseveltRadioButton.Visible = false;
            this.jeffersonRadioButton.Visible = false;
        }
        private void RepublicanRadioButton__CheckChanged(object sender, EventArgs e)
        {
            this.harrisonRadioButton.Visible = true;
            this.dRooseveltRadioButton.Visible = false;
            this.clintonRadioButton.Visible = false;
            this.buchananRadioButton.Visible = false;
            this.pierceRadioButton.Visible = false;
            this.bushRadioButton.Visible = true;
            this.obamaRadioButton.Visible = false;
            this.kennedyRadioButton.Visible = false;
            this.mckinleyRadioButton.Visible = true;
            this.reaganRadioButton.Visible = true;
            this.eisenhowerRadioButton.Visible = true;
            this.vanburenRadioButton.Visible = false;
            this.washingtonRadioButton.Visible = false;
            this.adamsRadioButton.Visible = false;
            this.tRooseveltRadioButton.Visible = true;
            this.jeffersonRadioButton.Visible = false;
        }
        private void DRRadioButton__CheckChanged(object sender, EventArgs e)
        {
            this.harrisonRadioButton.Visible = false;
            this.dRooseveltRadioButton.Visible = false;
            this.clintonRadioButton.Visible = false;
            this.buchananRadioButton.Visible = false;
            this.pierceRadioButton.Visible = false;
            this.bushRadioButton.Visible = false;
            this.obamaRadioButton.Visible = false;
            this.kennedyRadioButton.Visible = false;
            this.mckinleyRadioButton.Visible = false;
            this.reaganRadioButton.Visible = false;
            this.eisenhowerRadioButton.Visible = false;
            this.vanburenRadioButton.Visible = false;
            this.washingtonRadioButton.Visible = false;
            this.adamsRadioButton.Visible = false;
            this.tRooseveltRadioButton.Visible = false;
            this.jeffersonRadioButton.Visible = true;
        }
        private void FederalistRadioButton__CheckChanged(object sender, EventArgs e)
        {
            this.harrisonRadioButton.Visible = false;
            this.dRooseveltRadioButton.Visible = false;
            this.clintonRadioButton.Visible = false;
            this.buchananRadioButton.Visible = false;
            this.pierceRadioButton.Visible = false;
            this.bushRadioButton.Visible = false;
            this.obamaRadioButton.Visible = false;
            this.kennedyRadioButton.Visible = false;
            this.mckinleyRadioButton.Visible = false;
            this.reaganRadioButton.Visible = false;
            this.eisenhowerRadioButton.Visible = false;
            this.vanburenRadioButton.Visible = false;
            this.washingtonRadioButton.Visible = true;
            this.adamsRadioButton.Visible = true;
            this.tRooseveltRadioButton.Visible = false;
            this.jeffersonRadioButton.Visible = false;
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            this.progressBar1.Value--;
            if(this.progressBar1.Value <= 0)
            {
                this.harrisonTextBox.Text = "0";
                this.dRooseveltTextBox.Text = "0";
                this.clintonTextBox.Text = "0";
                this.buchananTextBox.Text = "0";
                this.pierceTextBox.Text = "0";
                this.bushTextBox.Text = "0";
                this.obamaTextBox.Text = "0";
                this.kennedyTextBox.Text = "0";
                this.mckinleyTextBox.Text = "0";
                this.reaganTextBox.Text = "0";
                this.eisenhowerTextBox.Text = "0";
                this.vanburenTextBox.Text = "0";
                this.washingtonTextBox.Text = "0";
                this.adamsTextBox.Text = "0";
                this.tRooseveltextBox.Text = "0";
                this.jeffersonTextBox.Text = "0";

                for (int i = 0;i < 15;i++)
                {
                    answers[i] = false;
                }
                this.progressBar1.Value = 120;
            }
        }

        private void PresidentRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (this.harrisonRadioButton.Checked)
            {
                this.pictureBox.Load("media/BenjaminHarrison.jpeg");
                this.webBrowser.Navigate(new Uri("https://en.m.wikipedia.org/wiki/Benjamin_Harrison"));
            }
            else if(this.dRooseveltRadioButton.Checked)
            {
                this.pictureBox.Load("media/FranklinDRoosevelt.jpeg");
                this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt");
            }
            else if (this.clintonRadioButton.Checked)
            {
                this.pictureBox.Load("media/WilliamJClinton.jpeg");
                this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/William_J_Clinton");
            }
            else if (this.buchananRadioButton.Checked)
            {
                this.pictureBox.Load("media/JamesBuchanan.jpeg");
                this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/James_Buchanan");
            }
            else if (this.pierceRadioButton.Checked)
            {
                this.pictureBox.Load("media/FranklinPierce.jpeg");
                this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Franklin_Pierce");
            }
            else if (this.bushRadioButton.Checked)
            {
                this.pictureBox.Load("media/GeorgeWBush.jpeg");
                this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/George_W_Bush");
            }
            else if (this.obamaRadioButton.Checked)
            {
                this.pictureBox.Load("media/BarackObama.png");
                this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/BarackObama");
            }
            else if (this.kennedyRadioButton.Checked)
            {
                this.pictureBox.Load("media/JohnFKennedy.jpeg");
                this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/John_F_Kennedy");
            }
            else if (this.mckinleyRadioButton.Checked)
            {
                this.pictureBox.Load("media/WilliamMcKinley.jpeg");
                this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/William_McKinley");
            }
            else if (this.reaganRadioButton.Checked)
            {
                this.pictureBox.Load("media/RonaldReagan.jpeg");
                this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Ronald_Reagan");
            }
            else if (this.eisenhowerRadioButton.Checked)
            {
                this.pictureBox.Load("media/DwightDEisenhower.jpeg");
                this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Dwight_D_Eisenhower");
            }
            else if (this.vanburenRadioButton.Checked)
            {
                this.pictureBox.Load("media/MartinVanBuren.jpeg");
                this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Martin_VanBuren");
            }
            else if (this.washingtonRadioButton.Checked)
            {
                this.pictureBox.Load("media/GeorgeWashington.jpeg");
                this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/George_Washington");
            }
            else if (this.adamsRadioButton.Checked)
            {
                this.pictureBox.Load("media/JohnAdams.jpeg");
                this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/John_Adams");
            }
            else if (this.tRooseveltRadioButton.Checked)
            {
                this.pictureBox.Load("media/TheodoreRoosevelt.jpeg");
                this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Theodore_Roosevelt");
            }
            else if (this.jeffersonRadioButton.Checked)
            {
                this.pictureBox.Load("media/ThomasJefferson.jpeg");
                this.webBrowser.Navigate("https://en.m.wikipedia.org/wiki/Thomas_Jefferson");
            }
        }

        private void Textbox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void HarrisonTextBox__TextChanged(object sender, EventArgs e)
        {
            if(this.harrisonTextBox.Text == "23")
            {
                answers[0] = true;
                CheckAnswers();
            }
        }
        private void DRooseveltTextBox__TextChanged(object sender, EventArgs e)
        {
            if (this.dRooseveltTextBox.Text == "32")
            {
                answers[1] = true;
                CheckAnswers();
            }
        }
        private void ClintonTextBox__TextChanged(object sender, EventArgs e)
        {
            if (this.clintonTextBox.Text == "42")
            {
                answers[2] = true;
                CheckAnswers();
            }
        }
        private void BuchananTextBox__TextChanged(object sender, EventArgs e)
        {
            if (this.buchananTextBox.Text == "15")
            {
                answers[3] = true;
                CheckAnswers();
            }
        }
        private void PierceTextBox__TextChanged(object sender, EventArgs e)
        {
            if (this.pierceTextBox.Text == "14")
            {
                answers[4] = true;
                CheckAnswers();
            }
        }
        private void BushTextBox__TextChanged(object sender, EventArgs e)
        {
            if (this.bushTextBox.Text == "43")
            {
                answers[5] = true;
                CheckAnswers();
            }
        }
        private void ObamaTextBox__TextChanged(object sender, EventArgs e)
        {
            if (this.obamaTextBox.Text == "44")
            {
                answers[6] = true;
                CheckAnswers();
            }
        }
        private void KennedyTextBox__TextChanged(object sender, EventArgs e)
        {
            if (this.kennedyTextBox.Text == "35")
            {
                answers[7] = true;
                CheckAnswers();
            }
        }
        private void MckinleyTextBox__TextChanged(object sender, EventArgs e)
        {
            if (this.mckinleyTextBox.Text == "25")
            {
                answers[8] = true;
                CheckAnswers();
            }
        }
        private void ReaganTextBox__TextChanged(object sender, EventArgs e)
        {
            if (this.reaganTextBox.Text == "40")
            {
                answers[9] = true;
                CheckAnswers();
            }
        }
        private void EisenhowerTextBox__TextChanged(object sender, EventArgs e)
        {
            if (this.eisenhowerTextBox.Text == "34")
            {
                answers[10] = true;
                CheckAnswers();
            }
        }
        private void VanburenTextBox__TextChanged(object sender, EventArgs e)
        {
            if (this.vanburenTextBox.Text == "8")
            {
                answers[11] = true;
                CheckAnswers();
            }
        }
        private void WashingtonTextBox__TextChanged(object sender, EventArgs e)
        {
            if (this.washingtonTextBox.Text == "1")
            {
                answers[12] = true;
                CheckAnswers();
            }
        }
        private void AdamsTextBox__TextChanged(object sender, EventArgs e)
        {
            if (this.adamsTextBox.Text == "2")
            {
                answers[13] = true;
                CheckAnswers();
            }
        }
        private void TRooseveltTextBox__TextChanged(object sender, EventArgs e)
        {
            if (this.tRooseveltextBox.Text == "26")
            {
                answers[14] = true;
                CheckAnswers();
            }
        }
        private void JeffersonTextBox__TextChanged(object sender, EventArgs e)
        {
            if (this.jeffersonTextBox.Text == "3")
            {
                answers[15] = true;
                CheckAnswers();
            }
        }

        private void CheckAnswers()
        {
            foreach (bool answer in answers)
            {
                if(answer == true)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("incorrect");
                    return;
                }
            }
            this.timer1.Stop();
            Console.WriteLine("finished!");
            this.webBrowser.Navigate("https://media3.giphy.com/media/TmT51OyQLFD7a/giphy.gif?cid=ecf05e476ebilca0jiaj8i1ww2s8sjfkd5ulpbbuw9s8j2yq&ep=v1_gifs_search&rid=giphy.gif&ct=g");
        }

        private void pictureBox__MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox.Size = new Size(290, 400);
        }

        private void pictureBox__MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox.Size = new Size(145, 200);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
