using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Persona
    {
        public static List<Persona> lista = new List<Persona>();
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Persona(String nombre, String apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
    }
}
