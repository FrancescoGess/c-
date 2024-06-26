using System;
using System.Security.Cryptography.X509Certificates;
using CampoTennis;


namespace Esercizi
{
    class Program
    {
        static void Main(string[] args)
        {
            Campo campo = new Campo();
            campo.addPren(1, 2, "Gianni");
            campo.addPren(2, 3, "Gianni");
            campo.addPren(3, 4, "Gianni");
        }
    }
}