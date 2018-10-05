using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractModule04
{
    class Program
    {
        static void Main(string[] args)
        {
            Money_ m1;
            Console.Write("Enter SetCountOfMoney ");
            m1.SetCountOfMoney(Console.Read());
            Console.WriteLine();
            Console.Write("Enter SetValueOfMoney ");
            m1.SetValueOfMoney(Console.Read());
            Console.WriteLine();
            Console.WriteLine(m1.GetCountOfMoney());
            Console.WriteLine(m1.GetValueOfMoney());
            Console.WriteLine(m1.GetSumOfMoney());
 

        }
    }
}
