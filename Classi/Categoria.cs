using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Esercizi.Classi
{
    public class Categoria
    {
        string nome;
        string descrizione;
        string id;

        private List<Prodotto> prodotti;

        public string Nome { get => nome; set => nome = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }
        public string Id { get => id; }

        public List<Prodotto> Prodotti { get => prodotti; }

        public Categoria(string nome, string descrizione)
        {
            this.nome = nome;
            this.descrizione = descrizione;
            prodotti = new List<Prodotto>();
        }

        public void addProdotto(Prodotto p){
        prodotti.Add(p);
    }
    }

    


    
}