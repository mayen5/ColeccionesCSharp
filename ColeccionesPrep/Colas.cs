using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesPrep
{
    public class Colas
    {
        public void EjemploColas()
        {
            // Declarar una cola de enteros
            Queue<int> numbers = new Queue<int>();

            // Agregar elementos a la cola
            numbers.Enqueue(2);
            numbers.Enqueue(1);
            numbers.Enqueue(3);

            // Imprimir la cola
            Console.WriteLine("Cola inicial");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Eliminar el primer elemento de la cola
            int firstNumber = numbers.Dequeue();

            // Imprimir el primer elemento de la cola
            Console.WriteLine("Primer elemento de la cola");
            Console.WriteLine(firstNumber);

            // Comprobar si la cola contiene el número 3
            bool containsThree = numbers.Contains(3);

            // Imprimir si la cola contiene el número 3
            Console.WriteLine("Comprobar si la cola contiene el numero 3");
            Console.WriteLine(containsThree);

            //Imprimir la cola final
            Console.WriteLine("Cola final");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Contar el número de elementos de la cola
            int count = numbers.Count;

            // Imprimir el número de elementos de la cola
            Console.WriteLine("Cantidad de elementos de cola");
            Console.WriteLine(count);
            Console.WriteLine("#################\n\n");

            // Declarar una Queue de cadenas
            Queue<string> names = new Queue<string>();

            // Agregar elementos a la Queue
            names.Enqueue("Pedro");
            names.Enqueue("Juan");
            names.Enqueue("Maria");

            // Imprimir la Queue
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
