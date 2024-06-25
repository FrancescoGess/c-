using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Esercizi.Classi
{
    public class Immagine : ElementiMultimediali, Luminosita
    {
        public int Luminosita { get; set; }

        public Immagine(string name) : base(name)
        {
            this.Luminosita = 0;
        }
    }
}