using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9 // test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // By Angel
            var wc = new WebClient();
            //Download Page String .. 
            string sourceString = wc.DownloadString("https://pastebin.com/raw/fK79BjW7");
            //Fetch text from after word [ access_token ] 
            string s = Regex.Match(sourceString, "(?<=\"access_token\":\").+?(?=\")").Value;
            MessageBox.Show(s);
        }
    }
}
