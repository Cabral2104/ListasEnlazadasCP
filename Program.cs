using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadasCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista enlazada de cadenas de texto
            LinkedList<string> listaEnlazada = new LinkedList<string>();

            // Agregar elementos a la lista enlazada
            listaEnlazada.AddLast("Manzana");
            listaEnlazada.AddLast("Banana");
            listaEnlazada.AddLast("Cereza");

            // Imprimir el contenido de la lista enlazada
            Console.WriteLine("Contenido de la lista enlazada:");
            foreach (string elemento in listaEnlazada)
            {
                Console.WriteLine(elemento);
            }

            // Verificar si la lista enlazada contiene un elemento específico
            bool contieneElemento = listaEnlazada.Contains("Banana");
            Console.WriteLine($"¿La lista enlazada contiene 'Banana'? {contieneElemento}");

            // Eliminar un elemento específico de la lista enlazada
            listaEnlazada.Remove("Banana");

            // Imprimir el contenido de la lista enlazada después de eliminar el elemento
            Console.WriteLine("Contenido de la lista enlazada después de eliminar 'Banana':");
            foreach (string elemento in listaEnlazada)
            {
                Console.WriteLine(elemento);
            }

            // Verificar si la lista enlazada está vacía
            if (listaEnlazada.Count == 0)
            {
                Console.WriteLine("La lista enlazada está vacía.");
            }
            else
            {
                Console.WriteLine("La lista enlazada NO está vacía.");
            }
            Console.ReadKey();
        }
    }
}
