using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03_Lista_02_Diferença_entre_maior_e_menor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine("DIGITE O PRIMEIRO NÚMERO: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("DIGITE O SEGUNDO NÚMERO: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("DIGITE O TERCEIRO NÚMERO: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            if ((n1 > n2) && (n1 > n3))
            {
                
                if (n2 > n3) 
                {
                    Console.WriteLine("Resposta: {0} {1} {2}" , n3, n2, n1);
                }
                else
                {
                    Console.WriteLine("Resposta: {0} {1} {2}" , n2, n3, n1);
                }

            }
            else if ((n2 > n3) && (n2 > n1))
                if (n1 > n3)
                {
                    Console.WriteLine("Resposta: {0} {1} {2} " , n3, n1, n2);


                }
                else
                {
                    Console.WriteLine("Resposta: {0} {1} {2}" , n1, n3, n2);
                }
            else if ((n3 > n1) && (n3 > n2))
                if (n1 > n2)
            {
                    Console.WriteLine("Resposta: {0} {1} {2} " , n2, n1, n3);
                }
                else
                {
                    Console.WriteLine("Resposta: {0} {1} {2} " , n1 ,n2 , n3);
                  }

            Console.ReadKey();
        }
    }
}
