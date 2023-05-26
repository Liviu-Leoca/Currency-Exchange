using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_WAP.Entities
{
    [Serializable]
    public class ExchangeRate
    {
        public decimal Rate { get; set; }
        public Currency SourceCurrency { get; set; }
        public Currency TargetCurrency { get; set; }
        public ExchangeRate() { }
        public ExchangeRate(Currency sourceCurrency,Currency targetCurrency,decimal rate)
        {
            Rate = rate;
            SourceCurrency = sourceCurrency;
            TargetCurrency = targetCurrency;
        }

        public void SetExchangeRate(Currency sourceCurrency, Currency targetCurrency, decimal rate)
        {
            SourceCurrency = sourceCurrency;
            TargetCurrency = targetCurrency;
            Rate = rate;
        }
    }
}
