using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Esercizi.Classi
{
    public class Audio : ElementiMultimediali, Riproduzione
    {
        public int Durata { get; set; }
        private int volume;
        public int Volume
        {
            get { return volume; }
            set
            {
                if (value < 0)
                {
                    volume = 0;
                }
                else if ( volume > 100 )
                {
                    volume = 100;
                }
            }
        }

        public Audio(int volume, string name) : base(name)
        {
            this.Volume = volume;
        }

        public void Play()
        {
            for(int i = 0; i < Durata; i++){
                Console.WriteLine
            }
        }
    }
}