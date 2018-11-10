using System;

namespace HT09_FernandaGuzman_1282317
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2");
            double[] arreglo = new double[50];
            for (int i = 0; i < arreglo.Length; i++) {
                Console.WriteLine("Ingrese el número para la posición " + i);

                double input = double.Parse(Console.ReadLine());
                arreglo[i] = input;
            }

            Console.WriteLine("Arreglo Ingresado: ");
            Console.Write(arreglo[0]);
            for (int i = 1; i < arreglo.Length; i++) {
                Console.Write(", " + arreglo[i]);
            }
            Console.WriteLine("\nIngrese el número de elementos que desea ver: ");
            int n = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < n; i++) {
                Console.Write(arreglo[i] + " ");
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ejercicio 3");
            Console.WriteLine("Ingrese el número de elementos que tendrá el arreglo de cadenas");
            string[] strArr = new string[int.Parse(Console.ReadLine())];
            for (int i = 0; i < strArr.Length; i++) {
                Console.WriteLine("Ingrese el número para la posición " + i);
                strArr[i] = Console.ReadLine();
            }

            Console.WriteLine("Arreglo ingresado");
            for (int i = 0; i < strArr.Length; i++) {
                Console.WriteLine(strArr[i] + "  ");
            }

            Console.ReadKey();
        }
    }
}
