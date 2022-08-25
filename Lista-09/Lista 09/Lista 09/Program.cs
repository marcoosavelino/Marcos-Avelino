using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_09
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

            Console.Write("Informe a questão Desejada:"); 
            lerTecla = Console.ReadKey(); 

            switch (lerTecla.Key)
            {
                case ConsoleKey.F2: 
                    {
                        Console.Title = "Conjuntos de valores";
                        bool continua = false; // continua é uma condição boleana
                        double valor1, valor2, valor3, soma, media, produto; 

                        Console.Clear(); // este comando é utilizado para limpar a tela
                        Console.WriteLine(" ----------------------------------");
                        Console.WriteLine("|    F2    | Conjuntos de valores  |");
                        Console.WriteLine(" ----------------------------------");

                        Console.WriteLine(" ----------------------------------");
                        Console.WriteLine("| 1º Conjunto a ser lido           |"); // nesse caso o primeiro conjunto à ser lido está fora do (for)
                        Console.WriteLine(" ----------------------------------");

                        Console.Write("Digite o primeiro valor: "); 
                        valor1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o segundo valor: ");
                        valor2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o terceiro valor: ");
                        valor3 = Convert.ToDouble(Console.ReadLine());

                        if (valor1 < valor2 && valor2 < valor3) // se esta condição for atendida a variável continua do tipo bool será true
                        {
                            continua = true;
                            for (int i = 2; continua; i++) // i começa com o valor 2 pois já foi lido o primeiro conjunto, continua é a condição para o código ser executado
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
                default:
                    {

                    }
                    break;
            }

            Console.ReadKey(); // congela a tela

        }
    }
}
