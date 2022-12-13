using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi {
    public class Evento {
        private string titolo;
        private DateTime data;
        private int capienzaMax;
        private int postiPrenotati;

        public Evento(string titolo, string data, int capienzaMax, int prenotati = 0) {
            this.titolo = titolo;
            this.data = DataStringaInDateTime(data);
            this.capienzaMax= capienzaMax;
            this.postiPrenotati = prenotati;
        }

        // GETTERS

        public string GetTitolo() {
            return this.titolo;
        }
        public DateTime GetData() {
            return this.data;
        }
        public int GetPostiPrenotati() {
            return this.postiPrenotati;
        }
        public int GetCapienzaMax() {
            return this.capienzaMax;
        }

        // SETTERS

        public void SetTitolo(string titolo) {
            this.titolo = titolo;
        }
        public void SetData(string data) {
            DateTime dataInserita = DateTime.Parse(data);
            this.data = dataInserita;
        }

        // METODI PRIVATI

        private DateTime DataStringaInDateTime(string data) {
            DateTime dataInserita = DateTime.Parse(data);
            return dataInserita;
        }


        // METODI PUBBLICI

        public void PrenotaPosti(int posti) {
            if (this.data < DateTime.Now || this.postiPrenotati == this.capienzaMax || this.capienzaMax == 0) {
                throw new Exception("Non sono presenti posti da prenotare");
            } else if (posti > this.capienzaMax) {
                throw new Exception("Non puoi prenotare più posti di quelli disponibili. POSTI DISPONIBILI: " + this.capienzaMax);
            } else {
                this.postiPrenotati = posti;
            }
        }
        public void DisdiciPosti(int posti) {
            if (this.data < DateTime.Now || this.postiPrenotati == 0) {
                throw new Exception("Non sono presenti posti da disdire");
            } else if (posti > this.postiPrenotati){
                throw new Exception("Non puoi disdire più posti di quelli che hai prenotato. POSTI PRENOTATI: " + this.postiPrenotati);
            } else {
                this.postiPrenotati = this.postiPrenotati - posti;
            }
        }
        public override string ToString() {
            return this.data + " - " + this.titolo;
                
        }
        public void StampaPostiRimasti() {
            Console.WriteLine("Numero di posti disponibili: " + (this.capienzaMax - this.postiPrenotati));
        }
        public void StampaPostiPrenotati() {
            Console.WriteLine("Numero di posti prenotati: " + this.postiPrenotati);
        }


        public virtual bool VerificaData(string data) {
            DateTime dataInserita = DateTime.Parse(data);
            if (dataInserita == this.data) {
                return true;
            } else {
                return false;
            }
        }
    }
}