using System;
using System.Collections.Generic;


namespace ExamenAlvaco.Models
{
    public class Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string FechaNcimiento { get; set; }
        public string DepartamentoID { get; set; }
    }
}