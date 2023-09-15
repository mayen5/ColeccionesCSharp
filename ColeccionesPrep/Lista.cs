using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesPrep
{
    public class Lista
    {
        public void EjemploListaInt()
        {
            // Declarar una lista de enteros
            List<int> numbers = new List<int> ();

            //Agregar elementos a la lista
            numbers.Add(3);
            numbers.Add(6);
            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(7);
            numbers.Add(2);

            // Imprimir la lista desordenada
            Console.WriteLine("________________");
            Console.WriteLine("Lista desordenado");
            Console.WriteLine("________________\n");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("________________\n");

            // Imprimir la lista ordenada
            Console.WriteLine("________________");
            Console.WriteLine("Lista ordenado");
            Console.WriteLine("________________\n");

            numbers.Sort();
            //numbers.Reverse();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("________________\n");

            // Imprimir la lista ordenada
            Console.WriteLine("________________");
            Console.WriteLine("Lista menores de 5");
            Console.WriteLine("________________\n");
            var lowerThan = numbers.Where(x => x < 5);
            foreach (int number in lowerThan)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("________________\n");

        }

        public void EjemploListaString()
        {
            // Declarar una lista de cadenas
            List<string> names = new List<string>();

            // Agregar elementos a la lista
            names.Add("Flor");
            names.Add("Fernanda");
            names.Add("Carlos");
            names.Add("Anthony");

            // Imprimir la lista
            Console.WriteLine("________________");
            Console.WriteLine("Lista desordenado");
            Console.WriteLine("________________\n");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Imprimir la lista ordenada
            Console.WriteLine("________________");
            Console.WriteLine("Lista ordenado");
            Console.WriteLine("________________\n");

            names.Sort();
            //numbers.Reverse();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("________________\n");

            // Imprimir la lista ordenada
            Console.WriteLine("________________");
            Console.WriteLine("Lista Nombres con F");
            Console.WriteLine("________________\n");
            var namesWithA = names.Where(x => x[0] == 'F' || x[0] == 'A');
            foreach (string name in namesWithA)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("________________\n");
        }

    }
}
