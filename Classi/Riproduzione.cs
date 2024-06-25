using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esercizi.Classi
{
    public interface Riproduzione
    {
        int Durata { get; set; }
        void Play();
    }
}