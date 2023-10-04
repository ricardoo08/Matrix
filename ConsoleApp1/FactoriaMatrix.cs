using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FactoriaMatrix
    {
        public static void generarMatriz(int x, int y)
        {


            Random rnd = new Random();
            int cont = 21;
            int ni = rnd.Next(0, x-1);
            int nj = rnd.Next(0, y-1);
            int si = rnd.Next(0, x);
            int sj = rnd.Next(0, y);
            Neo neo = FactoriaNeo.crearNeo(x, y);
            Smith smith = FactoriaSmith.crearSmith(x, y);
            Personaje[,] matrix = new Personaje[x, y];
            Generico[] listaGenericos = new Generico[200];
            for (int i = 0; i < listaGenericos.Length; i++)
            {
                Generico generico = FactoriaGenerico.crearGenerico(x, y);
                listaGenericos[i] = generico;

            }
            for (int i = 0; i < 20; i++)
            {
                int gi = rnd.Next(0, x);
                int gj = rnd.Next(0, y);
                matrix[gi, gj] = listaGenericos[i];
                listaGenericos[i].ubicacionPer.latitud = gi;
                listaGenericos[i].ubicacionPer.longitud = gj;
            }



            do
            {
                if (matrix[ni, nj] == null)
                {
                    matrix[ni, nj] = neo;
                    neo.ubicacionPer.latitud = ni;
                    neo.ubicacionPer.longitud = nj;
                }
                else
                {
                    ni = rnd.Next(0, x-1);
                    nj = rnd.Next(0, y-1);
                }

            } while (matrix[ni, nj] is not Neo);


            do
            {
                if (matrix[si, sj] == null)
                {
                    matrix[si, sj] = smith;
                    smith.ubicacionPer.latitud = si;
                    smith.ubicacionPer.longitud = sj;
                }
                else
                {
                    si = rnd.Next(0, x);
                    sj = rnd.Next(0, y);
                }
            } while (matrix[si, sj] is not Smith);

            


            Console.WriteLine("*************** ESTA ES TU MATRIZ INICIAL: ***************");
            Metodos.imprimirMatrix(matrix);
            Console.WriteLine("*************** Vamos a empezar!!!! ***************");
            Metodos.unSegundo(listaGenericos, matrix, cont, x, y);
            Metodos.unSegundo(listaGenericos, matrix, cont, x, y);
            Thread.Sleep(2000);//2
            Metodos.dosSegundos(neo, smith, matrix);

            Console.WriteLine();
            Console.WriteLine("         ************* 2 SEGUNDOS *************");
            Console.WriteLine();
            
            Metodos.imprimirMatrix(matrix);   
            Metodos.unSegundo(listaGenericos, matrix, cont, x, y);
            Metodos.unSegundo(listaGenericos, matrix, cont, x, y);
            Thread.Sleep(2000);//4
            
            Console.WriteLine();
            Console.WriteLine("         ************* 4 SEGUNDOS *************");
            Console.WriteLine();
            
            Metodos.dosSegundos(neo, smith, matrix);
            Metodos.imprimirMatrix(matrix);
            Metodos.unSegundo(listaGenericos, matrix, cont, x, y);
            Thread.Sleep(1000);//5
            
            Console.WriteLine();
            Console.WriteLine("         ************* 5 SEGUNDOS *************");
            Console.WriteLine();
            
            Metodos.cincoSegundos(neo, x, y, matrix, listaGenericos, ni, nj);
            Metodos.unSegundo(listaGenericos, matrix, cont, x, y);
            Metodos.imprimirMatrix(matrix);
            Thread.Sleep(1000);//6

            Console.WriteLine();
            Console.WriteLine("         ************* 6 SEGUNDOS *************");
            Console.WriteLine();
            
            Metodos.dosSegundos(neo, smith, matrix);
            Metodos.imprimirMatrix(matrix);
            Thread.Sleep(2000);//8

            Console.WriteLine();
            Console.WriteLine("         ************* 8 SEGUNDOS *************");
            Console.WriteLine();
            
            Metodos.unSegundo(listaGenericos, matrix, cont, x, y);
            Metodos.unSegundo(listaGenericos, matrix, cont, x, y);
            Metodos.dosSegundos( neo, smith, matrix);
            Metodos.imprimirMatrix(matrix);
            Thread.Sleep(2000);//10

            Console.WriteLine();
            Console.WriteLine("         ************* 10 SEGUNDOS *************");
            Console.WriteLine();
            
            Metodos.unSegundo(listaGenericos, matrix, cont, x, y);
            Metodos.unSegundo(listaGenericos, matrix, cont, x, y);
            Metodos.dosSegundos( neo, smith, matrix);
            Metodos.cincoSegundos(neo, x, y, matrix, listaGenericos, ni, nj);
            Metodos.imprimirMatrix(matrix);
            Thread.Sleep(2000);//12

            Console.WriteLine();
            Console.WriteLine("         ************* 12 SEGUNDOS *************");
            Console.WriteLine();
            
            Metodos.unSegundo(listaGenericos, matrix, cont, x, y);
            Metodos.unSegundo(listaGenericos, matrix, cont, x, y);
            Metodos.dosSegundos( neo, smith, matrix);
            Metodos.imprimirMatrix(matrix);
            Thread.Sleep(2000);//14

            Console.WriteLine();
            Console.WriteLine("         ************* 14 SEGUNDOS *************");
            Console.WriteLine();
            
            Metodos.unSegundo(listaGenericos, matrix, cont, x, y);
            Metodos.unSegundo(listaGenericos, matrix, cont, x, y);
            Metodos.dosSegundos(neo, smith, matrix);
            Metodos.imprimirMatrix(matrix);
            Thread.Sleep(1000);//15

            Console.WriteLine();
            Console.WriteLine("         ************* 15 SEGUNDOS *************");
            Console.WriteLine();
            
            Metodos.unSegundo(listaGenericos, matrix, cont, x, y);
            Metodos.cincoSegundos(neo, x, y, matrix, listaGenericos, ni, nj);
            Metodos.imprimirMatrix(matrix);
            Thread.Sleep(1000);//16

            Console.WriteLine();
            Console.WriteLine("         ************* 16 SEGUNDOS *************");
            Console.WriteLine();
            
            Metodos.unSegundo(listaGenericos, matrix, cont, x, y);
            Metodos.dosSegundos( neo, smith, matrix);
            Metodos.imprimirMatrix(matrix);
            Thread.Sleep(2000);//18
            
            Console.WriteLine();
            Console.WriteLine("         ************* 18 SEGUNDOS *************");
            Console.WriteLine();
            
            Metodos.unSegundo(listaGenericos, matrix, cont, x, y);
            Metodos.unSegundo(listaGenericos, matrix, cont, x, y);
            Metodos.dosSegundos( neo, smith, matrix);
            Metodos.imprimirMatrix(matrix);
            Thread.Sleep(2000);//20

            Console.WriteLine();
            Console.WriteLine("         ************* 20 SEGUNDOS *************");
            Console.WriteLine();
            
            Metodos.unSegundo(listaGenericos, matrix, cont, x, y);
            Metodos.unSegundo(listaGenericos, matrix, cont, x, y);
            Metodos.cincoSegundos(neo, x, y, matrix, listaGenericos, ni, nj);
            Metodos.dosSegundos( neo, smith, matrix);
            Metodos.imprimirMatrix(matrix);
        }





    
    }
}

