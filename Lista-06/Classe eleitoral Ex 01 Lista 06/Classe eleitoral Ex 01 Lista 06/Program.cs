﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_eleitoral_Ex_01_Lista_06
{
    class Program

       // Construa um algoritmo em C# que leia a idade de uma pessoa e informe a sua classe eleitoral:
       // - não eleitor(abaixo de 16 anos);
       // - eleitor obrigatório(acima de 17 anos e menor de 65 anos);
       //- eleitor facultativo(de 16 até 17 anos e maior de 65 anos, inclusive).
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Informe a sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());


           if ((idade > 17) && (idade < 66)) 
            {
                Console.WriteLine("Seu voto é obrigatório!");
            }
            else if ((idade < 18 && idade > 15) || (idade > 65))
            {
                Console.WriteLine("Seu voto é facultativo!");
            }
            else
            {
                Console.WriteLine("NÃO ELEITOR!!!");
            }

            Console.ReadKey();
        }
    }
}
