using GestoreEventi;
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

    Evento evento1 = new Evento(titolo, data, postiMax, postiPrenotati);

    evento1.StampaPostiPrenotati();
    evento1.StampaPostiRimasti();
    Console.WriteLine();

    bool flag = false;
    while (flag != true) {
        Console.Write("Vuoi disdire dei posti? (si/no): ");
        string input = Console.ReadLine().ToLower();

        if (input == "si") {
            Console.Write("Inserisi il numero di posti da disdire: ");
            int postiAnnullati = int.Parse(Console.ReadLine());
            evento1.DisdiciPosti(postiAnnullati);
            Console.WriteLine();
            evento1.StampaPostiPrenotati();
            evento1.StampaPostiRimasti();
        } else if (input == "no") {
            flag = true;
        } else {
            Console.WriteLine("Devi inserire si o no");
            Console.WriteLine();
        }

    }
    Console.WriteLine("Ok va bene!");
    Console.WriteLine();
    evento1.StampaPostiPrenotati();
    evento1.StampaPostiRimasti();

} catch(Exception e) {
    Console.WriteLine(e.Message);
}
