using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esercizi.Classi
{
    public interface Volume
    {
        int Volume { get; set; }
        void Weaker()
        {
            Volume++;
        }
        void Louder()
        {
            Volume--;
        }
    }
}