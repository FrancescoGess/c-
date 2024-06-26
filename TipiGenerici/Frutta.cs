using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TipiGenerici
{
    public class Frutta
    {
        static int peso;

        public Frutta()
        {
            // Console.WriteLine("Inserisci il peso della frutta");
            // this.peso = Convert.ToInt32(Console.ReadLine());
        }

        public int Peso { get => peso; set => peso = value; }
    }
}