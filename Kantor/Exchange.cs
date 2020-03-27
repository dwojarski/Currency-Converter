using System;

namespace Kantor
{
    class Exchange
    {
        double value1, value2, amount;
        public Exchange(double value1, double value2, double amount)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.amount = amount;
            Console.WriteLine("Result: {0}", amount*value1/value2);

        }
    }
}
