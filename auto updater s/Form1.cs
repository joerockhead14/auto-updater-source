using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using HtmlAgilityPack;
using System.IO;
using System.Diagnostics;

namespace auto_updater_s
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int version = 1;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            string site = "";//version çekileceği url yazın.
            WebRequest ew = HttpWebRequest.Create(site);
            WebResponse y;
            y = ew.GetResponse();
            StreamReader inf = new StreamReader(y.GetResponseStream());
            string cm = inf.ReadToEnd();
            int st = cm.IndexOf("<p>") + 3;
            int bitis = cm.Substring(st).IndexOf("</p>");
            string joe = cm.Substring(st, bitis);
            version = Convert.ToInt16(joe);


            if (version == 1)
            {
                DialogResult secenek = MessageBox.Show("Güncelleme mevcut değil programı kullanmaya devam edebilirsiniz", "Joe Rockhead", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                    siticoneLabel2.Text = "Yok";



                }
                else if (secenek == DialogResult.No)
                {
                    siticoneLabel2.Text = "Yok";

                }
            }
            else
            {
                DialogResult secenek = MessageBox.Show("Güncelleme mevcut şimdi güncellemek istermisiniz?", "Joe Rockhead", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                    Process.Start("");//güncelleme olduğu zaman messageboxda evete basılınca yönlendirilecek url gir
                    siticoneLabel2.Text = "Var";



                }
                else if (secenek == DialogResult.No)
                {
                    siticoneLabel2.Text = "Var";
                    

                }


            }
        }
    }
}
