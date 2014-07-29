using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Velib
{
    class Carte
    {
        private List<Station> mesStations { get; set; }
        
        public Carte()
        {
            this.mesStations = new List<Station>();
        }

        public void ajouteStation(string num, string adr, bool ouvert, bool bonus)
        {
            Station s = new Station(num, adr, ouvert, bonus);
            this.mesStations.Add(s);
        }

        public void ajouteStation(Station s)
        {             
            this.mesStations.Add(s);
        }
        public Station getStation(int i)
        {
            return this.mesStations.ToArray()[i];
        }
        public List<Station> getStations()
        {
            return this.mesStations;
        } 
    }
}
