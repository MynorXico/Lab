using System;

namespace HT10_FernandaGuzman_1282317
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");
            int[] arrInt = new int[10];
            for (int i = 0; i < arrInt.Length; i++) {
                Console.WriteLine("Ingrese el número en la posición " + i + " del arreglo.");
                arrInt[i] = int.Parse(Console.ReadLine());
            }

            int mayor = arrInt[0];
            for (int i = 1; i < arrInt.Length; i++) {
                if (arrInt[i] > mayor) {
                    mayor = arrInt[i];
                }
            }

            Console.Write("El número más grande se encuentra en las posiciones: ");
            for (int i = 0; i < arrInt.Length; i++) {
                if (arrInt[i] == mayor) {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ejercicio 2");

            Random r = new Random();
            double[] calificacion1 = new double[40];
            double[] calificacion2 = new double[40];
            double[] calificacion3 = new double[40];

            for (int i = 0; i < 40; i++) {
                calificacion1[i] = r.Next(40, 101);
                calificacion2[i] = r.Next(40, 101);
                calificacion3[i] = r.Next(40, 101);
            }

            double[] ObtenerNotaFinal(double[] c1, double[] c2, double[] c3) {
                double[] final = new double[40];
                for (int i = 0; i < 40; i++) {
                    final[i] = c1[i] * 0.3 + c2[i] * 0.3 + c3[i] * 0.4;
                }
                return final;
            }
            double[] notaFinal = ObtenerNotaFinal(calificacion1, calificacion2, calificacion3);
            Console.WriteLine("Primerar evaluación: ");
            for (int i = 0; i < calificacion1.Length; i++) {
                Console.Write(calificacion1[i] + " ");
            }
            Console.WriteLine("\nSegunda evaluación: ");
            for (int i = 0; i < calificacion2.Length; i++)
            {
                Console.Write(calificacion2[i] + " ");
            }
            Console.WriteLine("\nTercera evaluación: ");
            for (int i = 0; i < calificacion3.Length; i++)
            {
                Console.Write(calificacion3[i] + " ");
            }

            Console.WriteLine("\nResultado Final");
            for (int i = 0; i < calificacion3.Length; i++)
            {
                Console.Write(notaFinal[i] + " ");
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ejercicio 3");
            /*
             Fragmento de Algoritmo
             */
            string[] seAsumeArreglo;
            void DesplazarElementos(int p, string NuevaMarca) {
                for (int i = seAsumeArreglo.Length - 2; i >= p; i++) {
                    seAsumeArreglo[i + 1] = seAsumeArreglo[i];
                    seAsumeArreglo[p] = NuevaMarca;
                }
            }
        }
    }
}
