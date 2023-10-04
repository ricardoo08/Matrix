using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    public class FactoriaNeo
    {
        public static Neo crearNeo(int x, int y)
        {
            string nombre = "Neo";
            string lugarDeNacimiento = "Lower Downtown";
            int edad = 37;
            Random random = new Random();
            int latitud;
            int longitud;
            bool elegido=false;
            Ubicacion ubicacion = new Ubicacion();
            
            Neo neo = new Neo(nombre, lugarDeNacimiento, edad,ubicacion, elegido);
            return neo;
        }

    }
}
