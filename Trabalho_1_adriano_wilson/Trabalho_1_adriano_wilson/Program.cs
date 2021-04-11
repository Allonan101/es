using System;
using System.Collections.Generic;


namespace Trabalho_1_adriano_wilson
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Empregado> empregados = new List<Empregado>();
            List<Servicos> servicos = new List<Servicos>();

            Gerar.GerarClientes(clientes);
            Gerar.GerarEmpregados(empregados);
            Gerar.GerarServicos(servicos);
            Gerar.GerarAnimaisAssociadosAoCliente(clientes);


            bool repetir = true;
            while (repetir == true)
            {
                Console.WriteLine("\nBem vindo a clinica veterinaria");
                Console.WriteLine("1- Registe um animal");
                Console.WriteLine("2- Registe um cliente");
                Console.WriteLine("3- Realizar um Serviço");
                Console.WriteLine("4- Mostrar empregados");
                Console.WriteLine("5- Fazer o relatório");
                Console.WriteLine("6- Sair");
                Console.Write("=>");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Menus.Caso1(clientes);
                        break;
                    case 2:
                        Menus.Caso2(clientes);
                        break;
                    case 3:
                        Menus.Caso3(clientes, servicos, empregados);
                        break;
                    case 4:
                        Menus.Caso4(empregados);
                        break;
                    case 5:
                        Menus.Caso5(clientes, servicos, empregados);
                        break;
                    case 6:
                        repetir = false;
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção correta");
                        break;
                }
            }
        }
    }
}

