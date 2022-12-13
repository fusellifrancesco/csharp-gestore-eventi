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

        public int GetEventi() { 
            return eventi.Count();
        }

        public List<Evento> GetEventiLista() {
            return eventi;
        }

        // METODI PUBBLICI

        public void AggiungiALista(Evento evento) {
            this.eventi.Add(evento);
        }

        public List<Evento> EventiPerData(string data) {
            DateTime dataInserita = DateTime.Parse(data);
            string dataInseritaStringa = dataInserita.ToShortDateString();
            List<Evento> listaData = new List<Evento>();
            foreach (Evento evento in this.eventi) {
                if (dataInseritaStringa == evento.GetData()) {
                    listaData.Add(evento);
                }
            }
            return listaData;
        }

        public static void RappresentaInStringa(List<Evento> eventi) {
            foreach (var evento in eventi)
                evento.ToString();
            //Console.WriteLine($@"{evento}");
        }

        public void StampaNumeroEventi() {
            Console.WriteLine("nella lista sono presenti: " + this.eventi.Count() + " eventi");
        }

        public void SvuotaLista() {
            this.eventi.Clear();
            Console.WriteLine("Hai eliminato tutti gli eventi nella lista");
        }

        public void StampaStringaDataTitolo() {
            Console.WriteLine("----" + titolo + "----");
            foreach (Evento evento in this.eventi) {     
            Console.WriteLine( $@"
{evento.GetData()} - {evento.GetTitolo()}");
            }
        }

    }
}
