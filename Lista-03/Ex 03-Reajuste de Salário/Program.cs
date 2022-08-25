using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03_Lista_03_Reajuste_de_Salário
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;

            Console.WriteLine("Informe o salário do funcionário");
            salario = Convert.ToDouble(Console.ReadLine());


            if (salario < 500)
            {
                Console.WriteLine("Salário Reajustado:{0}", (salario + (salario*0.30)));
            }
            else
            {
                Console.WriteLine("Este funcionário não tem direito à um aumento");
            }
            Console.ReadKey();
        }
    }
}
