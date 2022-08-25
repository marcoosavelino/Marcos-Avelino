using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_Lista_09
{
    class Program
   
    {
        static void Main(string[] args)
        {

            Console.Title = "Lista 09 – Estrutura condicional e Repetição";

            ConsoleKeyInfo lerTecla; 

            Console.WriteLine(" ----------------------------------");
            Console.WriteLine("|    Nº    | Exercício             |");
            Console.WriteLine(" ----------------------------------");
            Console.WriteLine("|    F2    | Conjuntos de valores  |"); 
            Console.WriteLine(" ----------------------------------");
            Console.WriteLine("|    F3    | Números desconhecido  |");
            Console.WriteLine(" ----------------------------------");
            Console.WriteLine("|    F4    | Grupo de Pessoas      |");
            Console.WriteLine(" ----------------------------------");

            Console.Write("Informe a questão Desejada:");
            lerTecla = Console.ReadKey(); 

            switch (lerTecla.Key)
            {
                case ConsoleKey.F2: 
                    {
                        Console.Title = "Conjuntos de valores";
                        bool continua = false; 
                        double valor1, valor2, valor3, soma, media, produto;

                        Console.Clear(); 
                        Console.WriteLine(" ----------------------------------");
                        Console.WriteLine("|    F2    | Conjuntos de valores  |");
                        Console.WriteLine(" ----------------------------------");

                        Console.WriteLine(" ----------------------------------");
                        Console.WriteLine("| 1º Conjunto a ser lido           |"); 
                        Console.WriteLine(" ----------------------------------");

                        Console.Write("Digite o primeiro valor: ");
                        valor1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o segundo valor: ");
                        valor2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o terceiro valor: ");
                        valor3 = Convert.ToDouble(Console.ReadLine());

                        if (valor1 < valor2 && valor2 < valor3) 
                        {
                            continua = true;
                            for (int i = 2; continua; i++) 
                            {
                                soma = valor1 + valor2 + valor3;
                                produto = valor1 * valor2 * valor3;
                                media = soma / 3;
                                Console.WriteLine(" ----------------------------------");
                                Console.WriteLine("A soma dos valores: {0}", soma);
                                Console.WriteLine("O produto dos valores: {0}", produto);
                                Console.WriteLine("A média dos valores: {0}", Math.Round(media, 2));
                                Console.WriteLine(" ----------------------------------");
                                Console.ReadKey();

                                Console.Clear();
                                Console.WriteLine(" ----------------------------------");
                                Console.WriteLine("|    F2    | Conjuntos de valores  |");
                                Console.WriteLine(" ----------------------------------");
                                Console.WriteLine(" ----------------------------------");
                                Console.WriteLine("|{0}º Conjunto a ser lido           |", i);
                                Console.WriteLine(" ----------------------------------");

                                Console.Write("Digite o primeiro valor: ");
                                valor1 = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Digite o segundo valor: ");
                                valor2 = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Digite o terceiro valor: ");
                                valor3 = Convert.ToDouble(Console.ReadLine());

                                if (valor1 < valor2 && valor2 < valor3)
                                {
                                    continua = true;
                                }
                                else
                                {
                                    Console.WriteLine("\nValores não estão na ordem crescente obrigatório!");
                                    Console.WriteLine("Forão lidos {0} conjutos!", --i);
                                    continua = false;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nValores não estão na ordem crescente obrigatório!");
                            Console.WriteLine("Forão lidos 0 conjutos!");
                        }

                    }
                    break;
                case ConsoleKey.F3:
                    {
                        int intervalo1 = 0, intervalo2 = 0, intervalo3 = 0, intervalo4 = 0;
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
                        Console.WriteLine("Números entre [0,25]:{0}",intervalo1);
                        Console.WriteLine("Números entre [25,50]:{0}",intervalo2);
                        Console.WriteLine("Números entre [50,75]:{0}",intervalo3);
                        Console.WriteLine("Números entre [75,100]:{0}",intervalo4);
                        Console.ReadKey();
                    }

                    break;
                case ConsoleKey.F4:
                    int pessoa = 0;
                    string nome, sexo, nomemaisalto = "";
                    double altura, peso = 0, somapeso = 0, maioraltura=0 ,contm = 0, contf = 0;

                    for (int i = pessoa; i < 5; i++)
                    {
                        Console.WriteLine("DIGITE O NOME:");
                        nome = Console.ReadLine();
                        Console.WriteLine("INFORME O SEXO: M OU F");
                        sexo = Console.ReadLine();
                        Console.WriteLine("DIGITE A ALTURA :");
                        altura = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("DIGITE O PESO:");
                        peso = Convert.ToDouble(Console.ReadLine());

                        somapeso = somapeso += peso;

                        if (altura>maioraltura)
                        {
                            maioraltura = altura;
                            nomemaisalto = nome;
                        }

                        if (sexo == "F")
                        {
                            contf++;
                        }
                        if (sexo == "M")
                        {
                            contm++;
                        }



                    }
                    Console.WriteLine("O número de mulheres é: {0} {1}%", contf, (contf / 5) * 100);
                    Console.WriteLine("O número de homens é: {0} {1}%", contm, (contm / 5) * 100);
                    Console.WriteLine("A média de peso do grupo é: {0}", somapeso / 5);
                    Console.WriteLine("A maior a altura é: {0} e o nome da pessoa mais alta é:{1}", maioraltura, nomemaisalto);

                    Console.ReadKey();
                    break;
            }

        }



    }
    }




