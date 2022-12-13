using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi {
    public class ProgrammaEventi : Evento{
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

        // METODI PRIVATI



        // METODI PUBBLICI

        public void AggiungiALista(Evento evento) {
            this.eventi.Add(evento);
        }
        
        public void StampaEventiPerData(List<Evento> eventi, string data) {
            foreach (Evento evento in eventi) {
                if (evento.VerificaData(data)) {
                    Console.WriteLine("Evento Presente, stampa in corso...");
                    Console.WriteLine(evento);
                    return;
                }
            }
        }

        public static string RappresentaInStringa() {
            foreach (var evento in this.eventi)
            return ($@"");
        }

        public void StampaNumeroEventi() {
            Console.WriteLine("nella lista sono presenti: " + this.eventi.Count() + " eventi");
        }

        public void SvuotaLista() {
            this.eventi.Clear();
            Console.WriteLine("Hai eliminato tutti gli eventi nella lista");
        }

        public void StampaStringaDataTitolo() {
            foreach (Evento evento in this.eventi) { 
            Console.WriteLine( $@"
----{titolo}----
{evento.GetData()} - {evento.GetTitolo()}");
            }
        }

    }
}
