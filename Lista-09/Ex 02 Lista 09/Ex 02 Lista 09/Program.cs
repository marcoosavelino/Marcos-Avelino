using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02_Lista_09
{
    class Program
        // Crie um programa que gere 100 números desconhecido de valores inteiros, entre 0 e 100,
        // um de cada vez, e conte quantos deles estão em cada um dos intervalos[0, 25], (25, 50],
        // (50, 75], (75, 100].
    {
        static void Main(string[] args)
        {
            int intervalo1=0,intervalo2=0,intervalo3=0,intervalo4=0;
            Random numAleatorio = new Random();
            int numero = numAleatorio.Next(0, 101);

            for (int i = 0; i < 100; i++)
            {
                numero = numAleatorio.Next(0, 100);
                Console.WriteLine("Contador : {0} Número Aleatório: {1}", i, numAleatorio.Next(0, 100));


                if (numero >= 0 && numero <= 25)
                {
                    intervalo1 += 1;
                    
                }
                if (numero > 25 && numero <= 50)
                {
                    intervalo2 += 1;
                  
                }
                if (numero > 50 && numero <= 75)
                {
                    intervalo3 += 1;
                   
                }
                if (numero > 75 && numero <= 100)
                {
                    intervalo4 += 1;
                }
               
            }
            Console.WriteLine(intervalo1);
            Console.WriteLine(intervalo2);
            Console.WriteLine(intervalo3);
            Console.WriteLine(intervalo4);
            Console.ReadKey();
        }
    }
}
