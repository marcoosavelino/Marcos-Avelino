using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternário_Ex_04_Lista_08
{
    class Program

        // Faça um algoritmo que leia dois valores inteiros A e B se os valores forem iguais deverá se
        // somar os dois, caso contrário multiplique A por B.Ao final de qualquer um dos cálculos deve-se
        // atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.
    {
        static void Main(string[] args)
        {
            int A, B, C;

            Console.WriteLine("Informe o valor de A:");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o valor de B:");
            B = Convert.ToInt32(Console.ReadLine());

            C = 0;

            if (A == B)
            {
                Console.WriteLine("O Valor de C é: {0}",(C = A + B));
            }
            else
            {
                Console.WriteLine("O Valoe de C é: {0}", (C = A * B));
            }
            

            Console.ReadKey();
        }
    }
}
