using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetalskiModel
{
    public class Letalo
    {
        private string serijska_st;
        public string Model { get; set; }
        public int Kapaciteta { get; set; }

        public string Serijska_st
        {
            get { return serijska_st; }
            set { serijska_st = value; }
        }

        public static int steviloLetal = 0;

        public const int max_potnikov = 300;

        public Letalo(string model, string serijska_st, int kapaciteta)
        {
            Model = model;
            Serijska_st = serijska_st;
            Kapaciteta = kapaciteta;
            steviloLetal++;
        }

        public virtual string Opis()
        {
            return $"Model: {Model} Serijska: {Serijska_st} Kapaciteta: {Kapaciteta}";
        }

        ~Letalo()
        {
            steviloLetal--;
        }


    }
}
