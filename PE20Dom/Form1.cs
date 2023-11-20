using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE20Dom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            // add the delegate method to be called after the webpage loads, set this up before Navigate()
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);


            // if you want to use example.html from a local folder (saved in c:\temp for example):
            this.webBrowser1.Navigate("C:\\Users\\mjrei\\Downloads\\example_html\\example.html");

            // or if you want to use the URL  (only use one of these Navigate() statements)
            //this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");

        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            HtmlElementCollection h1 = webBrowser.Document.GetElementsByTagName("h1");
            h1[0].InnerText = "My UFO Page";

            HtmlElementCollection h2 = webBrowser.Document.GetElementsByTagName("h2");
            h2[0].InnerText = "My UFO info";
            h2[1].InnerText = "My UFO Pictures";
            h2[2].InnerText = "";

            HtmlElement body = webBrowser.Document.Body;
            body.Style = "font-family: sans-serif; color: #FF3333";

            HtmlElementCollection p = webBrowser.Document.GetElementsByTagName("p");
            p[0].InnerHtml = "Report your UFO sightings here: <a href = 'http://www.nuforc.org'>http://www.nuforc.org</a>";
            p[0].Style = "color: green; font-weight: bold; font-size: 2em; text-transform: uppercase; text-shadow: 3px 2px #A44";
            p[1].InnerText = "";

            HtmlElement img = webBrowser.Document.CreateElement("img");
            img.SetAttribute("src", "https://wp.inews.co.uk/wp-content/uploads/2020/12/PRI_177629797-1568x1205.jpg");
            p[2].InsertAdjacentElement(HtmlElementInsertionOrientation.AfterBegin, img);

            HtmlElement footer = webBrowser.Document.CreateElement("footer");
            footer.InnerHtml = "&copy; 2023 Joey Reidy";
            webBrowser.Document.Body.AppendChild(footer);
        }

    }

}
