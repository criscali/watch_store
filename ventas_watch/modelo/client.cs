using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventas_watch.modelo
{
    public class client
    {
        public int id {  get; set; }
        public int cedula_ciudadania { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public int phone {  get; set; }
    }
}
