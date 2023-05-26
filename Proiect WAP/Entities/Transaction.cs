using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_WAP.Entities
{
    public class Transaction
    {
        public Currency SourceCurrency { get; set; }
        public Currency TargetCurrency { get; set; }
        public decimal Amount { get; set; }
        public  decimal ExRate { get; set; }
        public DateTime Timestamp { get; set; }

        public Transaction()
        {
            Amount = 0;
            Timestamp = DateTime.Now;
        }
        public Transaction(Currency sourceCurrency, Currency targetCurrency, decimal amount, decimal exRate, DateTime timestamp)
        {
            SourceCurrency = sourceCurrency;
            TargetCurrency = targetCurrency;
            Amount = amount;
            ExRate = exRate;
            Timestamp = timestamp;
        }
    }
}
