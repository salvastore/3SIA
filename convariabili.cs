/****************************************************

Costruiamo un programma "Gestione Prodotti"
che legge un dato inserito dall'utente

*****************************************************/
using System;
class ConVariabili {
  static void Main() {

    //Dichiarazione di variabili
    string prodotto;
    string quantita;
    
    // Visualizza il titolo del programma
    Console.WriteLine("Gestione Prodotti");

    // Chiede all'utente il nome del prodotto
    Console.Write("Inserisci il tuo prodotto: ");
    // Legge il dato inserito dall'utente
    prodotto=Console.ReadLine();
    // Chiede all'utente la quantità
    Console.Write("Inserisci la quantità: ");
    // Legge il dato inserito dall'utente
    quantita=Console.ReadLine();
     
    //Mostra a schermo i valori acquisiti
    Console.Write("Il prodotto scelto è: ");
    Console.WriteLine(prodotto);

    Console.Write("La quantità richiesta è: ");
    Console.WriteLine(quantita);

    // Comunica che l'operazione è terminata
    Console.WriteLine("Operazione Conclusa");
    
  }
}