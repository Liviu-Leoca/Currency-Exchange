using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_WAP.Entities
{
    [Serializable]
    public class Currency
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public Currency() {}
        public Currency(string name, string code) :this()
        {
            Name = name;
            Code = code;
        }
    }
}
