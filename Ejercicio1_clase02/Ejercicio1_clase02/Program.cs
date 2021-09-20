using System;

namespace Ejercicio1_clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Alumno alumno1 = new Alumno("Jorge", "Carrascal", 5.5, 4.5);
            Alumno alumno2 = new Alumno("Enzo", "Perez", 9.5, 8.8);
            Alumno alumno3 = new Alumno("Nicolas", "De La Cruz", 7.9, 8.5);

            Console.Write(alumno1.GetNombre());
            Console.WriteLine(alumno1.GetApellido());
            Console.WriteLine(alumno1.MostrarPromedio());
            Console.Write(alumno2.GetNombre());
            Console.WriteLine(alumno2.GetApellido());
            Console.WriteLine(alumno2.MostrarPromedio());
            Console.Write(alumno3.GetNombre());
            Console.WriteLine(alumno3.GetApellido());
            Console.WriteLine(alumno3.MostrarPromedio());
        }
    }// int.TryParse();
}