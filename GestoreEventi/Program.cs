using GestoreEventi;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Transactions;

try {

    Console.Write("Inserisci il titolo dell'evento: ");
    string titolo = Console.ReadLine();
    Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
    string data = Console.ReadLine();
    Console.Write("Inserisci il numero dei posti totali: ");
    int postiMax = int.Parse(Console.ReadLine());
    Console.Write("Quanti posti desideri prenotare? ");
    int postiPrenotati = int.Parse(Console.ReadLine());

    Evento evento = new Evento(titolo, data, postiMax, postiPrenotati);

    evento.StampaPostiPrenotati();
    evento.StampaPostiRimasti();
    Console.WriteLine();

    bool flag = false;
    while (flag != true) {
        Console.Write("Vuoi disdire dei posti? (si/no): ");
        string input = Console.ReadLine().ToLower();

        if (input == "si") {
            Console.Write("Inserisi il numero di posti da disdire: ");
            int postiAnnullati = int.Parse(Console.ReadLine());
            evento.DisdiciPosti(postiAnnullati);
            Console.WriteLine();
            evento.StampaPostiPrenotati();
            evento.StampaPostiRimasti();
        } else if (input == "no") {
            flag = true;
        } else {
            Console.WriteLine("Devi inserire si o no");
            Console.WriteLine();
        }

    }
    Console.WriteLine("Ok va bene!");
    Console.WriteLine();
    evento.StampaPostiPrenotati();
    evento.StampaPostiRimasti();

} catch(Exception e) {
    Console.WriteLine(e.Message);
}

Console.Write("Inserisci il nome del tuo programma di eventi: ");
string input2 = Console.ReadLine();

ProgrammaEventi programmaEventi = new ProgrammaEventi(input2);

Console.Write("Indica il numero di eventi da inserire: ");
int inputInt = int.Parse(Console.ReadLine());
Console.WriteLine();

int contatore = 1;

try {
    while (programmaEventi.GetEventi() < inputInt) {
        Console.Write("Inserisci il titolo del " + contatore + "° evento: ");
        string titolo = Console.ReadLine();
        Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
        string data = Console.ReadLine();
        Console.Write("Inserisci il numero dei posti totali: ");
        int postiMax = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Evento evento = new Evento(titolo, data, postiMax);
        programmaEventi.AggiungiALista(evento);
        contatore++;
    }
} catch (Exception e) {
    Console.WriteLine(e.Message);
    Console.WriteLine("Reinserisci l'evento");
}

programmaEventi.StampaNumeroEventi();
Console.WriteLine();
Console.WriteLine("Ecco il tuo programma eventi:");
programmaEventi.StampaStringaDataTitolo();
Console.WriteLine();
Console.Write("Inserisci una data per sapere che eventi ci saranno (gg/mm/yyyy): ");
string inputData = Console.ReadLine();
List<Evento> listaData = programmaEventi.EventiPerData(inputData);
ProgrammaEventi.RappresentaInStringa(listaData);

