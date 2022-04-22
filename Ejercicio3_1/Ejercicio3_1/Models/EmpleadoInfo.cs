using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3_1.Models
{
    public class EmpleadoInfo
    {
        [PrimaryKey, AutoIncrement]
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string Puesto { get; set; }
    }
}
