using ConsoleApp1;
Console.WriteLine("Dime una latitud para la matrix:(Prueba con 15) ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Dime una longitud para la matrix:(Prueba con 15) ");
int y = Convert.ToInt32(Console.ReadLine());

FactoriaMatrix.generarMatriz(x,y);
