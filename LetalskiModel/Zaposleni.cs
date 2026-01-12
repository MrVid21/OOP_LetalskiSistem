using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetalskiModel
{
    public class Zaposleni : Oseba
    {
        public string Vloga { get; set; }

        public Zaposleni(string ime, string priimek, string vloga) : base(ime, priimek)
        {
            Vloga = vloga;
        }

        public override string Opis()
        {
            return $"{Ime} {Priimek}, Vloga: {Vloga}";
        }
    }
}
