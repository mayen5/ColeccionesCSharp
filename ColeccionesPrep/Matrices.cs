using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesPrep
{
    public class Matrices
    {
        public void EjemploMatrices()
        {
            // Declarar una matriz de 3x3
            int[,] matriz = new int[3, 3];

            // Inicializar la matriz con algunos valores
            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[0, 2] = 3;
            matriz[1, 0] = 4;
            matriz[1, 1] = 5;
            matriz[1, 2] = 6;
            matriz[2, 0] = 7;
            matriz[2, 1] = 8;
            matriz[2, 2] = 9;

            // Acceder y mostrar los valores de la matriz
            Console.WriteLine("Matriz:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Calcular la suma de todos los elementos de la matriz
            int suma = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    suma += matriz[i, j];
                }
            }

            Console.WriteLine("Suma de todos los elementos de la matriz: " + suma);

            // Obtener el elemento en la posición (1, 2)
            int number = matriz[1, 2];

            // Imprimir el elemento en la posición (1, 2)
            Console.WriteLine(number);

            


        }
    }
}
