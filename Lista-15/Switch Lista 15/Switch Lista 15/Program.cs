using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Lista_15
{
    class Program
    {
        /*Escreva um trecho C# que leia 10 valores double do teclado e armazene-os num
array d.*/

            static double[] Lê10números (double[] pArrayD)
        {
            for (int i = 0; i < pArrayD.Length; i++)
            {
                Console.WriteLine("Informe o {0}º valor: ", i + 1);
                pArrayD[i] = Convert.ToDouble(Console.ReadLine());
            }
            
            return pArrayD;
        }
        /*Crie um método que recebe um array de inteiros e retorna a quantidade de
elementos do array que são números negativos.*/

            static int QuantNegativos (int[] pArrayInteiros)
        {
            int QtdNegativos = 0;

            for (int i = 0; i < pArrayInteiros.Length; i++)
            {
                Console.WriteLine("Informe o {0}º valor: ", i + 1);
                pArrayInteiros[i] = Convert.ToInt32(Console.ReadLine());

                if (pArrayInteiros[i] < 0) 
                {
                    QtdNegativos++;
                }
            }

            return QtdNegativos;
        }
        /*Crie um método que recebe um array de inteiros arrayA e um valor inteiro x e
retorna a quantidade de vezes que x aparece no array arrayA.*/

        static int QuantX(int[] pArrayA)
        {
            int valorx = 0;
            int QuantValorX = 0;

            Console.WriteLine("Informe um valor inteiro: ");
            valorx = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < pArrayA.Length; i++)
            {
                Console.WriteLine("Informe o {0}º valor do Array A: ");
                pArrayA[i] = Convert.ToInt32(Console.ReadLine());

                if (pArrayA[i] == valorx)
                {
                    QuantValorX++;
                }
                
            }

            return QuantValorX;
        }

        /*Escreva um método que recebe um array de inteiros arrayA e devolve um array de
boolean onde, cada posição indique true se o elemento da posição correspondente
de arrayA é positivo e false caso seja negativo.*/

            static bool[] BooleanPositivo (int[]pArrayA , bool[] pPositivoouNegativo)
        {
            for (int i = 0; i < pArrayA.Length; i++)
            {
                Console.WriteLine("Informe o {0}º valor: ");
                pArrayA[i] = Convert.ToInt32(Console.ReadLine());

                if (pArrayA[i] >= 0)
                {
                    pPositivoouNegativo[i] = true;
                }
                else
                {
                    pPositivoouNegativo[i] = false;
                }
            }

            return pPositivoouNegativo;
        }
        /*Escreva um método que recebe um array de números e devolve a posição onde se
encontra o maior valor do array.Se houver mais de um valor maior, devolver a
posição da primeira ocorrência.*/

            static int PosiçãoMaiorValor (double[] pArray)
        {
            double MaiorValor = 0;
            int PosiçãoMaiorValor = 0;

            for (int i = 0; i < pArray.Length; i++)
            {
                Console.WriteLine("Informe o {0}º valor: ", i + 1);
                pArray[i] = Convert.ToDouble(Console.ReadLine());

                if (pArray[i] > MaiorValor)
                {
                    MaiorValor = pArray[i];
                    PosiçãoMaiorValor = i;

                }
                
            }

            return PosiçãoMaiorValor;
        }
        /*Crie um método que recebe um array de inteiros positivos e substitui seus
elementos de valor ímpar por -1 e os pares por +1.*/

            static int[] ÍmparPar (int[] pArrayInteiros)
        {
            for (int i = 0; i < pArrayInteiros.Length; i++)
            {
                Console.WriteLine("Informe o {0}º valor: ");
                pArrayInteiros[i] = Convert.ToInt32(Console.ReadLine());

                if (pArrayInteiros[i] % 2 == 0)
                {
                    pArrayInteiros[i] = 1;
                }
                else
                {
                    pArrayInteiros[i] = -1;
                }
            }


            return pArrayInteiros;
        }


        static void MenuPrincipal()
        {
            ConsoleKeyInfo lerTecla;


            do
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("|     Tecla    |    Exercício    |");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("|      F1      |    Método 01    |");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("|      F2      |    Método 02    |");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("|      F3      |    Método 03    |");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("|      F4      |    Método 04    |");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("|      F5      |    Método 05    |");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("|      F6      |    Método 06    |");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("|      ESC     |      SAIR       |");
                Console.WriteLine("----------------------------------");

                Console.WriteLine("Informe o Método desejado: ");
                lerTecla = Console.ReadKey();

            } while (lerTecla.Key != ConsoleKey.F1 && lerTecla.Key != ConsoleKey.F2 && lerTecla.Key != ConsoleKey.F3 && lerTecla.Key != ConsoleKey.F4 && lerTecla.Key != ConsoleKey.F5 && lerTecla.Key!= ConsoleKey.F6 && lerTecla.Key != ConsoleKey.Escape);

            switch (lerTecla.Key)
            {
                case ConsoleKey.F1:
                    double[] Lê10 = new double[10];

                    Lê10números(Lê10);
                    
                    break;
                case ConsoleKey.F2:
                    int[] ArrayD = new int[5];
                    QuantNegativos(ArrayD);
                    break;
                case ConsoleKey.F3:
                    int[] ArrayA = new int[5];

                    QuantX(ArrayA);
                    break;
                case ConsoleKey.F4:
                    int[] ArrayC = new int[5];
                    bool[] PositivoOUNegativo = new bool[5];

                    BooleanPositivo(ArrayC, PositivoOUNegativo);
                    break;
                case ConsoleKey.F5:
                    double[] ArrayB = new double[5];
                    PosiçãoMaiorValor(ArrayB);
                    break;
                case ConsoleKey.F6:
                    int[] ArrayE = new int[5];
                    ÍmparPar(ArrayE);
                    break;
                default:
                    Console.WriteLine("FIM DA EXECUÇÃO DESTE PROGAMA!!");
                    break;
            }
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            MenuPrincipal();


            Console.ReadKey();
        }
    }
}
