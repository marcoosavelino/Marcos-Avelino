using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_Lista_02_Maior_Número
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

            if ((n1 > n2) && (n1> n3))
            {
                Console.WriteLine("Resposta: " + n1);

            }
            else if ((n2 > n1) && (n2 > n3))
           
            {
                Console.WriteLine("Resposta: " + n2);
            }
            else

            {
                Console.WriteLine("Resposta: " + n3);
            }

            Console.ReadKey();
        }
    }
}
