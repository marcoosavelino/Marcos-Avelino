﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Método
{
    class Program
    {
        // Crie um método que receba um número inteiro e informe se ele é positivo(true) ou
        // negativo(false) através de um retorno com boolean.
        static bool positivo(int num)
        {
            bool texto;
            if (num >= 0)
            {
                texto = true;
            }
            else
            {
                texto = false;
            }


            return texto;
        }
        static int MaiorValor(int pNum, int pNum2)
        {
            int maiorvalor = 0;

            if (pNum > pNum2)
            {
                maiorvalor = pNum;
            }
            else
            {
                maiorvalor = pNum2;
            }
            return maiorvalor;
        }
        static int MenorValor(int pNum, int pNum2)
        {
            int menorvalor = 0;

            if (pNum < pNum2)
            {
                menorvalor = pNum;
            }
            else
            {
                menorvalor = pNum2;
            }

            return menorvalor;
        }
        static int Dado()
        {
            Random numAle = new Random();
            int sorteio = numAle.Next(1,7);
            return sorteio;
        }

        static void Lado1000()
        {
            Random numAle = new Random();
            
            int c = 0, co = 0, con = 0, cont = 0, conta = 0, contad = 0;

            for (int i = 0; i < 1000; i++)
            {
                int sorteio = numAle.Next(1, 7);
                Console.WriteLine("Contador: {0} Número Sorteado: {1}",i,sorteio);

                if (sorteio == 1)
                {
                    c++;
                }
                else if (sorteio == 2)
                {
                    co++;
                }
                else if (sorteio == 3)
                {
                    con++;
                }
                else if (sorteio == 4)
                {
                    cont++;
                }
                else if (sorteio == 5)
                {
                    conta++;
                }
                else
                {
                    contad++;
                }

            }


            Console.WriteLine("O número 1 saiu {0} vezes", c);
            Console.WriteLine("O número 2 saiu {0} vezes", co);
            Console.WriteLine("O número 3 saiu {0} vezes", con);
            Console.WriteLine("O número 4 saiu {0} vezes", cont);
            Console.WriteLine("O número 5 saiu {0} vezes", conta);
            Console.WriteLine("O número 6 saiu {0} vezes", contad);
        }

        static bool Primo(int pNum)
        {
            int div = 0;
            bool primo = false;

            for (int i = pNum; i > 0; i--)
            {
                if (pNum % i == 0)
                {
                    div++;
                }

            }
            if (div == 2)
            {
                primo = true;
            }
            else
            {
                primo = false;
            }
            return primo;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo lerTecla;

            
                Console.WriteLine("-------------------------------");
                Console.WriteLine("|    Tecla    |     Exercício  ");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("|     F1      |       EX 01    ");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("|     F2      |       EX 02    ");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("|     F3      |       EX 03    ");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("|     F4      |       EX 04    ");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("|     F5      |       EX 05    ");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("|     F6      |       EX 06    ");
                Console.WriteLine("-------------------------------");

                Console.WriteLine("Informe o exercício desejado:");
                lerTecla = Console.ReadKey();



            switch (lerTecla.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    Console.WriteLine("---------------------");
                    Console.WriteLine("     Exercício 01    ");
                    Console.WriteLine("   Número Positivo?  ");
                    Console.WriteLine("---------------------");

                    int valor;

                    Console.WriteLine("Informe um número: ");
                    valor = Convert.ToInt32(Console.ReadLine());                   

                    Console.WriteLine("O número {0} é positivo? {1}",valor, positivo(valor));

                    break;
                case ConsoleKey.F2:
                    Console.Clear();

                    Console.WriteLine("--------------------------");
                    Console.WriteLine("        Exercício 02      ");
                    Console.WriteLine("   Qual é o maior valor?  ");
                    Console.WriteLine("--------------------------");

                    int valor1;
                    int valor2;

                    Console.WriteLine("Digite o primeiro valor:");
                    valor1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo valor:");
                    valor2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("O maior valor é: {0}", MaiorValor(valor1, valor2));
                    break;
                case ConsoleKey.F3:
                    Console.Clear();

                    Console.WriteLine("--------------------------");
                    Console.WriteLine("        Exercício 03      ");
                    Console.WriteLine("   Qual é o menor valor?  ");
                    Console.WriteLine("--------------------------");

                    int num1, num2;

                    Console.WriteLine("Informe o primeiro valor:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o segundo valor:");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("O menor valor é: {0}", MenorValor(num1, num2));
                    break;
                case ConsoleKey.F4:
                    Console.Clear();

                    Console.WriteLine("--------------------------");
                    Console.WriteLine("      Exercício 04        ");
                    Console.WriteLine("     Sorteio de Dados     ");
                    Console.WriteLine("--------------------------");

                    Console.WriteLine("Ao lançar os dados na mesa saiu o número: {0}", Dado());

                    break;
                case ConsoleKey.F5:
                    Console.Clear();

                    Console.WriteLine("----------------------------");
                    Console.WriteLine("        Exercício 05        ");
                    Console.WriteLine("   Sorteio de Dados 1.000x  ");
                    Console.WriteLine("----------------------------");

                    Console.WriteLine("Ao lançar os dados 1.000x saiu:");
                    Lado1000();
                    break;
                case ConsoleKey.F6:
                    Console.Clear();

                    Console.WriteLine("----------------------------");
                    Console.WriteLine("        Exercício 06        ");
                    Console.WriteLine("    Este número é primo ?   ");
                    Console.WriteLine("----------------------------");

                    int numero;

                    Console.WriteLine("Digite um número: ");
                    numero = Convert.ToInt32(Console.ReadLine().ToString());

                    Console.WriteLine("O número {0} informado acima é um número primo? {1}",numero, Primo(numero));
                    break;

            }
            Console.ReadKey();
        }
    }
}
