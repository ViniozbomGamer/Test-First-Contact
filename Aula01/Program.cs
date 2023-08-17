using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Olá mundo!");*///Escreve na tela do console
            double lado, resultado;

            Console.WriteLine("Digite o valor do lado:");
            lado = double.Parse(Console.ReadLine());
            resultado = lado * lado;
            Console.WriteLine("Resultado é =" +resultado);

            Console.ReadKey();



        }
    }
}
