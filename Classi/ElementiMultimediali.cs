using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esercizi.Classi
{
    public abstract class ElementiMultimediali
    {
        string name;

        public string Name { get => name; set => name = value; }
        public ElementiMultimediali(string name)
        {
            this.name = name;
        }
    }
}