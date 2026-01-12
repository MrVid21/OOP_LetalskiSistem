using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetalskiModel
{
    public class PotniskoLetalo : Letalo
    {
        public bool Hrana {  get; set; }
        public int Stevardese { get; set; }

        public PotniskoLetalo(string model, string serijska, int kapaciteta, bool hrana, int stevardese) : base(model, serijska, kapaciteta)
        {
            Hrana = hrana;
            Stevardese = stevardese;
        }

        public override string Opis()
        {
            return base.Opis() + $"Stevardese: {Stevardese}";
        }
    }
}
