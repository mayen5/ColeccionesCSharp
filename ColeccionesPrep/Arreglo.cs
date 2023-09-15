using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesPrep
{
    public class Arreglo
    {
        public void EjemploArregloInt()
        {
            // Almacenamiento de datos en un array ordenado
            int[] numbers = new int[] { 3, 2, 1, 5, 4 };

            // Imprimir el array desordenado
            Console.WriteLine("________________");
            Console.WriteLine("Array desordenado");
            Console.WriteLine("________________\n");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("________________");

            // Ordenar el array
            Array.Sort(numbers);

            // Imprimir el array ordenado
            Console.WriteLine("Array ordenado");
            Console.WriteLine("________________");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("________________\n");
        }

        public void EjemploArregloString() {
            // Declarar un array de cadenas
            string[] names = new string[5];

            // Asignar valores al array
            names[0] = "Zurisdaí";
            names[1] = "Roni";
            names[2] = "Yennifer";
            names[3] = "Angeles";
            names[4] = "Nahomi";

            // Imprimir el array
            Console.WriteLine("________________");
            Console.WriteLine("Array desordenado");
            Console.WriteLine("________________\n");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("________________\n\n");

            // Ordenar el array
            Array.Sort(names);

            // Imprimir el array ordenado
            Console.WriteLine("________________");
            Console.WriteLine("Array ordenado");
            Console.WriteLine("________________\n");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("________________\n");
        }

}
}
