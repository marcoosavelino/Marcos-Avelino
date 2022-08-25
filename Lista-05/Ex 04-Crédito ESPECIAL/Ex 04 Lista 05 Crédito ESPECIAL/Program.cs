using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04_Lista_05_Crédito_ESPECIAL
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldom;

            Console.WriteLine("Digite o valor do Saldo Médio:");
            saldom = Convert.ToDouble(Console.ReadLine());
            


            if (saldom < 501)
                 
            {
                Console.WriteLine("Seu Saldo Médio é: {0} e o valor do seu crédito é:{1}", saldom, saldom - saldom);
            }

            if ((saldom > 500) && (saldom <= 1000))
                
            {
                Console.WriteLine("Seu Saldo Médio é: {0} e o valor do seu crédito é: {1}", saldom, saldom * 0.30);
            }

            if ((saldom > 1000) && (saldom <= 3000))
               
            {
                Console.WriteLine("Seu Saldo Médio é: {0} e o valor do seu crédito é:{1}", saldom, saldom* 0.40);
            }

            if (saldom > 3000)
                
            {
                Console.WriteLine("Seu Saldo Médio é:{0} e o valor do seu crédito é:{1}", saldom, saldom * 0.50);
            }

            Console.ReadKey();


        }
    }
}
