/*********************************************************************
CALCOLO DEL COSTO DI UN INGRESSO AL CINEMA
Un cinema applica le seguenti tariffe:
- Ogni biglietto intero costa 8,50 €.
- Ogni biglietto ridotto costa 5,50 €.

Realizza un programma in C# che:
1. Chieda all'utente il numero di biglietti interi acquistati.
2. Chieda il numero di biglietti ridotti acquistati.
3. Calcoli il costo complessivo dei biglietti.
4. Visualizzi il totale da pagare, espresso in euro.

Per questo esercizio considera che le quantità inserite
siano numeri interi non negativi.
**********************************************************************/
using System;

class Cinema{
    static void Main(){
        //Dichiarazione variabili
        int numBigliettiInteri,numBigliettiRidotti;
        double prezzoIntero=8.50;
        double prezzoRidotto=5.50;
        double importoTotale;


        //Input
        Console.Write("Inserisci il numero di biglietti interi acquistati: ");
        numBigliettiInteri=int.Parse(Console.ReadLine());
        Console.Write("Inserisci il numero di biglietti ridotti acquistati: ");
        numBigliettiRidotti=int.Parse(Console.ReadLine());
        
        
        //Elaborazione
        importoTotale=numBigliettiInteri*prezzoIntero+numBigliettiRidotti*prezzoRidotto;

        
        //Output
        Console.Write("L'importo complessivo è: € "+importoTotale);



    }
}