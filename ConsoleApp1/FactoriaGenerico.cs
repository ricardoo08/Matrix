using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FactoriaGenerico
    {
        public static Generico crearGenerico(int x, int y)
        {
            string[] nombres = { "Michelle", "Alexander", "James", "CarolineClaire", "Jessica", "Erik", "Mike" };
            string[] ciudades = { "Nueva York", "Boston", "Baltimore", "Atlanta", "Detroit", "Dallas", "Denver" };

            Random rand = new Random();
            int nom = rand.Next(nombres.Length);
            string nombre = nombres[nom];
            int ciu = rand.Next(nombres.Length);
            string lugarDeNacimiento = ciudades[ciu];
            int edad = rand.Next(18, 81);
            int porcentajeMorir = rand.Next(1, 101);
            int latitud;
            int longitud;
            Ubicacion ubi = new Ubicacion();
            Generico generico = new Generico(nombre, lugarDeNacimiento, edad, ubi, porcentajeMorir);
            return generico;
        }
    }
}
