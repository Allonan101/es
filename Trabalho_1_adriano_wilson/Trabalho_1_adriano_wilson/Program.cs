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
                Console.WriteLine("3- Serviços");
                Console.WriteLine("4- Mostrar clientes");
                Console.WriteLine("5- Fazer o relatório");
                Console.WriteLine("6- Sair");
                Console.Write("=>");

                int opcao = Convert.ToInt32(Console.ReadLine());
           
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Registou um animal");
                        break;
                    case 2:
                        Console.WriteLine("\nIntruduza o nome:");
                        string nomeCliente = Console.ReadLine();

                        Console.WriteLine("\nIntruduza o contacto:");
                        int contactoCliente = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nIntruduza o endereço:");
                        string enderecoCliente = Console.ReadLine();

                        clientes.Add(new Cliente(nomeCliente, contactoCliente, enderecoCliente));
                        Console.WriteLine("Registou um cliente");
                        break;
                    case 3:
                        Console.WriteLine("Mostra todos os serviços disponiveis");
                        Console.WriteLine("Mostra depois todos os empregados disponiveis para ajudar");
                        break;
                    case 4:
                        foreach (var cliente in clientes)
                        {
                            cliente.printClientes();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Faz relatorio sobre todas as informações");
                        break;
                    case 6:
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
