using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventas_watch.modelo
{
    internal class product
    {
        public int id { get; set; }
        public string name { get ; set; }
        public string description { get; set; }
        public decimal price_buy { get; set; }
        public decimal price_sell { get; set; }

    }
}
