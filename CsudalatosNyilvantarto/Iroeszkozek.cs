using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsudalatosNyilvantarto
{
    internal class Iroeszkozek
    {
        [PrimaryKey, AutoIncrement]
        public int IroeszkozId { get; set; }
        public string IroeszkozNev { get; set; }
        public string Iroszer { get; set; }
        
    }
}
