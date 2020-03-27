using System;
using System.Collections.Generic;

namespace Kantor
{
    class ShowData
    {
        public void DisplayData(List<Currency> clist)
        {
            Console.WriteLine("{0, 35}\t|\tCode\t|\t{1, 13}\t|\tFactor", "Currency name", "Exchange rate");
            foreach (Currency curr in clist)
            {
                Console.WriteLine("{0,35}\t|\t{1}\t|\t{2, 13}\t|\t{3}", curr.GetName(), curr.GetCode(), curr.GetValue(), curr.GetFactor());
            }
        }
    }
}
