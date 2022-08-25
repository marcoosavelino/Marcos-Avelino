using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Array_Inteiros
{
    class Program
    {
        /*Inserir valores
         * Maior valor
         * Menor valor
         * Soma dos valores
         * Tamanho do array
         * Média
         * Primeiro e último valor
         * Busca e atribuição de valores(Get e Set)
         * Exibindo valores
         * Ordenação de valores
         */

            static void InserirValores (int[] pArrayInteiros)
        {
            int maiorValor = pArrayInteiros[0], menorValor = pArrayInteiros[0], somaValores = 0, cont = 0;

            for (int i = 0; i < pArrayInteiros.Length; i++)
            {
                cont++;
                Console.WriteLine("Insira o {0} valor do array:", i + 1);
                pArrayInteiros[i] = Convert.ToInt32(Console.ReadLine());

                if (pArrayInteiros[i] > maiorValor)
                {
                    maiorValor = pArrayInteiros[i];
                }
                if (pArrayInteiros[i]<menorValor)
                {
                    menorValor = pArrayInteiros[i];
                }
                somaValores += pArrayInteiros[i];
            }
            Console.WriteLine("O Maior valor é : {0}", maiorValor);
            Console.WriteLine("O Menor valor é : {0}", menorValor);
            Console.WriteLine("A Soma dos valores é: {0}", somaValores);
            Console.WriteLine("O Comprimento do Array é de {0} elementos", pArrayInteiros.Length);
            Console.WriteLine("A Média dos valores contidos no Array é : {0}", somaValores / cont);
            Console.WriteLine("O Primeiro Valor é: {0}", pArrayInteiros[0]);
            Console.WriteLine("O Último Valor é: {0}", pArrayInteiros[pArrayInteiros.Length-1]);
        }
        static void ExibirValores(int[] pArrayInteiros)
        {
            for (int i = 0; i < pArrayInteiros.Length; i++)
            {
                Console.WriteLine("Índice {0} = {1}", i, pArrayInteiros[i]);
            }
        }

        static void OrdenaValores (int[] pArrayInteiros)
        {
            int cont = 0;
            for (int i = 0; i < pArrayInteiros.Length; i++)
            {
                Console.WriteLine("Índice {0} = {1} ", i, pArrayInteiros[i]);
               
            }
            for (int i = 0; i < pArrayInteiros.Length; i++)
            {
                
                if (pArrayInteiros[cont]<pArrayInteiros[i+1])
                {

                }
                
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
