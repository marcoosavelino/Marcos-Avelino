﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Lista_14_Métodos
{
    class Program
    {
        /*Fazer um programa para obter três notas e calcular e exibir a sua média, usando
uma função para o cálculo da média.*/

        static double MédiaNota(int pValor1, int pValor2, int pValor3)
        {
            return (pValor1 + pValor2 + pValor3) / 3;
        }
        /*Criar um algoritmo que receba um número que corresponda há um mês no
        primeiro trimestre e escreva o nome do mês correspondente.Caso o usuário
        digite o número fora do intervalo, deverá aparecer inválido.Utilize uma função
        chamada Mes.*/
        static string Mês(int pNum)
        {
            string Mês = "";
            if (pNum == 1)
            {
                Mês = "Janeiro";
            }
            else if (pNum == 2)
            {
                Mês = "Fevereiro";
            }
            else if (pNum == 3)
            {
                Mês = "Março";
            }
            else
            {
                Console.WriteLine("Número Inválido!");
            }
            return Mês;
        }
        /*Faça uma função para verificar se a raiz quadrada de um número inteiro é exata
ou não.*/
        static bool RaizQuadrada(int pNum)
        {
            bool exatidão;
            double resultado;

            resultado = (Math.Sqrt(pNum));

            if (resultado%1 == 0)
            {
                exatidão = true;
            }
            else
            {
                exatidão = false;
            }
           
            return exatidão;
         }
        /*Faça um método que recebe por parâmetro um valor inteiro e positivo e retorna
o valor lógico Verdadeiro caso o valor seja primo e Falso em caso contrário.*/

            static bool Primo (int pNum)
        {
            bool primo = true;
            int div=0;
            for (int i = pNum; i > 0; i--)
            {
                if (pNum % i == 0)
                {
                    div++;
                }

                if (div == 2)
                {
                    primo = true;
                }
                else
                {
                    primo = false;
                }
            }
            return primo;
        }

        /*Escreva uma função que recebe, por parâmetro, dois valores X e Z e calcula e
retorna x elevado à z.*/

            static double Potência (double pValorX,double pValorZ)
        {
            double potencia=0;

            potencia = Math.Pow(pValorX, pValorZ);

            return potencia;
        }
        /*Escreva um procedimento que recebes 3 valores reais X, Y e Z e que verifique
           se esses valores podem ser os comprimentos dos lados de um triângulo e, neste
           caso, retornar qual o tipo de triângulo formado.Para que X, Y e Z formem um
           triângulo é necessário que a seguinte propriedade seja satisfeita: o comprimento
           de cada lado de um triângulo é menor do que a soma do comprimento dos
           outros dois lados.O procedimento deve identificar o tipo de triângulo formado
           observando as seguintes definições:
         a. Triângulo Equilátero: os comprimentos dos 3 lados são iguais.
         b. Triângulo Isósceles: os comprimentos de 2 lados são iguais.
         c. Triângulo Escaleno: os comprimentos dos 3 lados são diferentes.*/

            static void Triângulo (double pValorX,double pValorY,double pValorZ)
        {
            if (pValorX > pValorY+pValorZ)
            {
                Console.WriteLine("As medidas não formam um triângulo");
            }

            if (pValorX == pValorY && pValorX == pValorZ)
            {
                Console.WriteLine("Triângulo Equilátero!!");
            }
            else if (pValorX != pValorY && pValorX != pValorZ)
            {
                Console.WriteLine("Triângulo Escaleno!!");
            }
            else
            {
                Console.WriteLine("Triângulo Isósceles!!");
            }
            
        }

        static void MenuPrincipal()
        {
            ConsoleKeyInfo lerTecla;
            do
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("|  Tecla  |     Exercício   |");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("|    F1   |       Ex 01     |");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("|    F2   |       Ex 02     |");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("|    F3   |       Ex 03     |");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("|    F4   |       Ex 04     |");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("|    F5   |       Ex 05     |");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("|    F6   |       Ex 06     |");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("|   Esc   |       Sair      |");
                Console.WriteLine("-----------------------------");

                Console.WriteLine("Informe o exercício desejado: ");
                lerTecla = Console.ReadKey();

            } while (lerTecla.Key != ConsoleKey.F1 && lerTecla.Key != ConsoleKey.F2 && lerTecla.Key != ConsoleKey.F3 && lerTecla.Key != ConsoleKey.F4 && lerTecla.Key != ConsoleKey.F5 && lerTecla.Key != ConsoleKey.F6 && lerTecla.Key != ConsoleKey.Escape);

            switch (lerTecla.Key)
            {
                
                case ConsoleKey.F1:
                    Console.WriteLine(MédiaNota(3, 5, 8));
                    MenuPrincipal();
                    break;
                case ConsoleKey.F2:
                    Console.WriteLine(Mês(2));
                    MenuPrincipal();
                    break;
                case ConsoleKey.F3:
                    Console.WriteLine(RaizQuadrada(9));
                    MenuPrincipal();
                    break;
                case ConsoleKey.F4:
                    Console.WriteLine(Primo(17));
                    MenuPrincipal();
                    break;
                case ConsoleKey.F5:
                    Console.WriteLine(Potência(2, 5));
                    MenuPrincipal();
                    break;
                case ConsoleKey.F6:
                    Triângulo(10,20,10);
                    MenuPrincipal();
                    break;
                 default:
                    Console.WriteLine("Fim!!!");
                    break;
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            MenuPrincipal();

          
        }
    }
}
