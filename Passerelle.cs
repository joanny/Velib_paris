using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Xml;
 
namespace Velib
{
    class Passerelle
    {
        private static string urlCarto = "http://www.velib.paris.fr/service/carto";
        private static string urlDispo = "http://www.velib.paris.fr/service/stationdetails/";

        public static Carte getCarte()
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(urlCarto);
                req.Method = WebRequestMethods.Http.Get;
                WebResponse rep = req.GetResponse();
                StreamReader sr = new StreamReader(rep.GetResponseStream());
                XmlReader xml = XmlReader.Create(sr);

                Carte c = new Carte();

                xml.ReadToFollowing("marker");
                do
                {
                    string num = xml.GetAttribute("number");
                    string adr = xml.GetAttribute("fullAddress");

                    Console.WriteLine(adr);
                    string open = xml.GetAttribute("open");
                    string bonus = xml.GetAttribute("bonus");

                    bool o = (open == "1");
                    bool b = (bonus == "1");

                    c.ajouteStation(num, adr, o, b);
                }
                while (xml.ReadToNextSibling("marker"));
                return c;

            }
            catch (Exception ex)
            {
                Console.Write((ex.Message));
                return null;
            }
        }

        public static string getUrlDispo() {
            return urlDispo;
        }

        public static string[] getDispo(string numero, string adresse)
        {
            try
            {
                string url = urlDispo + numero;
                
                Console.WriteLine(url);
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = WebRequestMethods.Http.Get;
                WebResponse rep = req.GetResponse();
                StreamReader sr = new StreamReader(rep.GetResponseStream());
                XmlReader xml = XmlReader.Create(sr);

                string[] valeurs = new string[5];
                int i = 1;
                valeurs[0] = adresse;
                while ( xml.Read())
                {
                    Console.WriteLine(xml.NodeType.ToString());
                    Console.WriteLine(XmlNodeType.Text.ToString());
                 
                  if (valeurs[i] == null){

                      if (xml.NodeType == XmlNodeType.Text)
                      {
                          valeurs[i] = xml.Value;
                          i = i + 1;
                      }
                      if (i == 4)
                      {
                          break;
                      }
                     
                  } 

                }
                return valeurs;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
       
    }
}
