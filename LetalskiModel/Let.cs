using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetalskiModel
{
    internal class Let
    {

        public string Ime_Leta {  get; set; }
        public string Destinacija { get; set; }
        public DateTime CasOdhoda { get; set; }

        public Letalo Letalo { get; set; }

        private Potnik[] potniki;
        private int stPotnikov;

        public Let(string ime_leta, string destinacija, DateTime cas, Letalo letalo)
        {
            Ime_Leta = ime_leta;
            Destinacija = destinacija;
            CasOdhoda = cas;
            Letalo = letalo;

            potniki = new Potnik[letalo.Kapaciteta];
            stPotnikov = 0;
        }

        public bool DodajPotnika(Potnik p)
        {
            if (stPotnikov < Letalo.Kapaciteta)
            {
                potniki[stPotnikov] = p;
                stPotnikov++;
                return true;
            }
            return false;
        }
    }
}
