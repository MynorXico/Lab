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
                    else
                        Console.WriteLine("El número debe ser mayor a 0");
                }
                catch (Exception e)
                {
                    Console.WriteLine("El número ingresado no es válido");
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

                seleccionUsuario = Console.ReadLine();
                switch (seleccionUsuario)
                {
                    case "a":
                        entradaValida = true;
                        Console.WriteLine(" --- SUMATORIA ---");
                        Console.WriteLine("Ingrese un número ");
                        int num1 = int.Parse(Console.ReadLine());

                        int sum = 0;
                        do
                        {
                            sum += num1;
                            num1--;
                        } while (num1 > 0);
                        Console.WriteLine("El resultado es " + sum);
                        break;
                    case "b":
                        entradaValida = true;
                        Console.WriteLine(" --- SUMATORIA ---");
                        Console.WriteLine("Ingrese un número ");
                        int num2 = int.Parse(Console.ReadLine());
                        int ans = 1;

                        for (int j = 1; j <= num2; j++)
                        {
                            ans *= j;
                        }

                        Console.WriteLine("El resultado es " + ans);
                        break;
                    case "c":
                        entradaValida = true;
                        Console.WriteLine(" --- SUMATORIA ---");
                        Console.WriteLine("Ingrese un número ");
                        int num3 = int.Parse(Console.ReadLine());

                        int a = 0;
                        int b = 0;
                        int c = 0;
                        int i = 2;

                        string resultados = "";
                        if (num3 > 0) {
                            resultados = a.ToString();
                            if (num3 > 1) {

                                resultados = resultados + " " + b;
                                while (i < num3) {
                                    c = a + b;
                                    resultados += resultados + " " + c;
                                    a = b;
                                    b = c;
                                    i = i + 1;
                                }
                                Console.Write(resultados);
                            }
                            resultados = resultados + " " + b;
             
                        }
                        Console.WriteLine(resultados);

                        break;
                    default:
                        Console.WriteLine("Seleccione una opción válida. ");
                        break;
                }
            } while (!entradaValida);
           
            Console.ReadLine();
        }
    }
}
