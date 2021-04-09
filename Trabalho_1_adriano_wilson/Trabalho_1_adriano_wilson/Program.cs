using System;
using System.Collections.Generic;

namespace Trabalho_1_adriano_wilson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
           
            bool repetir = true;
            while (repetir == true)
            {
                
                Console.WriteLine("\nBem vindo a clinica veterinaria");
                Console.WriteLine("1- Registe um animal");
                Console.WriteLine("2- Registe um cliente");
                Console.WriteLine("3- Serviço check-up");
                Console.WriteLine("4- Serviço exame de sangue");
                Console.WriteLine("5- Mostrar empregados");
                Console.WriteLine("6- Mostrar clientes");
                Console.WriteLine("7- Fazer o relatório");
                Console.WriteLine("8- Sair");
                Console.Write("=>");

                int opcao = Convert.ToInt32(Console.ReadLine());
           
                switch (opcao)
                {
                    case 1:
                        if (clientes.Count == 0)
                        {
                            Console.WriteLine("\nPrecisa de adicionar um cliente primeiro");
                        }
                        else
                        {
                            Console.WriteLine("\nEscolha um cliente para associar o animal:");
                            int i = 1;
                            foreach(Cliente cliente in clientes)
                            {
                                Console.WriteLine(i+ " " + cliente.nome);
                                i++;
                            }
                            int idCliente = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nIntruduza o nome do animal de estimação:");
                            string nomeAnimal = Console.ReadLine();

                            Console.WriteLine("\nIntruduza a idade do animal de estimação:");
                            int idadeAnimal = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nIntruduza o genero do animal de estimação:");
                            string generoAnimal = Console.ReadLine();

                            Console.WriteLine("\nIntruduza o especi do animal de estimação:");
                            string especiAnimal = Console.ReadLine();

                            Console.WriteLine("\nIntruduza o numero de identificação do animal de estimação:");
                            int numeroIdentificacaoAnimal = Convert.ToInt32(Console.ReadLine());

                            clientes[idCliente - 1].adicionaAnimalAoCliente(nomeAnimal, idadeAnimal, generoAnimal, especiAnimal, numeroIdentificacaoAnimal);
                            Console.WriteLine("\nRegistou um animal");
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nIntruduza o nome:");
                        string nomeCliente = Console.ReadLine();

                        Console.WriteLine("\nIntruduza o contacto:");
                        int contactoCliente = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nIntruduza o endereço:");
                        string enderecoCliente = Console.ReadLine();

                        clientes.Add(new Cliente(nomeCliente, contactoCliente, enderecoCliente));
                        Console.WriteLine("\nRegistou um cliente");
                        break;
                    case 3:
                        Servicos checkUp = new Servicos(5, 15, "Nao é preciso nenhum");
                        checkUp.printServico();
                        break;
                    case 4:
                        Servicos exameDeSangue = new Servicos(30, 60, "Analgesicos");
                        exameDeSangue.printServico();
                        break;
                    case 5:
                        Console.WriteLine("Lista de empregados");
                        break;
                    case 6:
                        foreach (var cliente in clientes)
                        {
                            cliente.printClientes();
                        }
                        break;
                    case 7:
                        Console.WriteLine("Faz relatorio sobre todas as informações");
                        break;
                    case 8:
                        repetir = false;
                        break;
                    default:
                        Console.WriteLine("default case");
                        break;

                }
            }
        }
    }
}
