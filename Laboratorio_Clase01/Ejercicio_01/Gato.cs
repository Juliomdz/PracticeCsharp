using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    public class Gato
    {
        string nombre;
        string color;
        int edad;


        public Gato(string nombre, string color, int edad)
        {
            this.nombre = nombre;
            this.color = color;
            this.edad = edad;
        }
        public string gatoToString()
        {
            return $"Nombre: {nombre} /n Color: {color} /n Edad: {edad}";
        }
    }
}
