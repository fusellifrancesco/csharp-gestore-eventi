using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi {
    public class ProgrammaEventi {
        private string titolo;
        private List<Evento> eventi;

        public ProgrammaEventi(string titoloProgramma){
            this.titolo = titoloProgramma;
            this.eventi = new List<Evento>();
        }

        // GETTERS

        public string GetTitolo() {
            return titolo;
        }

        // METODI PUBBLICI

        public void AggiungiALista(Evento evento) {
            this.eventi.Add(evento);
        }

        //public void StampaEventiPerData(string data) {
        //    DateTime dataInserita = DateTime.Parse(data);
        //}

        public static void RappresentaInStringa() {
            foreach (Evento evento in eventi) {
                Console.WriteLine(evento.ToString());
            }
        }

        public void StampaNumeroEventi() {
            Console.WriteLine("nella lista sono presenti: " + this.eventi.Count() + " eventi");
        }

        public void SvuotaLista() {
            this.eventi.Clear();
            Console.WriteLine("Hai eliminato tutti gli eventi nella lista");
        }

    }
}
