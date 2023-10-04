using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Generico : Personaje
    {
        public Generico(string nombre, string lugarDeNacimiento, int edad, Ubicacion ubicacionPer, int porcentajeMorir)
            : base(nombre, lugarDeNacimiento, edad, ubicacionPer,porcentajeMorir)
        {
            
        }

        public Generico()
        {
        }
    }
}
