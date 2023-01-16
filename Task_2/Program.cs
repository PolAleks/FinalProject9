namespace Task_2
{
    internal class Program
    {
        static string[] lastName = {"Иванов",
                                    "Петров",
                                    "Сидоров",
                                    "Козлов",
                                    "Краморов"};
        static void Main(string[] args)
        {
            EnterFlagSort enFlagSort = new EnterFlagSort();
            enFlagSort.FlagEnteredEvent += MethodSort;

            while (!enFlagSort.FlagEntered)
            {
                try
                {
                    enFlagSort.Read();
                }
                catch (FormatException) 
                {
                    Console.WriteLine("Введено некорректное зачение!");
                }
            }

            foreach (string lastName in lastName) 
            {
                Console.WriteLine(lastName);
            }
        }
        static void MethodSort(int flag)
        {
            Array.Sort(lastName);
            if (flag == 2) Array.Reverse(lastName);
        }
    }
}