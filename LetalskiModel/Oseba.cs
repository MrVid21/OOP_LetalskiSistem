using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetalskiModel
{
    public abstract class Oseba
    {
        public string Ime { get; set; }
        public string Priimek { get; set; }

        protected Oseba(string ime, string priimek)
        {
            Ime = ime;
            Priimek = priimek;
        }

        public abstract string Opis();
    }
}
