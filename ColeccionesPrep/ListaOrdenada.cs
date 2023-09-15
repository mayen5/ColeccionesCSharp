using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesPrep
{
    public class ListaOrdenada
    {
        public void EjemploListaOrdenada()
        {
            // Declarar una SortedList de enteros y cadenas
            SortedList<int, string> dictionary = new SortedList<int, string>();

            // Agregar elementos a la SortedList
            dictionary.Add(2, "Maria");
            dictionary.Add(5, "Ana");
            dictionary.Add(1, "Juan");
            dictionary.Add(4, "Anthony");
            dictionary.Add(3, "Peter");

            // Imprimir la SortedList
            foreach (KeyValuePair<int, string> entry in dictionary)
            {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }
        }
    }
}
