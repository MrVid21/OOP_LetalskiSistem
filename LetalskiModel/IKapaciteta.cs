using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetalskiModel
{
    public interface IKapaciteta
    {
        int Kapaciteta {  get; }
        int Zasedenost { get; }
        bool ImaProstoMesto();
        
    }
}
