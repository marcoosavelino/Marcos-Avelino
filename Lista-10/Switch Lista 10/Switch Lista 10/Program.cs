﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Lista_10
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo lerTecla;

            Console.WriteLine("-------------------------");
            Console.WriteLine("|  Tecla  |   Exercício  ");
            Console.WriteLine("-------------------------");
            Console.WriteLine("|    F1   |  1º Exercício");
            Console.WriteLine("-------------------------");
            Console.WriteLine("|    F2   |  2º Exercício");
            Console.WriteLine("-------------------------");
            Console.WriteLine("|    F3   |  3º Exercício");
            Console.WriteLine("-------------------------");
            Console.WriteLine("|    F4   |  4º Exercício");
            Console.WriteLine("-------------------------");
            Console.WriteLine("|    F5   |  5º Exercício");
            Console.WriteLine("-------------------------");
            Console.WriteLine("|    F6   |  6º Exercício");
            Console.WriteLine("-------------------------");
            Console.WriteLine("|    F7   |  7º Exercício");
            Console.WriteLine("-------------------------");

            Console.Write("Informe o exercício desejado:");
            lerTecla = Console.ReadKey();


            switch (lerTecla.Key)
            {
               
                case ConsoleKey.F1:
                    /*Escreva um algoritmo em C# que gere 200 números inteiros aleatórios e imprima
quantos são pares e quantos são ímpares.*/
                    Random numAleatorio = new Random();
                    int par = 0, impar = 0;

                    for (int i = 1; i <= 200; i++)
                    {
                        int numeroAle = numAleatorio.Next();
                        Console.WriteLine("Contador {0} Número: {1}", i, numeroAle);

                        if (numeroAle % 2 == 0)
                        {
                            par++;
                        }
                        else
                        {
                            impar++;
                        }

                    }

                    Console.WriteLine("Quantos números são pares? {0}", par);
                    Console.WriteLine("Quantos números são ímpares? {0}", impar);

                    Console.ReadKey();
                    break;
                case ConsoleKey.F2:
                    /*Criar um algoritmo em C# que leia um número (NUM) e então imprima os múltiplos de 3
e 5, ao mesmo tempo, no intervalo fechado de 1 a NUM.*/
                    int num;

                    Console.WriteLine("Digite um número:");
                    num = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= num; i++)
                    {


                        if (i % 3 == 0)
                        {
                            Console.WriteLine("Este Número é Múltiplo de 3: {0}", i);
                        }

                        if (i % 5 == 0)
                        {
                            Console.WriteLine("Este Número é Múltiplo de 5: {0}", i);
                        }
                    }

                    Console.ReadKey();
                    break;
                case ConsoleKey.F3:
                    /*Escreva um algoritmo em C# que gere 20 números aleatórios (-10,11) e imprima a soma dos
positivos e o total de números negativos.*/
                    Random numDesconhecido = new Random();
                    int contP = 0, contN = 0;

                    for (int i = 0; i < 20; i++)
                    {
                        int numero = numDesconhecido.Next(-10, 11);
                        Console.WriteLine(numero);

                        if (numero >= 0)
                        {
                            contP++;
                        }
                        else
                        {
                            contN++;
                        }

                    }
                    Console.WriteLine("Total de números positivos: {0}", contP);
                    Console.WriteLine("Total de número negativos: {0}", contN);
                    Console.ReadKey();
                    break;
                case ConsoleKey.F4:
                    /*Escreva um algoritmo em C# para calcular o fatorial do número N, cujo valor é obtido
através do usuário pelo teclado.*/
                    int N, fat = 0;

                    Console.WriteLine("Informe um número:");
                    N = Convert.ToInt32(Console.ReadLine());

                    for (int i = N-1; i > 0; i--)
                    {
                        fat = N *= i;
                        
                        Console.WriteLine("Fatorial de N = {0} ", fat);
                        

                        Console.ReadKey();
                    }
                    break;
                case ConsoleKey.F5:
                    //Escreva um algoritmo em C# que determine todos os divisores de um dado número N.
                    int number,divisor=0;

                    Console.WriteLine("Informe um número:");
                    number = Convert.ToInt32(Console.ReadLine());

                    for (int i = number; i > 0; i--)
                    {
                        if (number%i == 0)
                        {
                            divisor++;
                        }
                    }
                    Console.WriteLine("Este número tem {0} divisores", divisor);
                    Console.ReadKey();
                    break;
                case ConsoleKey.F6:
                    /*Escreva um algoritmo em C# que determine se um dado número N (digitado pelo
usuário) é primo ou não.*/

                    int n1, div=0;

                    Console.WriteLine("DIGITE UM NÚMERO:");
                    n1 = Convert.ToInt32(Console.ReadLine());

                    for (int i = n1; i > 0; i--)
                    {
                        if (n1 % i == 0) 
                        {
                            div++;
                        }
                        
                    }
                    if (div == 2)
                    {
                        Console.WriteLine("O número {0} é primo!!", n1);
                    }
                    else
                    {
                        Console.WriteLine("O número {0} não é primo!!", n1);
                    }
                    Console.ReadKey();
                    break;
                case ConsoleKey.F7:
                    /*Calcule o imposto de renda de um grupo de 10 contribuintes, considerando que os dados
de cada contribuinte, número do CPF, número de dependentes e renda mensal são
valores fornecidos pelo usuário.Para cada contribuinte será feito um desconto de 5 % do
                        salário mínimo por dependente.*/
                    /*Observe que deve ser fornecido o valor atual do salário mínimo para que o algoritmo
calcule os valores corretamente.*/

                    string cpf;
                    double salarioMin=0, rendaM=0,quantSalario=0,numerodep=0;


                    for (int i = 1; i < 11; i++)
                    {

                        Console.WriteLine("Informe o VALOR ATUAL do Salário Mínimo:");
                        salarioMin = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o número do seu CPF:");
                        cpf = Console.ReadLine();
                        Console.WriteLine("Informe o número de dependentes:");
                        numerodep = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe a sua renda mensal: (será convertido em montantes de salários mínimos)");
                        rendaM = Convert.ToDouble(Console.ReadLine());

                        quantSalario = rendaM / salarioMin;
                        numerodep = ((salarioMin * 0.05) * numerodep);
                        if (quantSalario <= 2)
                        {
                            Console.WriteLine("INSENTO!!!");
                        }
                        else if ((quantSalario > 2) && (quantSalario <= 3))
                        {
                            Console.WriteLine("Valor da Alíquota: {0}", (rendaM * 0.05) - numerodep);
                        }
                        else if ((quantSalario > 3) && (quantSalario <= 5))
                        {
                            Console.WriteLine("Valor da Alíquota: {0}", (rendaM * 0.10) - numerodep);
                        }
                        else if ((quantSalario > 5 && quantSalario <= 7))
                        {
                            Console.WriteLine("Valor da Alíquota: {0}", (rendaM * 0.15) - numerodep);
                        }
                        else
                        {
                            Console.WriteLine("Valor da Alíquota : {0}", (rendaM * 0.20) - numerodep);
                        }
                        
                    }
                    
                    Console.ReadKey();
                    

                    break;
            }
        }
    }
}
