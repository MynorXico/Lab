using System;

namespace Lab6_FernandaGuzman_1282317
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************");
            Console.WriteLine("Laboratorio No. 06");        // Numeral 1

            Boolean entradaValida = false;
           
            do {
                Console.WriteLine("Ingrese un número mayor que 0: ");
                try
                {

                    int a = int.Parse(Console.ReadLine());
                    if (a > 0)
                        entradaValida = true;
                    else {
                        Console.WriteLine("El número debe ser mayor a 0");
                        Console.Clear();
                    }
                                           
                }
                catch (Exception e)
                {
                    Console.WriteLine("El número ingresado no es válido");
                    Console.Clear();
                }
            } while (!entradaValida);
     
            Console.WriteLine("Gracias...");


            entradaValida = false;
            string seleccionUsuario = "";
            do
            {
                Console.WriteLine("Seleccione la opción que desea: ");
                Console.WriteLine("a. Sumatoria");
                Console.WriteLine("b. Factorial");
                Console.WriteLine("c. Fibonacci");
                Console.WriteLine("d. SALIR");

                seleccionUsuario = Console.ReadLine();
                switch (seleccionUsuario)
                {
                    case "a":
                        Console.WriteLine(" --- SUMATORIA ---");
                        Console.WriteLine("Ingrese un número ");
                        int num1 = int.Parse(Console.ReadLine());

                        int sum = 0;
                        do
                        {
                            sum += num1;
                            num1--;
                        } while (num1 > 0);
                        Console.WriteLine("Sumatoria del número " + num1 + " es: " + sum);
                        break;
                    case "b":
                        Console.WriteLine(" --- Factorial ---");
                        Console.WriteLine("Ingrese un número ");
                        int num2 = int.Parse(Console.ReadLine());
                        int ans = 1;

                        for (int j = 1; j <= num2; j++)
                        {
                            ans *= j;
                        }

                        Console.WriteLine("Factorial del número " + num2 + " es: " + ans);
                        break;
                    case "c":
                        Console.WriteLine(" --- FIBONACCI ---");
                        Console.WriteLine("Ingrese un número ");
                        int num3 = int.Parse(Console.ReadLine());

                        int a = 0;
                        int b = 1;
                        int c = 0;
                        int i = 2;
                        string serie = "";
                        if (num3 > 0) {
                            serie = serie + " " + a;
                            if (num3 > 1) {
                                serie = serie + " " + b;
                            }
                            while (i < num3) {
                                c = a + b;

                                i++;
                                serie = serie + " " + c;
                                a = b;
                                b = c;
                            }
                        }
                        
                        Console.WriteLine("Primeros " + num3 + " números de serie Fibonacci: " + serie);
                        break;
                    case "d":
                        entradaValida = true;
                        break;
                    default:
                        Console.WriteLine("Seleccione una opción válida. ");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (!entradaValida);
           
            Console.ReadLine();
        }
    }
}
