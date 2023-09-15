using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesPrep
{
    public class Pilas
    {
        public void EjemploPilas()
        {
            // Declarar una pila de enteros
            Stack<int> numbers = new Stack<int>();

            // Agregar elementos a la pila
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);

            // Imprimir la pila
            Console.WriteLine("Pila inicial: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Eliminar el primer elemento de la pila
            int firstNumber = numbers.Pop();

            // Imprimir el primer elemento de la pila
            Console.WriteLine("Primer numero de la pila: " + firstNumber);

            // Imprimir la pila
            Console.WriteLine("Pila final: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Comprobar si la pila contiene el número 2
            bool containsTwo = numbers.Contains(2);

            // Imprimir si la pila contiene el número 2
            Console.WriteLine("La pila contiene el numero 2:" + containsTwo);

            // Contar el número de elementos de la pila
            int count = numbers.Count;

            // Imprimir el número de elementos de la pila
            Console.WriteLine("Numero de elementos de la pila: " + count);
        }
    }
}
