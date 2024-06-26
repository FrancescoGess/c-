using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CampoTennis
{
    public class Prenotazione
    {
        int oraInizio;
        int oraFine;
        string cliente;

        public Prenotazione(int oraInizio, int oraFine, string cliente)
        {
            // this.oraInizio = oraInizio;
            // this.oraFine = oraFine;
            // this.cliente = cliente;
            OraInizio = oraInizio;
            oraFine = oraFine;
            cliente = cliente;
        }

        public int OraInizio { get => oraInizio; set => oraInizio = value; }
        public int OraFine { get => oraFine; set => oraFine = value; }

        public string Cliente { get => cliente; set => cliente = value; }
    }
}