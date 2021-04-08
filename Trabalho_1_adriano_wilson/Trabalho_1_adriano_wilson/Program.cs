using System;

namespace Trabalho_1_adriano_wilson
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = true;
            while (repetir == true)
            {
                Console.WriteLine("Bem vindo a clinica veterinaria");
                Console.WriteLine("1- Registe um animal");
                Console.WriteLine("2- Registe um cliente");
                Console.WriteLine("3- Serviços");
                Console.WriteLine("4- Fazer o relatório");
                Console.WriteLine("5- Sair");
                Console.Write("=>");
                int opcao = Convert.ToInt32(Console.ReadLine());
           
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Registou um animal");
                        break;
                    case 2:
                        Console.WriteLine("Registou um cliente");
                        break;
                    case 3:
                        Console.WriteLine("Mostra todos os serviços disponiveis");
                        Console.WriteLine("Mostra depois todos os empregados disponiveis para ajudar");
                        break;
                    case 4:
                        Console.WriteLine("Faz relatorio sobre todas as informações");
                        break;
                    case 5:
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
