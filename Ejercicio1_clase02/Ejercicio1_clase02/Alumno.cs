using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_clase02
{
    public class Alumno
    {
        public string nombre;
        public string apellido;
        public double nota1;
        public double nota2;


        public Alumno(string nombre, string apellido, double nota1, double nota2)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public string MostrarPromedio()
        {
            double promedio;
            promedio = (this.nota1 + this.nota2) / 2;

            return $"Su promedio es de:{promedio}";
        }
        public string GetNombre()
        {
            return $"Alumno:{nombre}";
        }
        public string GetApellido()
        {
            return $" {apellido}";
        }
    }
}
