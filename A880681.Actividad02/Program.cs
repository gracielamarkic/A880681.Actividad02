using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A880681.Actividad02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ingreso de operadores
            Dictionary<int, string> operadores = new Dictionary<int, string>()
            {
                [01] = "Juan Perez",
                [02] = "Pedro Gomez",
            };

            foreach (KeyValuePair<int, string> elemento in operadores)
            {
                Console.WriteLine($"El numero de operador es {elemento.Key}, y el nombre del operador es {elemento.Value}");
            }
            // Ingreso de ordenes
            Queue<int> colaDeOrdenes = new Queue<int>();
            colaDeOrdenes.Enqueue(101);
            colaDeOrdenes.Enqueue(102);
            colaDeOrdenes.Enqueue(103);
            colaDeOrdenes.Enqueue(104);
            colaDeOrdenes.Enqueue(105);

            Console.WriteLine("La cola de ordenes es");

            foreach (int colaDeOrden in colaDeOrdenes)
            {
                Console.WriteLine(colaDeOrden);
            }
            //Asignacion de orden a operadores

            Console.WriteLine();
            while (colaDeOrdenes.Count > 0)
            {
                int sacarUnaOrden = colaDeOrdenes.Dequeue();
                Console.WriteLine("Asigno a operador: " + sacarUnaOrden);
            }

            Console.ReadKey();
        }
    }
}
