using System;

namespace AppConsolaPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;
            string numString;

            Console.WriteLine("Ingrese un numero:");

            numString = Console.ReadLine();

            num1 = int.Parse(numString);

            Console.WriteLine("Ingrese otro numero:");

            numString = Console.ReadLine();

            num2 = int.Parse(numString);

            result = num1 + num2;

            Console.WriteLine($"El resultado es: {result}");

        }
    }
}
