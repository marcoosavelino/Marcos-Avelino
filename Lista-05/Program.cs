﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02_Lista_05_Dia_da_Semana
{
    class Program
    {
        static void Main(string[] args)
        {
            int mesat, placa;

            Console.WriteLine("Digite um número correspondente ao mês atual:");
            mesat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite os números da placa do seu veículo:");
            placa = Convert.ToInt32(Console.ReadLine());


            if (placa % 10 == 1)
            {
                Console.WriteLine("SEU IPVA VENCE NO MÊS DE JANEIRO!");
            }

            else if (placa % 10 == 2)
            {
                Console.WriteLine("SEU IPVA VENCE NO MÊS DE FEVEREIRO!");
            }

            else if (placa % 10 == 3)
            {
                Console.WriteLine("SEU IPVA VENCE NO MÊS DE MARÇO!");
            }
            else if (placa % 10 == 4)
            {
                Console.WriteLine("SEU IPVA VENCE NO MÊS DE ABRIL!");
            }

            else if (placa % 10 == 5)
            {
                Console.WriteLine("SEU IPVA VENCE NO MÊS DE MAIO!");
            }

            else if (placa % 10 == 6)
            {
                Console.WriteLine("SEU IPVA VENCE NO MÊS DE JUNHO!");
            }

            else if (placa % 10 == 7)
            {
                Console.WriteLine("SEU IPVA VENCE NO MÊS DE JULHO!");
            }

            else if (placa % 10 == 8)
            {
                Console.WriteLine("SEU IPVA VENCE NO MÊS DE AGOSTO!");
            }
            else if (placa % 10 == 9)
            {
                Console.WriteLine("SEU IPVA VENCE NO MÊS DE SETEMBRO!");
            }
            else if (placa % 10 == 10)
            {
                Console.WriteLine("SEU IPVA VENCE NO MÊS DE OUTUBRO!");
            }


            if (placa % 10 == mesat)
            {
                Console.WriteLine("VENCE NESSE MÊS!");
            }
            


            Console.ReadKey();
        }
    }
}
