using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LetalskiModel
{
    public class Let
    {

        public string Ime_Leta {  get; set; }
        public string Destinacija { get; set; }
        public DateTime CasOdhoda { get; set; }

        public Letalo Letalo { get; set; }

        private Oseba[] osebe;
        private int stOseb;

        public int StOseb 
        {
            get { return stOseb; }
            
        }

        public Let(string ime_leta, string destinacija, DateTime cas, Letalo letalo)
        {
            Ime_Leta = ime_leta;
            Destinacija = destinacija;
            CasOdhoda = cas;
            Letalo = letalo;

            osebe = new Oseba[letalo.Kapaciteta];
            stOseb = 0;
        }

        public bool DodajOsebo(Oseba o)
        {
            if (stOseb < Letalo.Kapaciteta)
            {
                osebe[stOseb] = o;
                stOseb++;
                return true;
            }
            return false;
        }

        public string[] SeznamOseb()
        {
            string[] seznam = new string[stOseb];
            for (int i = 0; i < stOseb; i++)
            {
                seznam[i] = osebe[i].Opis();
            }
            return seznam;
        }


        public static bool operator >(Let a, Let b)
        {
            return a.Letalo.Kapaciteta > b.Letalo.Kapaciteta;
        }

        public static bool operator <(Let a, Let b)
        {
            return a.Letalo.Kapaciteta < b.Letalo.Kapaciteta;
        }

        public override string ToString()
        {
            return $"{Ime_Leta}";
        }
    }
}
