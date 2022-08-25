using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Lista_11
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo lerTecla;

            Console.WriteLine("------------------------------");
            Console.WriteLine("|   Tecla    |    Exercício   ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("|     F1     |       Nº1     |");
            Console.WriteLine("------------------------------");
            Console.WriteLine("|     F2     |       Nº2     |");
            Console.WriteLine("------------------------------");
            Console.WriteLine("|     F3     |       Nº3     |");
            Console.WriteLine("------------------------------");
            Console.WriteLine("|     F4     |       Nº4     |");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Informe o exercício desejado:");
            lerTecla = Console.ReadKey();

            switch (lerTecla.Key)
            {

                case ConsoleKey.F1:

                    Console.Clear();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("|     F1     |       Nº1     |");
                    Console.WriteLine("------------------------------");

                    double salario = 0, mediasalario = 0, maiorsalario = 0, soma = 0, percent = 0, percentual = 0, mediafilhos = 0;
                    double nfilhos, somafilhos = 0, cont = 0;

                    while (salario >= 0)
                    {
                        Console.WriteLine("Informe o seu salário:");
                        salario = Convert.ToDouble(Console.ReadLine());


                        if (salario > 0)
                        {
                            Console.WriteLine("Informe a quantidade de filhos que vc tem:");
                            nfilhos = Convert.ToInt32(Console.ReadLine());
                            cont++;
                            soma += salario;
                            somafilhos += nfilhos;

                            if (salario > maiorsalario)
                            {
                                maiorsalario = salario;
                            }
                            if (salario <= 1000)
                            {
                                percent++;
                            }

                        }

                    }
                    mediasalario = soma / cont;
                    mediafilhos = somafilhos / cont;
                    percentual = (percent / cont) * 100;
                    Console.WriteLine("A média de salário da população é = {0}", mediasalario);
                    Console.WriteLine("A média de filhos da população é = {0}", mediafilhos);
                    Console.WriteLine("O Maior salário é: {0}", maiorsalario);
                    Console.WriteLine("O percentual de pessoas com salário até 1.000,00 reais é de: {0} %", percentual);
                    break;
                case ConsoleKey.F2:

                    Console.Clear();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("|     F2     |       Nº2     |");
                    Console.WriteLine("------------------------------");

                    int voto = 0, voton = 0, votob = 0, voto1 = 0, voto2 = 0, voto3 = 0, voto4 = 0;
                    do
                    {
                        Console.WriteLine("Qual o seu voto? 1) Godinho  2) Fernandes  3) Franco  4) Gutierrez  5) VOTO NULO  6) VOTO EM BRANCO");
                        voto = Convert.ToInt32(Console.ReadLine());

                        if (voto == 1)
                        {
                            voto1++;
                        }
                        else if (voto == 2)
                        {
                            voto2++;
                        }
                        else if (voto == 3)
                        {
                            voto3++;
                        }
                        else if (voto == 4)
                        {
                            voto4++;
                        }
                        else if (voto == 5)
                        {
                            voton++;
                        }
                        else if (voto == 6)
                        {
                            votob++;
                        }
                        else
                        {
                            Console.WriteLine("ESTA TECLA NÃO CORRESPONDE À NENHUMA OPÇÃO");

                        }

                    } while (voto != 0);

                    Console.WriteLine("O Total de Votos para Godinho foi: {0} votos!", voto1);
                    Console.WriteLine("O Total de Votos para Fernandes foi: {0} votos!", voto2);
                    Console.WriteLine("O Total de Votos para Franco foi: {0} votos!", voto3);
                    Console.WriteLine("O Total de Votos para Gutierrez foi: {0} votos!", voto4);
                    Console.WriteLine("O Total de Votos Nulos foi : {0} votos!", voton);
                    Console.WriteLine("O Total de Votos Em Branco foi: {0} votos!", votob);

                    break;
                case ConsoleKey.F3:

                    Console.Clear();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("|     F3     |       Nº3     |");
                    Console.WriteLine("------------------------------");

                    double numero = 1, somanumero = 0, somapar = 0, numerop = 0, numeroi = 0, contador = 0, mediap = 0, mediag = 0;

                    while (numero != 0)
                    {
                        Console.WriteLine("Informe um número:");
                        numero = Convert.ToInt32(Console.ReadLine());

                        contador++;
                        if (numero % 2 == 0)
                        {
                            numerop++;
                            somapar += numero;
                        }
                        else
                        {
                            numeroi++;
                        }
                        somanumero += numero;
                        mediap = somapar / contador;
                        mediag = somanumero / contador;


                    }
                    Console.WriteLine("O Total de números pares é: {0}", numerop);
                    Console.WriteLine("O Total de números ímpares é: {0}", numeroi);
                    Console.WriteLine("A média de valores pares é: {0}", mediap);
                    Console.WriteLine("A média dos valores gerais é: {0}", mediag);


                    break;
                case ConsoleKey.F4:
                    /*Foi feita uma pesquisa entre os habitantes de uma região. Foram coletados os dados de
                      idade, sexo(M / F) e salário. Faça um algoritmo que informe:
                    a) a média de salário do grupo;
                    b) maior e menor idade do grupo;
                    c) quantidade de mulheres com salário até R$1000,00.*/

                    Console.Clear();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("|     F4     |       Nº4     |");
                    Console.WriteLine("------------------------------");

                    int maioridade = 0, menoridade = 200, quantm = 0;
                    int idade = 0, contad = 0;
                    double salary = 0, somasalary = 0, mediasalary = 0;
                    string sexo;



                    while (idade >= 0)
                    {
                        contad++;
                        Console.WriteLine("Informe a idade do habitante:");
                        idade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o sexo do habitante: M ou F");
                        sexo = Console.ReadLine();
                        Console.WriteLine("Informe o salário do habitante:");
                        salary = Convert.ToDouble(Console.ReadLine());

                        if (idade > maioridade)
                        {
                            maioridade = idade;
                        }
                        if (idade < menoridade)
                        {
                            menoridade = idade;
                        }

                        if (sexo == "F")
                        {
                            if (salary <= 1000)
                            {
                                quantm++;
                            }
                        }

                        somasalary += salary;
                        mediasalary = somasalary / contad;

                        Console.WriteLine("A média de salário do grupo é: {0}", mediasalary);
                        Console.WriteLine("A maior idade é: {0}", maioridade);
                        Console.WriteLine("A menor idade é: {0}", menoridade);
                        Console.WriteLine("A quantidade de mulheres com o salário até 1.000,00 reais é: {0} mulheres", quantm);
                    }




                    break;

            }
            Console.ReadKey();
        }
    }
}