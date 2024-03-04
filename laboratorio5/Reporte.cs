using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio5
{
    class Reporte
    {
        string nombreEmpleado;
        int mes;
        decimal sueldoPersona;

        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public int Mes { get => mes; set => mes = value; }
        public decimal SueldoPersona { get => sueldoPersona; set => sueldoPersona = value; }
    }
}
