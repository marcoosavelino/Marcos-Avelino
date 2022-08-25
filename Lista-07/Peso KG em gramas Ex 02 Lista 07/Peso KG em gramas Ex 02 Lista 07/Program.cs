using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peso_KG_em_gramas_Ex_02_Lista_07
{
    class Program

       // Faça um programa que receba o peso de uma pessoa, um valor inteiro, calcule e imprima:
       // • o peso dessa pessoa em gramas;
       // • se essa pessoa engordar 5%, qual será seu novo peso em gramas.
    {
        static void Main(string[] args)
        {
            double pesokg;
            double pesoG;

            Console.WriteLine("Digite o seu peso em KG:");
            pesokg = Convert.ToDouble(Console.ReadLine());

            pesoG = (pesokg * 1000);

            Console.WriteLine("O seu peso em gramas é:{0}", pesoG);
            Console.WriteLine("Se você engordar 5%, seu novo peso será:{0}", (pesoG * 0.05)+pesoG);

            Console.ReadKey();

        }
    }
}
