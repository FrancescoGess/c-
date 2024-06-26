
/*
1)Creazione di una classe con relativi tipi e attributi
2)Qualora c'è una relazione tra le classi, definirla (es. Prodotto ha una Categoria)
3)Refactor GET and SET
4)COSTRUTTORE (this.nome ecc)
5)In questo caso per aggiungere un prodotto, creo un metodo: public void addProdotto(Prodotto p){
        prodotti.Add(p); che richiamiamo nel MAIN all'occorenza
    }
*/
using System;
using System.Security.Cryptography.X509Certificates;
using TipiGenerici;


namespace Esercizi
{
    class Program
    {
        static void Main(string[] args)
        {
            Cesto<Frutta> cesto = new Cesto<Frutta>();
            Frutta frutta = new Frutta();
            Console.WriteLine("Inserisci il peso della frutta");
            frutta.Peso = Convert.ToInt32(Console.ReadLine());
            cesto.addFrutto(frutta);
            Console.WriteLine("Il peso è: ");
            cesto.getPeso();
        }
    }
}