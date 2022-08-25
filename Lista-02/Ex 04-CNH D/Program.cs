using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04_Lista_02_CNH_D
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, TCB, TCC;
            string tipohab, nome;

            Console.WriteLine("Qual seu nome?");
            nome = (Console.ReadLine());
            Console.WriteLine("Qual sua idade? " + nome);
            idade = Convert.ToInt32(Console.ReadLine());
           
            if (idade >= 21)
            
                {
                Console.WriteLine("Qual habilitação você possui? B ou C?");
                tipohab = Console.ReadLine();

            }
            if (tipohab = B)
            {
                Console.WriteLine("Quanto tempo de carteira B você possui?");
                TCB = Convert.ToInt32(Console.ReadLine());
            }
            if (TCB >= 2)
            {
                Console.WriteLine(nome + "Você está APTO");
            }
            if (tipohab = C)
            {
                Console.WriteLine("Quanto tempo de carteira C você possui?");
                TCC = Convert.ToInt32(Console.ReadLine());
            }
            if (TCC >= 1)
            {
                Console.WriteLine(nome + "Você está APTO");
            }
            else
            {
                Console.WriteLine(nome + "Você está INAPTO");
            }
            

            Console.ReadKey();

        }
    }
}
