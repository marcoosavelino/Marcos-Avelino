using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Lista_18
{
    class Program
    {
        static int[,] matriz5x5 = new int[5, 5];
        static void MatrizOriginal()
        {
            Random numero = new Random();

            for (int i = 0; i < matriz5x5.GetLength(0); i++)
            {
                for (int j = 0; j < matriz5x5.GetLength(1); j++)
                {
                    int num = numero.Next(0, 20);
                    matriz5x5[i, j] = num;
                    
                }
            }
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |",matriz5x5[0,0], matriz5x5[0, 1], matriz5x5[0, 2], matriz5x5[0, 3], matriz5x5[0, 4]);
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |", matriz5x5[1, 0], matriz5x5[1, 1], matriz5x5[1, 2], matriz5x5[1, 3], matriz5x5[1, 4]);
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |", matriz5x5[2, 0], matriz5x5[2, 1], matriz5x5[2, 2], matriz5x5[2, 3], matriz5x5[2, 4]);
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |", matriz5x5[3, 0], matriz5x5[3, 1], matriz5x5[3, 2], matriz5x5[3, 3], matriz5x5[3, 4]);
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |", matriz5x5[4, 0], matriz5x5[4, 1], matriz5x5[4, 2], matriz5x5[4, 3], matriz5x5[4, 4]);
            
            

        }
       
        static void MenuPrincipal ()
        {
            ConsoleKeyInfo lerTecla;

            do
            {
                Console.WriteLine("===================================");
                Console.WriteLine("|    Tecla     |      Exercício   |");
                Console.WriteLine("===================================");
                Console.WriteLine("|     F1       |       EX 01      |");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("|     F2       |       EX 02      |");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("|     F3       |       EX 03      |");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("|     F4       |       EX 04      |");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("|     F5       |       EX 05      |");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("|     F6       |       EX 06      |");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("|     F7       |       EX 07      |");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("|     F8       |       EX 08      |");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("|     ESC      |       SAIR       |");
                Console.WriteLine("-----------------------------------");

                Console.WriteLine("Informe o exercício que você deseja executar: ");
                lerTecla = Console.ReadKey();

            } while (lerTecla.Key != ConsoleKey.F1 && lerTecla.Key != ConsoleKey.F2 && lerTecla.Key != ConsoleKey.F3 && lerTecla.Key != ConsoleKey.F4 && lerTecla.Key != ConsoleKey.F5 && lerTecla.Key != ConsoleKey.F6 && lerTecla.Key != ConsoleKey.F7 && lerTecla.Key != ConsoleKey.F8 && lerTecla.Key != ConsoleKey.Escape);

           
            switch (lerTecla.Key)
            { 
                case ConsoleKey.F1:
                    MatrizOriginal();
                    break;
                case ConsoleKey.F2:
                    break;
                case ConsoleKey.F3:
                    break;
                case ConsoleKey.F4:
                    break;
                case ConsoleKey.F5:
                    break;
                case ConsoleKey.F6:
                    break;
                case ConsoleKey.F7:
                    break;
                case ConsoleKey.F8:
                    break;
                default:
                    Console.WriteLine("Programa Finalizado! APERTE QUALQUER TECLA PARA FECHAR O PROGRAMA!");
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
