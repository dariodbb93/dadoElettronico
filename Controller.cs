namespace dado
{
    public class Controller
    {
        public static List<int> generaLanci(int numeroLanci)
        {
            var random = new Random();
            var array = new List<int>();

            for (int i = 0; i < numeroLanci; i++)
            {
                array.Add(random.Next(1, 7));
            }


            return array;


        }
        public static void printArray(List<int> array)
        {
            System.Console.WriteLine("Hai lanciato il dado "+array.Count+ " volte");


            foreach (var item in array)
            {
                System.Console.Write(item + ",");
            }
        }
        public static double average(List<int> array)
        {
            double sum = 0;

            foreach (var item in array)
            {
                sum += item;
            }

            return (sum / array.Count);



        }


    }




}