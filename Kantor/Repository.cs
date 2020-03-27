using System.Collections.Generic;

namespace Kantor
{
    public class Repository
    {
        private List<Currency> currencies = new List<Currency>();

        public List<Currency> GetCurrencyList() => currencies;
        public void AddCurrency(Currency curr) => currencies.Add(curr);
        public void RemoveCurrency(Currency curr) => currencies.Remove(curr);
    }
}
