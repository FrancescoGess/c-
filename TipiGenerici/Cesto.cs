using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TipiGenerici
{
    public class Cesto<T> where T : Frutta
    {
        double peso;
        List<T> frutti;

        public Cesto()
        {
            frutti = new List<T>();
        }

        public void getPeso()
        {

            foreach (T frutto in frutti)
            {
                peso = peso + frutto.Peso;
            }
            
        Console.WriteLine(peso);

        }

        public void addFrutto(T frutto)
        {
            frutti.Add(frutto);
        }


    }
}