namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] exception = { new MyException("Шефф, все пропало!", DateTime.Now),
                                      new ArgumentOutOfRangeException("Вы ввели некорректное число!"),
                                      new FileNotFoundException("Нет такого файла!"),
                                      new DirectoryNotFoundException("Нет такой директории!"),
                                      new IndexOutOfRangeException("Вы вышли за пределы массива!")};
            foreach (Exception ex in exception)
            {
                try
                {
                    throw ex;
                }
                catch(MyException ex2) 
                {
                    Console.WriteLine($"{ex2.Message} Ахтунг ровно в {ex2.DateException}");
                }
                catch(ArgumentOutOfRangeException ex3)
                {
                    Console.WriteLine(ex3.ParamName);
                }
                catch(Exception ex4)
                {
                    Console.WriteLine(ex4.Message);
                }
                finally
                {
                    Console.WriteLine(new String('-', 100));
                }
            }
        }
    }
}