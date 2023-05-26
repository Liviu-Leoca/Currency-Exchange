using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_WAP.Entities
{
    [Serializable]
    public class CurrenciesList
    {
        public List<Currency> Currencies { get; set; }

        public CurrenciesList()
        {
            Currencies = new List<Currency>();
        }

        public CurrenciesList(List<Currency> currencies) : this()
        {
            Currencies = currencies;
        }

        public void Add(Currency currency)
        {
            Currencies.Add(currency);
        }
    }

}
