using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractModule04
{
    public class Money_
    {
        private double valueMoney;
        private double countOfMoney;

        public Money_()
        {
            valueMoney = 1.0;
            countOfMoney = 1.0;
        }

        public Money_(double valueMoney, double countOfMoney)
        {
            this.countOfMoney = countOfMoney;
            this.valueMoney = valueMoney;
        }

        public double GetCountOfMoney()
        {
            return countOfMoney;
        }
        public double GetValueOfMoney()
        {
            return valueMoney;
        }

        public void SetCountOfMoney(double countOfMoney)
        {
            this.countOfMoney = countOfMoney;
        }
        public void SetValueOfMoney(double valueMoney)
        {
            this.valueMoney = valueMoney;
        }

        public double GetSumOfMoney()
        {
            return valueMoney * countOfMoney;
        }



        bool IsEnoughtMoney(double sumOfMoney)
        {
            if ((valueMoney * countOfMoney) <= sumOfMoney) return true;
            else return false;
        }

        double CountOfItem(double costOfItem)
        {
            return (valueMoney * countOfMoney) / costOfItem;
        }

    }
}
