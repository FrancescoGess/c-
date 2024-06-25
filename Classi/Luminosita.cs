using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esercizi.Classi
{
    public interface Luminosita
    {
        int Luminosita
        {
            get { return Luminosita; }
            set
            {
                if (Luminosita < 0)
                    Luminosita = 0;
                else if (Luminosita > 100)
                    Luminosita = 100;
            }
        }
        void Brighter()
        {
            Luminosita++;
        }
        void Darker()
        {
            Luminosita--;
        }
    }
}