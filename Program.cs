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
using Esercizi.Classi;


namespace Esercizi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Prodotto p = new Prodotto("Mastrolindo", "Descrizione a caso", 9.99, 10, null);
            //  Console.WriteLine(p.Nome);
            //  Console.WriteLine(p.Descrizione);
            //  Console.WriteLine(p.Prezzo);
            //  Console.WriteLine(p.Qta);
            //  Console.WriteLine(p.Categoria);
            //  Console.WriteLine("inserisci il tuo nome");
            //  string frase = Console.ReadLine();
            //  Console.WriteLine(frase);


            Categoria Detersivi = new Categoria("Detersivi", "Descrizione a caso");
            Prodotto Mastrolindo = new Prodotto("Mastrolindo", "Descrizione a caso", 9.99, 10);

            //  Detersivi.addProdotto(Mastrolindo);

            Console.WriteLine("numero prodotti");

            //creo una variabile che itera il numero di prodotti che voglio aggiungere
            int numeroProdotti = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numeroProdotti; i++)
            {
                Console.WriteLine("inserisci il nome del prodotto");
                string nome = Console.ReadLine();
                Console.WriteLine("Inserisci la descrizione");
                string descrizione = Console.ReadLine();
                Console.WriteLine("Inserisci il prezzo");
                float prezzo = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Inserisci la quantità");
                int qta = Convert.ToInt32(Console.ReadLine());

                //Richiamo il metodo addProdotto
                Prodotto p = new Prodotto(nome, descrizione, prezzo, qta);
                Detersivi.addProdotto(p);
            }

            Ordine ordine123 = new Ordine("123", "123", "123", "123");
            ordine123.addProdotto(Mastrolindo);
            */
        }
    }
}