﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Número_Primo_Ex_02_Lista_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, cont = 0;

            Console.WriteLine("Informe um número:");
            numero = Convert.ToInt32(Console.ReadLine());
            


            for (int i = numero; i > 0; i--)
            {

                if (numero%i == 0)
                {
                    cont++;
                }
            }

            if (cont == 2)
            {
                Console.WriteLine("O número é primo!");
            }
            else
            {
                Console.WriteLine("O número não é primo");
            }

            Console.ReadKey();
    

    }

    }
}
