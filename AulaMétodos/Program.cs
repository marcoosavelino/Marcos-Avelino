using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Métodos
{
    class Program
    {
        static int SomaNumerosInteirosBasico(int pNumero1, int pNumero2, int pNumero3) // este é o primeiro passo, 
            //onde invocamos o método, e declaramos a lista de parâmetros
        {
            int somaNumeros = pNumero1 + pNumero2 + pNumero3; // declarar o que o método deve fazer, qual sua funcionalidade...
            return somaNumeros; // return , (o retorno)! REF: linha 11
        }
        static int SomaNumerosInteiros(int pQuantNumeros)
        {
            int numero, somaNumeros = 0;

            for (int i = 0; i < pQuantNumeros; i++)
            {
                Console.Write("Digite o {0}º numero: ", i + 1);
                numero = Convert.ToInt32(Console.ReadLine());
                somaNumeros += numero;
            }

            return somaNumeros;
        }
        static void Main(string[] args)
        {

            int numero = SomaNumerosInteirosBasico(3, 5, 10); // atribuição e declaração de variáveis
            Console.WriteLine(numero); // imprimir o resultado

            Console.WriteLine(SomaNumerosInteirosBasico(5, 5, 5)); // usar o método e sua funcionalidade para somar três números
            // OBS: O método só sabe somar três números
            Console.ReadKey(); // bloquear a tela, travá-la

            Console.WriteLine("Informe a quantidade de números para o somatório: ");
            pQuantNumeros =
            numero = SomaNumerosInteiros(pQuantNumeros);
            Console.WriteLine(numero)
                (SomaNumerosInteirosBasico(1, 1, 2));


        }
    }
}
