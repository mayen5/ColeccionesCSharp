using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesPrep
{
    public class Diccionario
    {
        public void EjemploDiccionario()
        {
            // Declarar un Dictionary de enteros
            Dictionary<int, string> numbers = new Dictionary<int, string>();

            // Agregar elementos al Dictionary
            numbers.Add(3, "Tres");
            numbers.Add(1, "Uno");
            numbers.Add(2, "Dos");

            // Imprimir el Dictionary
            Console.WriteLine("Diccionario inicial");
            foreach (KeyValuePair<int, string> entry in numbers)
            {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }

            // Comprobar si el Dictionary contiene la clave 2
            bool containsTwo = numbers.ContainsKey(2);

            // Imprimir si el Dictionary contiene la clave 2
            Console.WriteLine("El diccionario contiene la clave 2: " + containsTwo);

            // Contar el número de elementos del Dictionary
            int count = numbers.Count;

            // Imprimir el número de elementos del Dictionary
            Console.WriteLine("El numero de elementos del diccionario es de:" + count);


            // Declarar un Dictionary de cadenas
            Dictionary<string, int> scores = new Dictionary<string, int>();

            // Agregar elementos al Dictionary
            scores.Add("Miguel", 100);
            scores.Add("Ana", 90);
            scores.Add("Antonio", 80);

            // Imprimir el Dictionary
            Console.WriteLine("\n\n\nDiccionario de String inicial");
            foreach (KeyValuePair<string, int> entry in scores)
            {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }

            // Comprobar si el Dictionary contiene la clave "Ana"
            bool containsAna = scores.ContainsKey("Ana");

            // Imprimir si el Dictionary contiene la clave "Ana"
            Console.WriteLine("El diccionario contiene la clave 'Ana': " + containsAna);

            // Obtener el valor asociado a la clave "Antonio"
            int antonioScore = scores.GetValueOrDefault("Antonio");

            // Imprimir el valor asociado a la clave "Antonio"
            Console.WriteLine("El punteo de Antonio es de : " + antonioScore);

            // Contar el número de elementos del Dictionary
            int count2 = scores.Count;

            // Imprimir el número de elementos del Dictionary
            Console.WriteLine("El diccionario tiene " + count2 + " elementos");


        }
    }
}
