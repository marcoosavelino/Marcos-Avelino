﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_08_Lista_15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crie um programa em C# que leia um vetor de 10 alturas e elabore um algoritmo
que permita calcular:
            a) A média das alturas;
            b) O desvio padrão das alturas.Lembrando que desvio padrão é dado por
           (Somatório(Alturas2) / número de alturas) – Média2;
            c) A moda das alturas. Lembrando que moda é o valor que maior incidência de
            repetições;*/

            double[] Alturas = new double[10];

            for (int i = 0; i < Alturas.Length; i++)
            {
                Console.WriteLine("Informe a {0}ª altura: ", i + 1);
                Alturas[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("A Média das Alturas é : {0}", Alturas.Average());
        }
    }
}
