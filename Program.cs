/*
1)Creazione di una classe con relativi tipi e attributi
2)Qualora c'è una relazione tra le classi, definirla (es. Prodotto ha una Categoria)
3)Refactor GET and SET
4)COSTRUTTORE (this.nome ecc)
5)In questo caso per aggiungere un prodotto, creo un metodo: public void addProdotto(Prodotto p){
        prodotti.Add(p); che richiamiamo nel MAIN all'occorenza
    }
*/


/*

ESERCIZIO EREDITARIETA’ e INTERFACCE

Un Elemento Multimediale è una Immagine, un Filmato o una registrazione Audio identificato da un titolo
(una stringa non vuota).


Un elemento è riproducibile se ha una durata (un valore positivo di tipo int) e un metodo play().


Una registrazione Audio è riproducibile e ha associato anche un volume (un valore positivo di tipo int) e i
metodi weaker() e louder() per regolarlo. Se riprodotta, ripete per un numero di volte pari alla durata la
stampa del titolo concatenato a una sequenza di punti esclamativi di lunghezza pari al volume (una stampa
per riga).

Un Filmato è riproducibile e ha associato un volume regolabile analogo a quello delle registrazioni audio e
anche una luminosità (un valore positivo di tipo int) e i metodi brighter() e darker() per regolarla. Se
riprodotta, ripete per un numero di volte pari alla durata la stampa del titolo concatenato a una sequenza
di punti esclamativi di lunghezza pari al volume e poi a una sequenza di asterischi di lunghezza pari alla
luminosità (una stampa per riga).

Una Immagine non è riproducibile, ma ha una luminosità regolabile analoga a quella dei filmati e un
metodo show() che stampa il titolo concatenato a una sequenza di asterischi di lunghezza pari alla
luminosità

Eseguire un oggetto multimediale significa invocarne il metodo show() se è un'immagine o il
metodo play() se è riproducibile.

Organizzare opportunamente con classi astratte, interfacce e classi concrete il codice di un lettore
multimediale che memorizza 5 elementi (creati con valori letti da tastiera) in un array e poi chiede
ripetutamente all'utente quale oggetto eseguire (leggendo un intero da 1 a 5 oppure 0 per finire) e dopo
ogni esecuzione fornisce la possibilità di regolarne eventuali parametri (volume / luminosità).

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