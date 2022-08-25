using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_Lista_03_Preço_com_Desconto
{
    class Program
    { //
        static void Main(string[] args)
        {

            //1)À vista em dinheiro ou cheque, recebe 10% de desconto
            //2)À vista no cartão de crédito, recebe 5% de desconto
            //3)Em duas vezes, preço normal de etiqueta sem juros
            //4)Em quatro vezes, preço normal de etiqueta mais juros de 10%


            double pe,pf;
            int cond;

            Console.WriteLine("Informe o Valor da Etiqueta:");
            pe = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a Condição de Pagamento: 1)À vista em Dinheiro ou Cheque 2)À vista no Cartão de Crédito 3)Parcelado em Duas Vezes 4)Parcelado em quatro vezes");
            cond = Convert.ToInt32(Console.ReadLine());

            if (cond == 1)
            {
                Console.WriteLine("O Valor Final é:{0}", (pe - (pe * 0.10)));
            }
            if (cond == 2)
            {
                Console.WriteLine("O Valor Final é:{0}", (pe - (pe * 0.05)));
            }
            if (cond == 3)
            {
                Console.WriteLine("O Valor Final é:{0}", (pe));
            }
            if (cond == 4)     
            {
                Console.WriteLine("O Valor Final é:{0}", (pe + (pe * 0.10)));
            }
            Console.ReadKey();
        } 
    }
}
