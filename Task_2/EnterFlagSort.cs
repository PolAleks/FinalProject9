using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class EnterFlagSort
    {
        public delegate void EnterFlagSortDelegate(int flag);
        public event EnterFlagSortDelegate FlagEnteredEvent;
        public bool FlagEntered;
        public void Read()
        {
            Console.WriteLine(new string('-',50));
            Console.WriteLine("Выберите вариант сортировки:\n" +
                              "1 - сортировка А-Я\n" +
                              "2 - сортировка Я-А");
            int flag = Convert.ToInt32(Console.ReadLine());

            if (flag != 1 && flag != 2) throw new FormatException();

            DataEntered(flag);

            FlagEntered = true;
        }

        public virtual void DataEntered(int flag)
        {
            FlagEnteredEvent?.Invoke(flag);
        }
    }
}
