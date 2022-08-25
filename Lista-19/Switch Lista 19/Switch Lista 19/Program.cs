using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Lista_19
{
    class Program
    {
        static Random NumeroRandom = new Random();
        static void SomaTriangularSuperior (int[,] Matriz10x10)
        {
            int valueSoma = 0;

            for (int linha = 0; linha < Matriz10x10.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < Matriz10x10.GetLength(1); coluna++)
                {
                    if (coluna>linha)
                    {
                        valueSoma += Matriz10x10[linha, coluna];
                    }
                }
            }
            Console.WriteLine("O valor da soma dos elementos acima da diagonal principal é: {0}",valueSoma);
        }
        static void SomaMatrizInteiros (int[,] MatrizA, int[,]MatrizB)
        {
            int[,] MatrizSoma = new int[4, 4];

            for (int i = 0; i < MatrizSoma.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizSoma.GetLength(1); j++)
                {
                    MatrizSoma[i, j] = MatrizA[i, j] + MatrizB[i, j];
                }
            }
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |  {3}  |", MatrizSoma[0, 0], MatrizSoma[0, 1], MatrizSoma[0, 2], MatrizSoma[0, 3]);
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |  {3}  |", MatrizSoma[1, 0], MatrizSoma[1, 1], MatrizSoma[1, 2], MatrizSoma[1, 3]);
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |  {3}  |", MatrizSoma[2, 0], MatrizSoma[2, 1], MatrizSoma[2, 2], MatrizSoma[2, 3]);
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |  {3}  |", MatrizSoma[3, 0], MatrizSoma[3, 1], MatrizSoma[3, 2], MatrizSoma[3, 3]);
        }
        static void VetorMenor (int[,] MatrizInteiros)
        {
            int menorvalor = MatrizInteiros[0, 0];

            for (int i = 0; i < MatrizInteiros.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizInteiros.GetLength(1); j++)
                {
                    if (MatrizInteiros[i,j] < menorvalor)
                    {
                        menorvalor = MatrizInteiros[i, j];
                    }
                }
                Console.WriteLine(menorvalor);
            }
        }
        static void VetorMaior(int[,] MatrizInteiros)
        {
            int maiorvalor = MatrizInteiros[0, 0];

            for (int i = 0; i < MatrizInteiros.GetLength(0); i++)
            {
                for (int j = 0; j < MatrizInteiros.GetLength(1); j++)
                {
                    if (MatrizInteiros[i, j] > maiorvalor)
                    {
                        maiorvalor = MatrizInteiros[i, j];
                    }
                }
                Console.WriteLine(maiorvalor);
            }
        }
        static void GiraMatriz90º (int[,] MatrizOriginal)
        {
            int[,] MatrizFinal = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    MatrizFinal[i, j] = MatrizOriginal[2 - j, i];
                }
            }
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", MatrizFinal[0, 0], MatrizFinal[0, 1], MatrizFinal[0, 2]);
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", MatrizFinal[1, 0], MatrizFinal[1, 1], MatrizFinal[1, 2]);
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", MatrizFinal[2, 0], MatrizFinal[2, 1], MatrizFinal[2, 2]);
        }
        static void GiraMatriz270º(int[,] MatrizOriginal)
        {
            int[,] MatrizFinal = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    MatrizFinal[i, j] = MatrizOriginal[j, 2 - i];
                }
            }
            Console.WriteLine("| {0}  |  {1}  |  {2}  |", MatrizFinal[0, 0], MatrizFinal[0, 1], MatrizFinal[0, 2]);
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", MatrizFinal[1, 0], MatrizFinal[1, 1], MatrizFinal[1, 2]);
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", MatrizFinal[2, 0], MatrizFinal[2, 1], MatrizFinal[2, 2]);
        }
        static void GiraMatriz180º(int[,] MatrizOriginal)
        {
            int[,] MatrizFinal = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    MatrizFinal[i, j] = MatrizOriginal[2 - i, 2 - j];
                }
            }
            Console.WriteLine("| {0}  |  {1}  |  {2}  |", MatrizFinal[0, 0], MatrizFinal[0, 1], MatrizFinal[0, 2]);
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", MatrizFinal[1, 0], MatrizFinal[1, 1], MatrizFinal[1, 2]);
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", MatrizFinal[2, 0], MatrizFinal[2, 1], MatrizFinal[2, 2]);
        }
        static void MenuPrincipal ()
        {
            ConsoleKeyInfo lerTecla;
            do
            {
                Console.WriteLine("===========================");
                Console.WriteLine("|   Tecla  |   Exercício  |");
                Console.WriteLine("===========================");
                Console.WriteLine("|    F1    |     EX 01    |");
                Console.WriteLine("---------------------------");
                Console.WriteLine("|    F2    |     EX 02    |");
                Console.WriteLine("---------------------------");
                Console.WriteLine("|    F3    |     EX 03    |");
                Console.WriteLine("---------------------------");
                Console.WriteLine("|    F4    |     EX 04    |");
                Console.WriteLine("---------------------------");
                Console.WriteLine("|    F5    |     EX 05    |");
                Console.WriteLine("---------------------------");
                Console.WriteLine("|    F6    |     EX 06    |");
                Console.WriteLine("---------------------------");
                Console.WriteLine("|    ESC   |      SAIR    |");
                Console.WriteLine("---------------------------");

                Console.WriteLine("Informe o exercício que deseja consultar:");
                lerTecla = Console.ReadKey();

            } while (lerTecla.Key != ConsoleKey.F1 && lerTecla.Key != ConsoleKey.F2 && lerTecla.Key != ConsoleKey.F3 && lerTecla.Key != ConsoleKey.F4 && lerTecla.Key != ConsoleKey.F5 && lerTecla.Key != ConsoleKey.F6 && lerTecla.Key != ConsoleKey.Escape);

            switch (lerTecla.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    Console.WriteLine("Exercício 01");

                    int[,] MatrizInteiros = new int[10, 10];
                    for (int linha = 0; linha < MatrizInteiros.GetLength(0); linha++)
                    {
                        for (int coluna = 0; coluna < MatrizInteiros.GetLength(1); coluna++)
                        {
                            MatrizInteiros[linha, coluna] = NumeroRandom.Next(0, 10);
                        }
                    }
                    SomaTriangularSuperior(MatrizInteiros);
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal();
                    break;
                case ConsoleKey.F2:
                    Console.Clear();
                    Console.WriteLine("Exercício 02");

                    int[,] MatrizInteirosA = new int[4, 4];

                    for (int i = 0; i < MatrizInteirosA.GetLength(0); i++)
                    {
                        for (int j = 0; j < MatrizInteirosA.GetLength(1); j++)
                        {
                            Console.WriteLine("Informe um valor para entrar na matriz:");
                            MatrizInteirosA[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    int[,] MatrizInteirosB = new int[4, 4];

                    for (int i = 0; i < MatrizInteirosB.GetLength(0); i++)
                    {
                        for (int j = 0; j < MatrizInteirosB.GetLength(1); j++)
                        {
                            Console.WriteLine("Informe um valor para entrar na matriz:");
                            MatrizInteirosB[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    SomaMatrizInteiros(MatrizInteirosA,MatrizInteirosB);
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal();
                    break;
                case ConsoleKey.F3:
                    int[,] MatrizRandom = new int[5, 5];
                    for (int i = 0; i < MatrizRandom.GetLength(0); i++)
                    {
                        for (int j = 0; j < MatrizRandom.GetLength(1); j++)
                        {
                            MatrizRandom[i, j] = NumeroRandom.Next(0, 10);
                        }
                    }
                    VetorMenor(MatrizRandom);
                    Console.WriteLine("------------");
                    VetorMaior(MatrizRandom);
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal();
                    break;
                case ConsoleKey.F4:
                    int[,] MatrizOriginal = new int[3, 3];
                    int cont = 1;
                    for (int i = 0; i < MatrizOriginal.GetLength(0); i++)
                    {
                        for (int j = 0; j < MatrizOriginal.GetLength(1); j++)
                        {
                            MatrizOriginal[i, j] = cont;
                            cont++;
                        }
                    }
                    GiraMatriz90º(MatrizOriginal);
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal();
                    break;
                case ConsoleKey.F5:
                    int[,] MatrizOrigem = new int[3, 3];
                    int contador = 1;
                    for (int i = 0; i < MatrizOrigem.GetLength(0); i++)
                    {
                        for (int j = 0; j < MatrizOrigem.GetLength(1); j++)
                        {
                            MatrizOrigem[i, j] = contador;
                            contador++;
                        }
                    }
                    GiraMatriz270º(MatrizOrigem);
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal();
                    break;
                case ConsoleKey.F6:
                    int[,] Matriz3x3 = new int[3, 3];
                    int contad = 1;
                    for (int i = 0; i < Matriz3x3.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matriz3x3.GetLength(1); j++)
                        {
                            Matriz3x3[i, j] = contad;
                            contad++;
                        }
                    }
                    GiraMatriz180º(Matriz3x3);
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Programa finalizado!");
                    break;
            }

        }
        static void Main(string[] args)
        {
            MenuPrincipal();

            Console.ReadKey();
        }
    }
}
