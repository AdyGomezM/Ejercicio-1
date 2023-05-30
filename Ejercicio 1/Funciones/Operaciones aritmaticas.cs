using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Funciones
{
    internal class Operaciones
    {
        #region Otra forma de hacer la suma
        //int num1, num2;
        /*public void Suma()
        {
            Console.WriteLine("Ingresa un numero");
            num1= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"El resultado es {num1+num2} ");
        }*/
        #endregion 

        public int Suma(int num1,int num2,int num3,int num4,int num5)
        {
            int resultado =num1 + num2 + num3 + num4 + num5;

            return resultado;
        }
        public int Resta(int num1, int num2)
        {
            int resultado = num1 - num2;

            return resultado;
        }

        public int Multiplicacion(int num1, int num2)
        {
            int resultado = num1 * num2;

            return resultado;
        }
        public double ValorDolar(int num1, double dolarpeso)
        {
            dolarpeso = 17.87;
            double resultado = num1 * dolarpeso;
            return resultado;
        }
    }
}
