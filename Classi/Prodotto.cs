using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esercizi.Classi
{
    public class Prodotto
    {
        string nome;
        string descrizione;
        float prezzo;
        int qta;
        private Categoria categoria;

        string id;

        public string Nome { get => nome; set => nome = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }
        public float Prezzo { get => prezzo; set => prezzo = value; }
        public int Qta { get => qta; set => qta = value; }
        public Categoria Categoria { get => categoria; set => categoria = value; }

        public string Id { get => id; }

        public Prodotto(string nome, string descrizione, double prezzo, int qta )
        {
            this.categoria = null;
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = (float)prezzo;
            this.qta = qta;
        }

    }
}