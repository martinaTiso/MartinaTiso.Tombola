// See https://aka.ms/new-console-template for more information
using MartinaTiso.Tombola;

Console.WriteLine("Hello, World!");


Console.WriteLine("Benvenuto a Tombola!");

do
{

    int [] inserimentoNum = TombolaManager.SceltaDeiNumeri();

    int[] drawnNumbers = TombolaManager.SorteggiareNum();


    //List<int> numeriEstratti = TombolaManager.SorteggiareNum();

    Console.WriteLine("Vuoi rigiocare  al gioco della fortuna? Premi 'E' per uscire o'Y' per continuare");


} while (!(Console.ReadKey().KeyChar == 'E'));




