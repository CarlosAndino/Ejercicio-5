using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int N = rnd.Next(1, 50);
            Console.WriteLine("El numero N es :" + N);
            Console.ReadKey();

            Random rnd2 = new Random();

            int M = rnd2.Next(70,200);
            Console.WriteLine("El numero M es :" + M);
            Console.ReadKey();

            int[,] matriz1 = new int[4,4 ];
            for (int fila = 0; fila < matriz1.GetLength(0); fila++)
            {
                for (int colum = 0; colum < matriz1.GetLength(1); colum++)
                {
                    matriz1[fila, colum] = (fila + N) * (colum + M);
                    
                    Console.WriteLine("Resultado de la multiplicacion de estos valores es :" + fila + "," + colum + "=" + matriz1[fila,colum]);
                    Console.ReadKey();

                }
                
            }



        }
    }
}
