using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_07_Lista_04_Tabuada
{
    class Program
    {
        static void Main(string[] args)

        {
            int numero ,resultado;

            Console.WriteLine("Digite um número para construir uma tabuada:");
            numero = Convert.ToInt32(Console.ReadLine());
            


            for(int x = 0; x <= 10; x++)
            {
             resultado = numero * x;
             Console.WriteLine(numero+"*" +x+ "=" +resultado);

                

            }
            Console.ReadLine();

        }
    }
}
