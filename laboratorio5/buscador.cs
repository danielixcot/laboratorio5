using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio5
{
    class Buscador
    {
        string nombreEmpleado;
        int mes;
        decimal sueldo;

        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public int Mes { get => mes; set => mes = value; }
        public decimal Sueldo { get => sueldo; set => sueldo = value; }
    }
}
