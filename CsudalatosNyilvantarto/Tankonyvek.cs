using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsudalatosNyilvantarto
{
    internal class Tankonyvek
    {
        [PrimaryKey, AutoIncrement]
        public int TankonyvId { get; set; }
        public string TankonyvNev { get; set; }
        public string Tankonyvtantargy { get; set; }
        
    }
}
