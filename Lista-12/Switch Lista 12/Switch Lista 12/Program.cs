﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Lista_12
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo lerTecla;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("|   Tecla   |     Exercício    |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|    F1     |        Nº 1      |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|    F2     |        Nº 2      |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|    F3     |        Nº 3      |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|    F4     |        Nº 4      |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|    F5     |        Nº 5      |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|    F6     |        Nº 6      |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|    F7     |        Nº 7      |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|    F8     |        Nº 8      |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|    F9     |        Nº 9      |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|    F10     |       Nº 10     |");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Informe o exercício desejado:");
            lerTecla = Console.ReadKey();


            switch (lerTecla.Key)
            {

                case ConsoleKey.F1:
                    /* Escreva um programa em C# que lê 15 valores reais, encontra o maior e o menor deles e mostra o
                    resultado.*/
                    double valor, maiorvalor = 0, menorvalor = 10000000;


                    for (int i = 1; i < 16; i++)
                    {
                        Console.WriteLine("Informe um valor real:");
                        valor = Convert.ToDouble(Console.ReadLine());

                        if (valor > maiorvalor)
                        {
                            maiorvalor = valor;
                        }
                        if (valor < menorvalor)
                        {
                            menorvalor = valor;
                        }

                    }

                    Console.WriteLine("O Maior valor é: {0}", maiorvalor);
                    Console.WriteLine("O Menor valor é: {0}", menorvalor);

                    break;
                case ConsoleKey.F2:
                    // Faça um programa em C para exibir a tabuada de 0 a 9.
                    int cont = 0, resultado, numero = 0;

                    Console.WriteLine("Informe um valor:");
                    numero = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i < 10; i++)
                    {
                        cont++;
                        resultado = numero * cont;

                        Console.WriteLine(" {0} * {1} = {2}", numero, cont, resultado);
                    }
                    break;
                case ConsoleKey.F3:
                    /*Faça um programa em C# que calcula o produto dos números digitados pelo usuário. O programa
em C deve permitir que o usuário digite uma quantidade não determinada de números.O programa
se encerra quando o usuário digita o valor zero.*/

                    double num = 1, result = 1;

                    while (num != 0)
                    {
                        result *= num;
                        Console.WriteLine("Informe um número:");
                        num = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("O Produto dos números é: {0}", result);

                    break;
                case ConsoleKey.F4:
                    /*Dado um número n inteiro e positivo, dizemos que n é perfeito se n for igual à soma de seus
divisores positivos diferentes de n.Construa um programa em C# que verifica se um dado número é
perfeito.Ex: 6 é perfeito, pois 1 + 2 + 3 = 6.*/

                    int n, divisor = 0, somadivisor = 0;

                    Console.WriteLine("Digite um número:");
                    n = Convert.ToInt32(Console.ReadLine());

                    for (int i = n - 1; i > 0; i--)
                    {

                        if (n % i == 0)
                        {
                            divisor = i;
                        }
                        somadivisor += divisor;

                    }
                    if (somadivisor == n)
                    {
                        Console.WriteLine("Este número é perfeito !!");
                    }
                    else
                    {
                        Console.WriteLine("Este número não é perfeito !!");
                    }
                    break;
                case ConsoleKey.F5:
                    /*Escreva um programa em C que gera números entre 1000 e 1999 e mostra aqueles que divididos por
                       11 dão resto 5.*/

                    Random numAleatorio = new Random();


                    for (int i = 0; i < 1000; i++)
                    {
                        int n1 = numAleatorio.Next(1000, 2000);


                        if (n1 % 11 == 5)
                        {
                            Console.WriteLine("Número divisível por 11 resto 5: {0}", n1);
                        }
                    }
                    break;
                case ConsoleKey.F6:
                    /*Faça um programa que leia vários números inteiros positivos e mostre, no final, a soma dos números
pares e a soma dos números ímpares. O programa para quando entrar um número maior que 1000.*/

                    int number=0, par, impar, somapar=0, somaimpar=0;

                    while (number<=1000)
                    {
                        Console.WriteLine("Digite um número:");
                        number = Convert.ToInt32(Console.ReadLine());

                        if (number<=1000)
                        {
                            if (number % 2 == 0)
                            {
                                par = number;
                                somapar += par;
                            }
                            else
                            {
                                impar = number;
                                somaimpar += impar;
                            }
                        }
                        else
                        {
                            Console.WriteLine("A Soma dos números pares é igual a: {0}", somapar);
                            Console.WriteLine("A Soma dos números ímpares é igual a: {0}", somaimpar);
                        }
                        
                    }
                    break;
                case ConsoleKey.F7:
                    // Faça um programa que gere(aleatório) um número n e mostre na tela os n primeiros números
                    // primos.
                    Random numAletorio = new Random();

                    int numer = numAletorio.Next();
                    int divisivel=0;

                    Console.WriteLine(numer);

                    for (int i = numer; i > 0; i--)
                    {
                        if (i % 2 == 0) 
                        {
                            divisivel++;
                        }

                        if (divisivel == 2) 
                        {
                            
                        }
                    }
                    break;
                case ConsoleKey.F8:
                    break;
                case ConsoleKey.F9:
                    break;
                case ConsoleKey.F10:
                    break;


            }
            Console.ReadKey();

        }
    }
}