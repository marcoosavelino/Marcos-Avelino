using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternário_Ex_02_Lista_08
{
    class Program
        // Faça um algoritmo que leia o nome, o sexo e o estado civil de uma pessoa.Caso sexo seja “F”
        // e estado civil seja “CASADA”, solicitar o tempo de casada(anos).
    {
        static void Main(string[] args)
        {
            string nome, sexo, estcivil;
            double tempodec;

            Console.WriteLine("Digite o nome de uma pessoa:");
            nome = Console.ReadLine();
            Console.WriteLine("Qual o sexo desta pessoa?");
            sexo = Console.ReadLine();
            Console.WriteLine("Qual o estado civil desta pessoa?");
            estcivil = Console.ReadLine();


            if ((sexo == "F") && (estcivil == "CASADA"))
            {
                Console.WriteLine("Quanto tempo de Casada ela tem?");
                tempodec = Convert.ToDouble(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
