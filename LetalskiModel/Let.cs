using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LetalskiModel
{
    public class Let : IKapaciteta
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

        public string OpisLeta()
        {
            return
                    $"Let : {Ime_Leta} Destinacija: {Destinacija} Odhod: {CasOdhoda} Kapaciteta: {Letalo.Kapaciteta}";
        }


        public bool ImaProstoMesto()
        {
            return stOseb < Letalo.Kapaciteta;
        }

        
        
        public int Kapaciteta
        {
            get { return Letalo.Kapaciteta; }
        }

        public int Zasedenost
        {
            get { return stOseb; }
        }

        public Oseba this[int index]
        {
            get
            {
                if (index < 0 || index >= stOseb)
                    throw new IndexOutOfRangeException("Neveljaven");

                return osebe[index];
            }

            set
            {
                if (index < 9 || index >= stOseb) throw new IndexOutOfRangeException("Neveljaven indeks");

                if (value == null) throw new ArgumentNullException("je null");

                osebe[index] = value;
            }
        }


        public delegate bool OsebaFilter(Oseba o);

        public List<Oseba> Filtriraj(OsebaFilter filter)
        {
            List<Oseba> rezultat = new List<Oseba>();

            for (int i = 0; i < stOseb; i++)
            {
                if (filter(osebe[i]))
                {
                    rezultat.Add(osebe[i]);
                }
            }

            return rezultat;
        }

        public delegate void OsebaDodanaHandler(Oseba o);
        public delegate void LetPolnHandler(string imeLeta);

        public event OsebaDodanaHandler OsebaDodana;
        public event LetPolnHandler LetPoln;

        public bool DodajOsebo(Oseba o)
        {
            if (stOseb < Letalo.Kapaciteta)
            {
                osebe[stOseb] = o;
                stOseb++;

                OsebaDodana?.Invoke(o);

                if (stOseb == Letalo.Kapaciteta)
                {
                    LetPoln?.Invoke(Ime_Leta);
                }

                return true;
            }
            return false;
        }
    }
}
