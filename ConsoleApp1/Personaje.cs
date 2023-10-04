using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Personaje
    {
        public string Nombre { get; set; }
        public string LugarDeNacimiento { get; set; }
        public int Edad { get; set; }
        public Ubicacion ubicacionPer { get; set; }
        public int PorcentajeMorir { get; set; }

        public Personaje(string nombre, string lugarDeNacimiento, int edad, Ubicacion ubicacionPer)

        {
            Nombre = nombre;
            LugarDeNacimiento = lugarDeNacimiento;
            Edad = edad;
            this.ubicacionPer = ubicacionPer;
        }

        public Personaje()
        {
        }

        public Personaje(string nombre, string lugarDeNacimiento, int edad, Ubicacion ubicacionPer, int porcentajeMorir) : this(nombre, lugarDeNacimiento, edad, ubicacionPer)
        {
            PorcentajeMorir = porcentajeMorir;
        }
    }
}
