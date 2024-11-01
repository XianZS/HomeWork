using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Class6
    {
        static void Main(string[] args)
        {
            try
            {
                int number1 = 5;
                int number2 = 0;
                int number3 = number1 / number2;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine(e.Source);
            }
            finally
            {
                Console.WriteLine("写错喽");
            }
        }
    }

}
