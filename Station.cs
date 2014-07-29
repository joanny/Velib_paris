using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Xml;
using System.Threading;

namespace Velib
{
    class Station
    {
        public string adresse { get; set; }
        public string arrondissement { get; set; }
        public bool bonus { get; set; }
        public string numero { get; set; }
        public bool ouvert { get; set; }


        public Station(string num, string adr, bool ouvert, bool bonus)
        {
            this.numero = num;
            this.adresse = adr;

            if (this.numero.Length == 5)
            {
                if (Convert.ToInt32(this.numero) >= 21000)
                    this.arrondissement = "9" + this.numero.Substring(0, 1);
                else
                    this.arrondissement = this.numero.Substring(0, 2);
            }
            else
                this.arrondissement = this.numero.Substring(0, 1);
           
            this.bonus = bonus;
            this.ouvert = ouvert;

        }
        public Station()
        {

        }

 
    }
}
