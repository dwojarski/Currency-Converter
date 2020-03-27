using System;
using System.Collections.Generic;

namespace Kantor
{
    class ExchangePanel
    {
        public void Transaction(List<Currency> list)
        {
            double value1, value2, amount;
            Console.WriteLine("Exchanging currency");
            while (true)
            {
                Console.WriteLine("From:");
                string input1 = Convert.ToString(Console.ReadLine());
                if (list.Exists(item => item.GetName() == input1 || item.GetCode() == input1))
                {
                    Currency curr1 = list.Find(item => item.GetName() == input1 || item.GetCode() == input1);
                    value1 = curr1.GetValue() * curr1.GetFactor();
                    break;
                }
                Console.WriteLine("Unknown currency... Please try again!");
            }
            while (true)
            {
                Console.WriteLine("To");
                string input2 = Convert.ToString(Console.ReadLine());
                if (list.Exists(item => item.GetName() == input2 || item.GetCode() == input2))
                {
                    Currency curr2 = list.Find(item => item.GetName() == input2 || item.GetCode() == input2);
                    value2 = curr2.GetValue() * curr2.GetFactor();
                    break;
                }
                Console.WriteLine("Unknown currency... Please try again!");
            }
            Console.WriteLine("Type the amount to exchange:");
            amount = Convert.ToDouble(Console.ReadLine());
            Exchange transaction = new Exchange(value1, value2, amount);
        }

    }
}
