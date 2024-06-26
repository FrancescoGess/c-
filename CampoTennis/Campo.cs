using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CampoTennis
{
    public class Campo
    {

        string nome;
        List<Prenotazione> prenotazioni;
        Prenotazione prenotazione;

        public Campo()
        {
            prenotazioni = new List<Prenotazione>();
            this.nome = nome;
        }
        public string Nome { get => nome; set => nome = value; }
        public List<Prenotazione> Prenotazioni { get => prenotazioni; set => prenotazioni = value; }

        public bool addPren(int oraInizio, int oraFine, string cliente)
        {
            if (oraInizio < 0 || oraFine < 0 || oraInizio >= oraFine || string.IsNullOrEmpty(cliente))
            {
                return false;
            }

            foreach (var prenotazione in prenotazioni)
            {
                if ((oraInizio >= prenotazione.OraInizio && oraInizio < prenotazione.OraFine) ||
                    (oraFine > prenotazione.OraInizio && oraFine <= prenotazione.OraFine) ||
                    (oraInizio <= prenotazione.OraInizio && oraFine >= prenotazione.OraFine))
                {
                    return false;
                }
            }

            Prenotazione pren = new Prenotazione(oraInizio, oraFine, cliente);
            Prenotazioni.Add(pren);
            return true;
        }
    }
}