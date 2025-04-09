using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsudalatosNyilvantarto
{
    internal class Fuzetek
    {
        [PrimaryKey, AutoIncrement]
        public int FuzetId { get; set; }
        public string FuzetNev { get; set; }
        public string FuzetTantargy { get; set; }
        
    }
}
