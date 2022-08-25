using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_Lista_11_TA_ERRADO
{
    class Program
    /* A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, coletando dados
        sobre o salário e número de filhos.A prefeitura deseja saber:
     a) média do salário da população;
     b) média do número de filhos;
     c) maior salário;
     d) percentual de pessoas com salário até R$1000,00.
   O final da leitura de dados se dará com a entrada de um salário negativo.*/
    {
        static void Main(string[] args)
        {
            double salario=1, maiorsalario = 0, mediasalario = 0, somasalario = 0, percent=0;
            int nfilhos, menosdemil=0,somafilhos = 0, mediafilhos = 0;

            for (int i = 1; salario >= 0; i++)
            {
                Console.WriteLine("Informe o seu salário:");
                salario = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe a quantidade de filhos que vc tem:");
                nfilhos = Convert.ToInt32(Console.ReadLine());

                    somasalario += salario;
                    mediasalario = somasalario / i;
                    somafilhos += nfilhos;
                    mediafilhos = somafilhos / i;
              
                if (salario<=1000)
                {
                    menosdemil++;
                }
                if (salario > maiorsalario)
                {
                    salario = maiorsalario;
                }

                percent = menosdemil / 100 * i;
            }
            
            Console.WriteLine("A média de salário da população é = {0}", mediasalario);
            Console.WriteLine("A média de filhos da população é = {0}", mediafilhos);
            Console.WriteLine("O Maior Salário é: {0}", maiorsalario);
            Console.WriteLine("O Percentual de pessoas que ganham até 1.000 reais é de: {0}%", percent);

            Console.ReadKey();
        }
    }
}