﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace À_vista_ou_Parcelado_Ex_03_Lista_07
{
    class Program

      // Fazer um programa que leia o valor de uma compra e a opção de pagamento(V – para pagamento
     // à vista ou P – para pagamento parcelado). Caso o cliente pague à vista terá um desconto de 5%,
    // caso pague em 3 vezes terá um acréscimo de 8%. O programa deve mostrar o valor da compra e o
   //valor à vista ou valor a prazo(valor total e o valor de cada parcela)
    {
        static void Main(string[] args)
        {
            int opcaoP;
            double valordacompra;

            Console.WriteLine("Digite o valor da compra:");
            valordacompra = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a opção de pagamento: 1)À Vista ou 2)Parcelado");
            opcaoP = Convert.ToInt32(Console.ReadLine());


            if (opcaoP == 1) 
            {
                Console.WriteLine("O Valor Total é:{0}", valordacompra - (valordacompra * 0.05));
            }

            if (opcaoP == 2)
            {
                Console.WriteLine("O Valor Total é: " + (valordacompra + (valordacompra * 0.08) + "  e o valor da Parcela é: " + (valordacompra + (valordacompra * 0.08)) / 3));
            }
            

            Console.ReadKey();
        }
    }
}
