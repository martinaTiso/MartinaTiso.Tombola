using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartinaTiso.Tombola
{
    internal class TombolaManager
    {

        internal static int[] SceltaDeiNumeri()
        {

            int[] inserimentoNum = new int[5]; //creazione dell'array


            for (int i = 0; i < inserimentoNum.Length; i++)  //  richiedo i 5 numeriii
            {
                Console.WriteLine("Inserire 5 numeri tra 1 e 90:");

                int numero = int.Parse(Console.ReadLine());// inserimento del numero


                for (int j = 0; j < inserimentoNum.Length; j++) // eseguo il 1 controllo che due numeri 
                {
                    if (inserimentoNum[i] == numero) // se i numeri sono uguali richiedono all'utente di inserirne uno nuovo e torno indietro di posizione
                    {
                        Console.WriteLine("il numero ègià presente : ");
                        Console.WriteLine("inserire un numero diverso:");
                        i--;
                    }
                    if (!(numero <= 90 && numero >= 1)) // eseguo il controllo se il numero è minore  di 90 e maggiore di 1 altrimenti  decrementoj
                    {
                        Console.WriteLine("il numero inserito è sbagliato:");
                        Console.WriteLine("numero tra 1  e  90");
                        j--;
                    }

                                       

                }
                Console.WriteLine($"i numeri sono:{inserimentoNum[i]}");
                

            }
            return inserimentoNum;
        }
        internal static int[] SorteggiareNum()
        {
            //inizializzare un vettore vuoto di dimensione 2
            int[] drawnNumbers = new int[70];

            Random random = new Random();

            for (int i = 0; i < drawnNumbers.Length; i++)
            {
                drawnNumbers[i] = random.Next(1, 91); //Sorteggio un numero tra 1 e 91e lo assegno all'elemento i-esimo
                                                      //del vettore di numeri estratti
            } //while (!(int.TryParse(Console.ReadLine(), out drawnNumbers));

            return drawnNumbers;
        }
    }
}












