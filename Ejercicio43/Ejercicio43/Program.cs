using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio43
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
           
            string ingreso;
            int max;
            int min;
            
            List<int> listaDeNumeros;

            listaDeNumeros = new List<int>(); 

            do
            {
                Console.WriteLine("Ingrese un numero:");
                ingreso = Console.ReadLine(); 

                if (!int.TryParse(ingreso, out int numeroValido)) 
                {
                    Console.WriteLine(" No es un Numero valido, ingrese otro:");
                    continue; 
                }
                if(numeroValido == -1)
                {
                    exit = true; 
                }
                else
                {
                    listaDeNumeros.Add(numeroValido);
                }

            } while (!exit);
            max = listaDeNumeros.Max();
            min = listaDeNumeros.Min();
            int suma = listaDeNumeros.Sum();
            int promedio = (suma / listaDeNumeros.Count);
            Console.WriteLine($"El maximo es {max} ");
            Console.WriteLine($"El minimo es {min}");
            Console.WriteLine($"La suma de los numeros es {suma}");
            Console.WriteLine($"El promedio es {promedio}");
            Console.ReadKey(); 
        }
    }
}
