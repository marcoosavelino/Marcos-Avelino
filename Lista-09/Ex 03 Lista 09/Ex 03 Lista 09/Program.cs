using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03_Lista_09
{
    class Program
        // Crie um programa que leia informações sobre um grupo de 5 pessoas e calcule alguns
        // dados estatísticos.Para cada pessoa do grupo, o programa deve ler o nome da pessoa, a
        // altura, o peso e o sexo (“F” para feminino e “M” para o masculino). Calcule e escreva:
         
        // • A quantidade total de homens e mulheres e o percentual de cada;
        // • A média de peso das pessoas(somatório dos pesos de todas as pessoas pela quantidade de pessoas);
        // • O nome da pessoa mais alta
    {
        static void Main(string[] args)
        {
            int pessoa=0;
            string nome, sexo;
            double altura, peso=0,somapeso=0,contm=0,contf=0;

            for (int i = pessoa; i <5; i++)    
            {
                Console.WriteLine("DIGITE O NOME:");
                nome = Console.ReadLine();
                Console.WriteLine("INFORME O SEXO: M OU F");
                sexo = Console.ReadLine();
                Console.WriteLine("DIGITE A ALTURA :");
                altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("DIGITE O PESO:");
                peso = Convert.ToDouble(Console.ReadLine());

                somapeso = somapeso += peso;

                if (sexo == "F")
                {
                    contf++;
                }
                if (sexo == "M")
                {
                    contm++;
                }



            }
            Console.WriteLine("O número de mulheres é: {0} {1}%", contf, (contf / 5) * 100);
            Console.WriteLine("O número de homens é: {0} {1}%", contm, (contm / 5) * 100);
            Console.WriteLine("A média de peso do grupo é: {0}", somapeso / 5);

            Console.ReadKey();
            
        }
    }
}
