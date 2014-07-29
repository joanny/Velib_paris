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
using System.IO;
using System.Xml;
using System.Diagnostics;

namespace Velib
{

     
    public partial class frmSt : Form
    {
        private Carte laCarte;
        private List<Station> lesStations;
        private string[] lesInfos;

        public frmSt()
        {
            InitializeComponent();
            laCarte = Passerelle.getCarte();
            lesStations = new List<Station>();
            this.setLesStations("1");
        }

        private void rdb1_Click(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations("18");
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        
        }
        private delegate void delegueChargeLabels(string[] str);
        public void getValAsynchrone(IAsyncResult asyn)
        {
            HttpWebRequest requete = (HttpWebRequest)asyn.AsyncState;
            HttpWebResponse rep = (HttpWebResponse)requete.EndGetResponse(asyn);
            StreamReader sr = new StreamReader(rep.GetResponseStream());
            XmlReader xml = XmlReader.Create(sr);
            string[] valeurs = new string[5];
            
            int i = 1;
            while (xml.Read())
            {
                string s = xml.Name;
                if (xml.NodeType == XmlNodeType.Text)
                    valeurs[i++] = xml.Value;
            }
            this.Invoke(new delegueChargeLabels(chargerLesLabels), new object[] { valeurs });

        }


        private void chargerLesLabels(string[] lesInfos)
        {

          
                Vdisponible.Text = lesInfos[0];
                this.Vdisponible.Text = lesInfos[1];
                this.NbAttache.Text = lesInfos[2];
                this.nbPointAttache.Text = lesInfos[3];
                if (lesInfos[4] == "1")
                    this.CB.Text = "oui";
                else
                    this.CB.Text = "non";
        }


       

        private void setLesStations(string n)
        {
            Console.WriteLine(this.lesStations.Count);
            this.lesStations.Clear();
            for (int i = 0; i < this.laCarte.getStations().Count; i++)
            {
                Station s = this.laCarte.getStation(i);
                if (s.arrondissement == n)
                    this.lesStations.Add(s);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void frmSt_Click(object sender, EventArgs e)
        {
            Console.WriteLine( sender.ToString());
        }

        private void dtVStations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ligne = e.RowIndex;

            Object o = this.dtVStations;
            string num = this.dtVStations[3, ligne].Value.ToString();
            string adr  = this.dtVStations[0, ligne].Value.ToString();
            this.lesInfos = Passerelle.getDispo(num, adr);
            label5.Text = this.dtVStations[0, ligne].Value.ToString();
            this.chargerLesLabels(lesInfos);
        }

        private void rdb3_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void rdb4_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void rdb5_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void rdb6_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void rdb12_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void rdb13_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void rdb14_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void rdb15_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void rdb16_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void rdb17_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void rdb18_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void rdb20_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void rdb92_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void rdb93_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            this.dtVStations.DataSource = null;
            string s = ((RadioButton)sender).Text;
            this.setLesStations(s);
            this.dtVStations.DataSource = this.lesStations;
            this.dtVStations.Columns["Numero"].Visible = false;
            this.dtVStations.Columns["Arrondissement"].Visible = false;
            this.dtVStations.Columns["Adresse"].Width = 250;
            this.dtVStations.Columns["Ouvert"].Width = 100;
            this.dtVStations.Columns["Bonus"].Width = 80; 
        }

        private void find_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "http://www.google.fr";
            p.Start(); 
        }
    }
}
