using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Metodos
    {
        public static void unSegundo(Generico[] listaGenericos, Personaje[,] matrix, int cont, int x, int y)
        {
            Random rnd = new Random();
            int ale1;
            int ale2;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] is Generico && matrix[i, j].PorcentajeMorir >= 70)
                    {
                        matrix[i, j] = null;
                        do
                        {
                            ale1 = rnd.Next(0, x);
                            ale2 = rnd.Next(0, y);
                            matrix[ale1, ale2] = listaGenericos[cont];
                        } while (matrix[ale1, ale2] is Smith || matrix[ale1, ale2] is Neo);

                        cont++;
                    }
                    if (matrix[i, j] is Generico && matrix[i, j].PorcentajeMorir < 70)
                    {
                        matrix[i, j].PorcentajeMorir = matrix[i, j].PorcentajeMorir + 10;
                    }
                }
            }
        }
        public static void imprimirMatrix(Personaje[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    switch (matrix[r, j])
                    {
                        case Generico _:
                            Console.Write("[G]");
                            break;
                        case Smith _:
                            Console.Write("[S]");
                            break;
                        case Neo _:
                            Console.Write("[N]");
                            break;
                        default:
                            Console.Write("[ ]");
                            break;
                    }
                }
                Console.WriteLine("[ ]");

            }
        }

        public static void cincoSegundos(Neo neo, int x, int y, Personaje[,] matrix, Generico[] listaGenericos, int ni, int nj)
        {
            Random rnd = new Random();
            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };
            int nuevo = 150;
            int num = rnd.Next(1, 3);
            if (num == 1)
            {
                neo.elegido = true;
            }
            else
            {
                neo.elegido = false;
            }
            if (neo.elegido)
            {
                for (int i = 0; i < 4; i++)
                {
                    int adyX = neo.ubicacionPer.latitud + dx[i];
                    int adyY = neo.ubicacionPer.longitud + dy[i];
                    try
                    {
                        if (!(matrix[adyX, adyY] is Smith) && !(matrix[adyX, adyY] is Generico) && adyX != x-1 && adyY != y-1 && adyX != 0 && adyY != 0)
                        {
                            matrix[adyX, adyY] = listaGenericos[nuevo];
                            nuevo++;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        Console.WriteLine("Ha intentado ser elegido, y ha muerto en el intento, QUE PENA!!!");
                        throw;
                    }

                }
            }
            int nei, nej;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] is Neo)
                    {
                        nei = i;
                        nej = j;
                        matrix[nei, nej] = null;
                    }
                }
            }

            do
            {
                ni = rnd.Next(0, x-1);
                nj = rnd.Next(0, y-1);
                if (matrix[ni, nj] == null)
                {
                    matrix[ni, nj] = neo;
                    neo.ubicacionPer.latitud = ni;
                    neo.ubicacionPer.longitud = nj;
                }
            } while (matrix[ni, nj] is not Neo);

        }
        public static void dosSegundos(Neo neo, Smith smith, Personaje[,] matrix)
        {
            //int distancia = Math.Max(Math.Abs(nj - sj), Math.Abs(ni - si));
            int distancia = Math.Max(Math.Abs(neo.ubicacionPer.longitud - smith.ubicacionPer.longitud), Math.Abs(neo.ubicacionPer.latitud - smith.ubicacionPer.latitud));
            int smi, smj;

            if (distancia > 1)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] is Smith)
                        {
                            smi = i;
                            smj = j;
                            matrix[smi, smj] = null;
                        }
                    }
                }
                for (int i = 1; i < distancia; i++)
                {
                    //Distancia = máximo (abs(filaD - filaS), abs(columnaD - columnaS))
                    if (smith.ubicacionPer.latitud <= neo.ubicacionPer.latitud && smith.ubicacionPer.latitud < 14)
                    {
                        smith.ubicacionPer.latitud = smith.ubicacionPer.latitud + 1;

                    }
                    else
                    {
                        smith.ubicacionPer.latitud = smith.ubicacionPer.latitud - 1;
                    }
                    if (smith.ubicacionPer.longitud <= neo.ubicacionPer.longitud && smith.ubicacionPer.longitud < 14)
                    {
                        smith.ubicacionPer.longitud = smith.ubicacionPer.longitud + 1;

                    }
                    else
                    {
                        smith.ubicacionPer.longitud = smith.ubicacionPer.longitud - 1;
                    }
                    if (matrix[smith.ubicacionPer.latitud, smith.ubicacionPer.longitud] is Generico)
                    {
                        matrix[smith.ubicacionPer.latitud, smith.ubicacionPer.longitud] = null;
                    }
                }
                matrix[smith.ubicacionPer.latitud, smith.ubicacionPer.longitud] = smith;

            }


        }
    }
}
