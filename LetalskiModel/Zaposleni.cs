using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetalskiModel
{
    public class Zaposleni : Oseba, IIdentifikacija
    {
        public string Vloga { get; set; }

        public Zaposleni(string ime, string priimek, string vloga, string id) : base(ime, priimek)
        {
            Vloga = vloga;
            Id = id;
        }

        public override string Opis()
        {
            return $"{Ime} {Priimek}, Vloga: {Vloga}";
        }

        public string Id { get; private set; }

    }
}
