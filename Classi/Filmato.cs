using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esercizi.Classi
{
    public class Filmato : ElementiMultimediali, Riproduzione, Luminosita
    {
        private string titolo;
        public string Titolo { get => titolo; }
        public int Durata { get; set; }

        public void Play()
        {
            //istruzione
        }

        public Filmato(string titolo) : base(titolo)
        {
            this.titolo = titolo;
        }
    }
}