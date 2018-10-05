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
            Money m1 = new Money();
            Console.WriteLine("Enter SetCountOfMoney ");
            string countMoney = Console.ReadLine();
            int intCountMoney = int.Parse(countMoney);
            m1.SetCountOfMoney(intCountMoney);
            Console.WriteLine("Enter SetValueOfMoney ");
            string valueMoney = Console.ReadLine();
            int intValueMoney = int.Parse(countMoney);
            m1.SetValueOfMoney(intValueMoney);
            Console.WriteLine();
            Console.WriteLine(m1.GetCountOfMoney());
            Console.WriteLine(m1.GetValueOfMoney());
            Console.WriteLine(m1.GetSumOfMoney());
            Console.WriteLine(m1.IsEnoughtMoney(m1.GetSumOfMoney()));
            Console.WriteLine(m1.CountOfItem(3));


            Console.ReadLine();

        }
    }
}
