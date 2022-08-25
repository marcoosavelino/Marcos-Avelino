﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{







    class Program
    {
        static ConsoleKeyInfo lerTecla;
        static char confirmacao;

        static void MenuUsuario()
        {




            do
            {

                Console.Title = "MENU USUÁRIOS";
                Console.Clear();
                Console.WriteLine("|---------------------------------|");
                Console.WriteLine("|         MENU USUÁRIOS!          |");
                Console.WriteLine("|  F2  - Cadastro de Usuários     |");
                Console.WriteLine("|  F3  - Editar Usuários          |");
                Console.WriteLine("|  F4  - Excluir Usuários         |");
                Console.WriteLine("|  F5  - Consultar Usuários       |");
                Console.WriteLine("|---------------------------------|");
                Console.WriteLine("|  F1  - Ajuda                    |");
                Console.WriteLine("|  Esc  - Voltar Menu Principal   |");
                Console.WriteLine("|---------------------------------|");
                Console.Write("Escolha a opção que você deseja: ");

                lerTecla = Console.ReadKey();

                switch (lerTecla.Key)
                {
                    case ConsoleKey.Escape:
                        Console.Write("\nDeseja voltar ao menu principal? (S/N) : ");
                        confirmacao = Convert.ToChar(Console.ReadLine().ToUpper());

                        if (confirmacao == 'S')
                        {
                            MenuPrincipal();
                        }
                        else
                        {
                            MenuUsuario();
                        }



                        break;
                    case ConsoleKey.F1:
                        break;
                    case ConsoleKey.F2:

                        break;
                    case ConsoleKey.F3:
                       

                        
                        break;
                    case ConsoleKey.F4:
                        break;
                    case ConsoleKey.F5:
                        break;

                }

            } while (lerTecla.Key != ConsoleKey.F2 && lerTecla.Key != ConsoleKey.F3 && lerTecla.Key != ConsoleKey.F4 && lerTecla.Key != ConsoleKey.F5 && lerTecla.Key != ConsoleKey.Escape);


        }
        static void MenuPrincipal()
        {


            do
            {
                Console.Title = "MENU PRINCIPAL";
                Console.Clear();
                Console.WriteLine("|---------------------------------|");
                Console.WriteLine("|        ACESSO LIBERADO!         |");
                Console.WriteLine("|  F2  - Gestão de Funcionários   |");
                Console.WriteLine("|  F3  - Gestão de Clientes       |");
                Console.WriteLine("|  F4  - Gestão Financeira        |");
                Console.WriteLine("|  F5  - Gestão de Produtos       |");
                Console.WriteLine("|---------------------------------|");
                Console.WriteLine("|  F1  - Ajuda                    |");
                Console.WriteLine("|  Esc  - Sair                    |");
                Console.WriteLine("|---------------------------------|");
                Console.Write("Escolha a opção que você deseja: ");

                lerTecla = Console.ReadKey();




                switch (lerTecla.Key)
                {

                    case ConsoleKey.Escape:
                        Console.Write("\nDeseja finalizar o programa? (S/N) : ");
                        confirmacao = Convert.ToChar(Console.ReadLine().ToUpper());

                        if (confirmacao == 'S')
                        {
                            Console.WriteLine("Programa Finalizado!");
                        }
                        else
                        {
                            MenuPrincipal();
                        }



                        break;
                    case ConsoleKey.F1:
                        break;
                    case ConsoleKey.F2:
                        MenuUsuario();
                        break;
                    case ConsoleKey.F3:
                        MenuClientes();
                        break;
                    case ConsoleKey.F4:
                        break;
                    case ConsoleKey.F5:
                        break;
                    case ConsoleKey.F6:
                        break;

                }



            } while (lerTecla.Key != ConsoleKey.F2 && lerTecla.Key != ConsoleKey.F3 && lerTecla.Key != ConsoleKey.F4 && lerTecla.Key != ConsoleKey.F5 && lerTecla.Key != ConsoleKey.Escape);

        }

        static void MenuClientes()
        {
            do
            {

                Console.Title = "MENU CLIENTES";
                Console.Clear();
                Console.WriteLine("|---------------------------------|");
                Console.WriteLine("|         MENU CLIENTES!          |");
                Console.WriteLine("|  F2  - Cadastro de Clientes     |");
                Console.WriteLine("|  F3  - Editar Clientes          |");
                Console.WriteLine("|  F4  - Excluir Clientes         |");
                Console.WriteLine("|  F5  - Consultar Clientes       |");
                Console.WriteLine("|---------------------------------|");
                Console.WriteLine("|  F1  - Ajuda                    |");
                Console.WriteLine("|  Esc  - Voltar Menu Principal   |");
                Console.WriteLine("|---------------------------------|");
                Console.Write("Escolha a opção que você deseja: ");

                lerTecla = Console.ReadKey();

                switch (lerTecla.Key)
                {
                    case ConsoleKey.Escape:
                        Console.Write("\nDeseja voltar ao menu principal? (S/N) : ");
                        confirmacao = Convert.ToChar(Console.ReadLine().ToUpper());

                        if (confirmacao == 'S')
                        {
                            MenuPrincipal();
                        }
                        else
                        {
                            MenuClientes();
                        }



                        break;
                    case ConsoleKey.F1:
                        break;
                    case ConsoleKey.F2:
                        string[,] MatrizAlfa = new string[1000, 5];

                        int cont = 1;

                        for (int i = 0; i < MatrizAlfa.GetLength(0); i++)
                        {
                            for (int j = 0; j < MatrizAlfa.GetLength(1); j++)
                            {

                                Console.WriteLine("Código do Cliente: {0}", cont++);

                                Console.WriteLine("Nome:");
                                MatrizAlfa[i, j] = Console.ReadLine();
                                Console.WriteLine("Telefone:");
                                MatrizAlfa[i, j] = Console.ReadLine();
                                Console.WriteLine("CPF:");
                                MatrizAlfa[i, j] = Console.ReadLine();
                                Console.WriteLine("Cidade:");
                                MatrizAlfa[i, j] = Console.ReadLine();
                                Console.WriteLine("E-mail:");
                                MatrizAlfa[i, j] = Console.ReadLine();


                            }
                        }
                        break;
                    case ConsoleKey.F3:
                        string usuario;

                        Console.WriteLine("Informe o usuário que deseja editar:");
                        usuario = Console.ReadLine();

                        int id;
                    for (int i = 0; i < MatrizAlfa.GetLength(0); i++)
                    {
                        
                            if (MatrizAlfa[i,1] == usuario)
                            {
                                id = i;
                            }
                            else
                            {
                                Console.WriteLine("Cliente não encontrado!!");
                            }
                         
                    }
                        if (id != null)
                        {
                            Console.WriteLine("Informe o Nome do cliente:");
                            MatrizAlfa[id, 1] = Console.ReadLine();
                            Console.WriteLine("Informe o Telefone do cliente:");
                            MatrizAlfa[id, 2] = Console.ReadLine();
                            Console.WriteLine("Informe o CPF do cliente:");
                            MatrizAlfa[id, 3] = Console.ReadLine();
                            Console.WriteLine("Informe a Cidade do cliente:");
                            MatrizAlfa[id, 4] = Console.ReadLine();
                            Console.WriteLine("Informe o E-mail do cliente:");
                            MatrizAlfa[id, 5] = Console.ReadLine();

                        }
                        MenuClientes();
                        break;
                    case ConsoleKey.F4:
                        break;
                    case ConsoleKey.F5:

                        
                        {
                            int consulta;
                            do
                            {
                                Console.WriteLine("Deseja consultar por: 1) Nome 2) CPF 3) Listar todos os clientes 4) Voltar ao Menu Cliente  ?");
                                consulta = Convert.ToInt32(Console.ReadLine());

                            } while (consulta != 1 && consulta != 2 && consulta != 3 && consulta != 4);

                            if (consulta == 1)
                            {
                                Console.WriteLine("Consulte um nome:");
                                pNome = Console.ReadLine();

                                for (int i = 0; i < MatrizAlfa.GetLength(0); i++)
                                {
                                    for (int j = 0; j < MatrizAlfa.GetLength(1); j++)
                                    {
                                        if (MatrizAlfa[i, j] == pNome)
                                        {
                                            Console.WriteLine(MatrizAlfa[i, 0], MatrizAlfa[i, 1], MatrizAlfa[i, 2], MatrizAlfa[i, 3], MatrizAlfa[i, 4], MatrizAlfa[i, 5]);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Cliente não encontrado!!");
                                        }
                                    }
                                }


                            }
                            else if (consulta == 2)
                            {
                                string CPF;

                                Console.WriteLine("Informe o CPF para Consulta:");
                                CPF = Console.ReadLine();

                                for (int i = 0; i < MatrizAlfa.GetLength(0); i++)
                                {
                                    for (int j = 0; j < MatrizAlfa.GetLength(1); j++)
                                    {
                                        if (MatrizAlfa[i, j] == CPF)
                                        {
                                            Console.WriteLine(MatrizAlfa[i, 0], MatrizAlfa[i, 1], MatrizAlfa[i, 2], MatrizAlfa[i, 3], MatrizAlfa[i, 4], MatrizAlfa[i, 5]);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Cliente não encontrado!!");
                                        }
                                    }
                                }
                                

                            }
                            else if (consulta == 3)
                            {

                            }
                        }
                        break;

                }

            } while (lerTecla.Key != ConsoleKey.F2 && lerTecla.Key != ConsoleKey.F3 && lerTecla.Key != ConsoleKey.F4 && lerTecla.Key != ConsoleKey.F5 && lerTecla.Key != ConsoleKey.Escape);
        }




        static void Main(string[] args)
        {
            int senha, cont = 0;
            string login;




            do
            {

                Console.Write("Informe seu login: ");
                login = Console.ReadLine().ToLower();
                Console.Write("Informe sua senha: ");
                senha = Convert.ToInt32(Console.ReadLine());

                cont++;

                if (senha != 123)
                {
                    Console.WriteLine("Senha errada! tente novamente. Você possui mais {0} tentativas", 3 - cont);
                }

                if (login == "admin" && senha == 123)
                {
                    Console.WriteLine("Sua senha está certa! Acesso liberado.");
                }
                else if (cont == 3)
                {
                    Console.WriteLine("Acesso bloqueado");
                }


            } while (senha != 123 && cont < 3);




            MenuPrincipal();



            Console.ReadKey();
        }
    }
}
