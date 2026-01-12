using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetalskiModel
{
    public class Potnik
    {
        public string ime, priimek;

        public readonly string Potni_list;

        public int Prtljaga {  get; set; }

        public string Ime { get; set; }
        public string Priimek { get; set; }

        public Potnik(string ime, string priimek, string potni_list, int prtljaga)
        {
            Ime = ime;
            Priimek = priimek;
            Potni_list = potni_list;
            Prtljaga = prtljaga;
        }

        public static Potnik operator +(Potnik a, Potnik b)
        {
            return new Potnik($"{a.Ime} + {b.Ime}", $"{a.Priimek} + {b.Priimek}", $"{a.Potni_list} + {b.Potni_list}", a.Prtljaga + b.Prtljaga);
        }

        public override string ToString()
        {
            return $"{Ime} {Priimek}";
        }
    }
}
