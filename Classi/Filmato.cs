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

        private int luminosita;

        public int Luminosita
        {
            get { return luminosita; }
            set
            {
                if (value < 0)
                    luminosita = 0;
                else if (value > 100)
                    luminosita = 100;
                else luminosita = value;
            }
        }
        public void brighter()
        {
            for (int i = 0; i < 5; i++) ;
            Console.WriteLine("Di quanto vuoi alzare la luminosità?");
            
            for (int i=0; i < luminosita; i++){
                Console.WriteLine("*");
            }

        }

        public void darker()
        {
            luminosita--;
        }

        public Filmato(string titolo) : base(titolo)
        {
            this.titolo = titolo;
        }
    }
}