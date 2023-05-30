using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Funciones
{
    public class Menu
    {
        public int num1, num2, num3, num4,num5;
        double dolarpeso;
        public void Opciones()
        {
            Console.WriteLine("Ingresa una de las opciones");
            Console.WriteLine("1: suma");
            Console.WriteLine("2: resta");
            Console.WriteLine("3: multiplicacion");
            Console.WriteLine("4: Cambiar de dolar a pesos");
            int opcion =int.Parse(Console.ReadLine());

            Console.Clear();
           


            Operaciones operaciones = new Operaciones();
            
            double result  = 0;
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingresa el primer valor");
                     num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo valor");
                     num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el tercer valor");
                     num3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el cuarto valor");
                     num4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el quinto  valor");
                     num5 = int.Parse(Console.ReadLine());
                    result = operaciones.Suma(num1, num2, num3, num4, num5);
                    Console.WriteLine("El resuldos es " + result);
                    break;
                case 2:
                    Console.WriteLine("Ingresa el primer valor");
                     num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo valor");
                    num2 = int.Parse(Console.ReadLine());
                    result = operaciones.Resta(num1, num2);
                    Console.WriteLine("El resultado es " + result);
                    break;

                case 3:
                    Console.WriteLine("Ingresa el primer valor");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo valor");
                     num2 = int.Parse(Console.ReadLine());
                    result = operaciones.Multiplicacion(num1, num2);
                    Console.WriteLine("El resultado es " + result);
                    break;
                case 4:
                    Console.WriteLine("¿Cuantos dolares tienes ?");
                    num1 = int.Parse(Console.ReadLine());
                    result = operaciones.ValorDolar(num1, dolarpeso);
                    Console.WriteLine("Tienes en pesos mexicanos : "+ result);
                    break;
                default:
                    Console.WriteLine("No hay opcion; c");
                    break;

            }
        }
    }
}
