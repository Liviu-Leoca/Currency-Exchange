using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_WAP.Entities
{
    [Serializable]
    public class ExchangeRatesList
    {
        public List<ExchangeRate> ExchangeRates { get; set; }

        public ExchangeRatesList()
        {
            ExchangeRates = new List<ExchangeRate>();
        }

        public ExchangeRatesList(List<ExchangeRate> exchangeRates)
        {
            ExchangeRates = exchangeRates;
        }

        public void Add(ExchangeRate exchangeRate)
        {
            ExchangeRates.Add(exchangeRate);
        }
        public ExchangeRate Find(Currency sourceCurrency, Currency targetCurrency)
        {
            return ExchangeRates.FirstOrDefault(x => x.SourceCurrency == sourceCurrency && x.TargetCurrency == targetCurrency);
        }
    }

}

