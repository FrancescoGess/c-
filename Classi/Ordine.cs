using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esercizi.Classi
{
    public class Ordine
    {
        private string id;
        private string idCliente;
        // private string idProdotto;
        private string dataOrdine;
        private string statoOrdine;

        private List<Prodotto> prodottiOrdinati = new List<Prodotto>();

        public string Id { get => id; set => id = value; }
        public string IdCliente { get => idCliente; set => idCliente = value; }
        // public string IdProdotto { get => idProdotto; set => idProdotto = value; }

        public string DataOrdine { get => dataOrdine; set => dataOrdine = value; }
        public string StatoOrdine { get => statoOrdine; set => statoOrdine = value; }

        public Ordine (string id, string idCliente, string dataOrdine, string statoOrdine){
            this.id = id;
            this.idCliente = idCliente;
            this.dataOrdine = dataOrdine;
            this.statoOrdine = statoOrdine;
            prodottiOrdinati = new List<Prodotto>();
        }

        public void addProdotto(Prodotto p){
            prodottiOrdinati.Add(p);
        }
    }
}