using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reajuste_de_Salário_Ex_01_Lista_07
{
    class Program
    {
        //Faça um programa que receba o salário de um funcionário, calcule e imprima o novo salário
        //sabendo-se que este sofreu um aumento de 25%.
        static void Main(string[] args)
        {
            double salario, newsalary;

            Console.WriteLine("Digite o salário do funcionário:");
            salario = Convert.ToDouble(Console.ReadLine());

            newsalary = salario * 0.25;

            Console.WriteLine("O NOVO SALÁRIO DEPOIS DO REAJUSTE FOI PRA:{0}", newsalary+salario);

            Console.ReadKey();
        }
    }
}
