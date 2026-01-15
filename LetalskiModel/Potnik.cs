using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetalskiModel
{
    public class Potnik : Oseba
    {
        public readonly string Potni_list;
        public int Prtljaga {  get; set; }


        public Potnik(string ime, string priimek, string potni_list, int prtljaga) : base(ime, priimek)
        {
            Potni_list = potni_list;
            Prtljaga = prtljaga;
        }

        public static Potnik operator +(Potnik a, Potnik b)
        {
            return new Potnik($"{a.Ime} + {b.Ime}", $"{a.Priimek} + {b.Priimek}", $"{a.Potni_list} + {b.Potni_list}", a.Prtljaga + b.Prtljaga);
        }

        public override string Opis()
        {
            return $"{Ime} {Priimek}, Potni list: {Potni_list}, Prtljaga: {Prtljaga}";
        }

        public static bool JeVeljavenPotniList(string pList)
        {
            return pList.Length >= 6;
        }
    }
}
