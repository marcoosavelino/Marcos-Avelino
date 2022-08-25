using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceito_do_Aluno_Ex_04_Lista_07
{
    class Program
    {
       // Fazer um programa que leia o nome do aluno, a média final e o valor normal da mensalidade.O
        // programa deve calcular e imprimir o novo valor da mensalidade, o nome do aluno e o conceito
         // no qual ele foi classificado.
        static void Main(string[] args)
        {
            string nome;
            double media;
            double valorm;

            Console.WriteLine("Qual o nome do aluno?");
            nome = Console.ReadLine();
            Console.WriteLine("Qual foi a Média Final do aluno??");
            media = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual o valor da mensalidade?");
            valorm = Convert.ToDouble(Console.ReadLine());


            if (media > 9 && media <= 10)
            {
                Console.WriteLine("Nome: " + nome + " Conceito: (A) " + " Novo Valor da Mensalidade: {0} ", (valorm - (valorm * 0.15)));
            }

            else if (media > 7.5 && media <= 9)
            {
                Console.WriteLine("Nome: " + nome + " Conceito: (B) " + " Novo Valor da Mensalidade: {0} ", (valorm - (valorm * 0.10)));
            }

            else if (media > 6 && media <= 7.5)
            {
                Console.WriteLine("Nome: " + nome + " Conceito: (C) " + " Novo Valor da Mensalidade: {0} ", (valorm - (valorm * 0.05)));
            }
            else if (media > 4 && media <= 6)
            {
                Console.WriteLine("Nome: " + nome + " Conceito: (D) " + " Novo Valor da Mensalidade: {0} ", (valorm));
            }
            else if (media <= 4) 
            {
                Console.WriteLine("Nome: " + nome + " Conceito: (E) " + " Novo Valor da Mensalidade: {0} ", (valorm));
            }


            Console.ReadKey();

        }
    }
}
