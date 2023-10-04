using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FactoriaSmith
    {
        public static Smith crearSmith(int x, int y)
        {
            string nombre = "Smith";
            string lugarDeNacimiento = "Higher Calmtown";
            int edad = 53;
            Random random = new Random();
            int latitud;
            int longitud;
            int porcentajeMatar =100;
            Ubicacion ubicacion = new Ubicacion();
            Smith smith = new Smith(nombre, lugarDeNacimiento, edad,ubicacion,porcentajeMatar);
            return smith;
        }
    }
}
