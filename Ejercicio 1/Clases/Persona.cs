using Ejercicio_1.Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public string Carrera { get; set; }
        public int Edad { get; set;}

        public void PedirDatos()
        {
            Console.WriteLine("Ingresa tu nombre");
            this.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu Apellido");
            this.Apellido = Console.ReadLine();
            Console.WriteLine("Ingresa tu Carrera");
            this.Carrera = Console.ReadLine();
            Console.WriteLine("Ingresa tu Edad");
            this.Edad = int.Parse(Console.ReadLine());

            Console.Clear();

            if (Edad >= 18)
            {
                Menu menu = new Menu();

                menu.Opciones();
                Console.WriteLine(this.Nombre);
                Console.WriteLine(this.Apellido);
                Console.WriteLine(this.Carrera);
                Console.WriteLine(this.Edad);

            }


            else
            {
                Console.WriteLine("No puedes hacer las operaciones porque no cumples la mayoria de edad");
            }
        }

        
    }

    
}

