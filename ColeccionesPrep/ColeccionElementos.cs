using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesPrep
{
    public class ColeccionElementos
    {
        public void EjemploColeccionElementos()
        {
            // Declarar un HashSet de enteros
            HashSet<int> numbers = new HashSet<int>();

            // Agregar elementos al HashSet
            numbers.Add(2);
            numbers.Add(1);
            numbers.Add(3);

            // Imprimir el HashSet
            Console.WriteLine("HashSet Int");
            Console.WriteLine("HashSet inicial");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Comprobar si el HashSet contiene el número 2
            bool containsTwo = numbers.Contains(2);

            // Imprimir si el HashSet contiene el número 2
            Console.WriteLine("El HashSet contiene el numero 2: " + containsTwo);

            // Contar el número de elementos del HashSet
            int count = numbers.Count;

            // Imprimir el número de elementos del HashSet
            Console.WriteLine("El HashSet tiene " + count + " elementos\n\n\n");


            Console.WriteLine("HashSet String");
            // Declarar un HashSet de cadenas
            HashSet<string> words = new HashSet<string>();

            // Agregar elementos al HashSet
            words.Add("Hola");
            words.Add("Mundo");
            words.Add("Adiós");

            // Imprimir el HashSet
            Console.WriteLine("HashSet inicial:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // Comprobar si el HashSet contiene la cadena "Hola"
            bool containsHola = words.Contains("Hola");

            // Imprimir si el HashSet contiene la cadena "Hola"
            Console.WriteLine(@"El HashSet contiene la palabra 'Hola': " + containsHola);

            // Contar el número de elementos del HashSet
            int countWords = words.Count;

            // Imprimir el número de elementos del HashSet
            Console.WriteLine("El numero de elementos del HashSet es: " + countWords);


        }
    }
}
