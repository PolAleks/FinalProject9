using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class MyException : Exception
    {
        public DateTime DateException { get; }
        public MyException() { }
        public MyException(string message, DateTime date) : base(message) 
        {
            DateException = date;
        } 
    }
}
