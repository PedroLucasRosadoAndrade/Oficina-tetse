using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        /*Console.Write("Digite um número: ");
        double num = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite outro número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = num + num2;

        Console.WriteLine($"O resultado da multiplicação é {resultado}");

        Console.ReadKey();*/


        

       while (true)
       {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Você é Gay: ");
            string resp = Convert.ToString(Console.ReadLine());


            String resultado = resp;

            if (resp == "sim")
            {
                Console.WriteLine("Hummmmmmmmmm");
            }
            else
            {
                /*for (int i = 0; i  resp; i++)
                */{
                    Console.WriteLine("é sim rapais");
               // }
            }
        }
    }
}