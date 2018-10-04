using System;

namespace Tarea6_FernandaGuzman_1282317
{
    class Program
    {
        static void Main(string[] args)
        {
            bool entradaValida = false;
            int a = -1;

            while (!entradaValida)
            {
                Console.WriteLine("Ingrese un número mayor a 0: ");
                try
                {
                    a = int.Parse(Console.ReadLine());
                    if (a <= 0)
                    {
                        Console.WriteLine("El número debe ser mayor a 0");
                    }
                    else
                    {
                        entradaValida = true;
                    }
                }
                catch
                {
                    Console.WriteLine("Debe ingresar un número. ");
                }
            }
            double n = Convert.ToDouble(a);

            /*Primera serie*/
            double ans1 = 0;
            double ans2 = 0;
            for (int i = 1; i <= n; i++)
            {
                ans1 += 1 / Convert.ToDouble(i);              // Primera serie
                ans2 += 1 / (Math.Pow(2, i));    // Segunda serie
            }

            Console.WriteLine("Primera Serie: " + ans1);
            Console.WriteLine("Segunda Serie: " + ans2);

            Console.ReadKey();
        }
    }
}
