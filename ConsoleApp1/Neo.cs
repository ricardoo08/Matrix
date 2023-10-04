using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Neo : Personaje
    {
        public bool elegido { get; set; }
        public Neo()
        {
        }
        public Neo(string nombre, string lugarDeNacimiento, int edad, Ubicacion ubicacion, bool elegido)
           : base(nombre, lugarDeNacimiento, edad,ubicacion)
        {
            this.elegido = elegido;
        }




    }
}
