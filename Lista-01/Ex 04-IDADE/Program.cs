using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04_Lista_01_IDADE
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, anonasc, anoat;
            Console.WriteLine("Informe o Ano de Nascimento: ");
            anonasc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o Ano Atual: ");
            anoat = Convert.ToInt32(Console.ReadLine());

            idade = anoat - anonasc;

            Console.WriteLine("A Idade do usuário é: " + idade);

            Console.ReadKey();
        }
    }
}
