using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Smith : Personaje
    {
        public int porcentajeInfectar { get; set; }
        public Smith(string nombre, string lugarDeNacimiento, int edad,Ubicacion ubicacion, int porcentajeInfectar)
            : base(nombre, lugarDeNacimiento, edad, ubicacion)
        {
            this.porcentajeInfectar = porcentajeInfectar;
        }



    }
}
