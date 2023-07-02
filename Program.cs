using dado;


int inputInt;
Boolean status = false;

do
{


    Console.WriteLine("Inserisci il numero di lanci: ");
    string? input = Console.ReadLine();
    if (int.TryParse(input, out inputInt))
    {

        var dado = new Dado(inputInt);
        var array = Controller.generaLanci(dado.numeroLanci);
        Controller.printArray(array);
        System.Console.WriteLine("la media è " + Controller.average(array));
        status = true;
    }
    else
    {
        System.Console.WriteLine("Valore inserito non valido");
    }

} while (status == true) ;









