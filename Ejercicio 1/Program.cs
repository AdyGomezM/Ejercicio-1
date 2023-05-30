using Ejercicio_1.Clases;
using System;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDOS");

            Persona persona = new Persona();

            persona.PedirDatos();
        }
    }
}
