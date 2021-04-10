﻿using System;
using System.Collections.Generic;

namespace Trabalho_1_adriano_wilson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();

            //Lista de Empregados
            Empregado Alberto = new Empregado("Adalberto",956689781,"8:00 até 16:00", 0);
            Empregado Luisa = new Empregado("Luisa", 91868686, "9:00 até 17:00", 0);
            Empregado Wilson = new Empregado("Wilson", 986698666, "17:00 até 8:00", 1);
            Empregado Ricardo = new Empregado("Ricardo", 989898989,"19:00 até 9:00", 1);


            //Lista de serviços
            Servicos checkUp = new Servicos(1, "checkup", 5, 15, "Nenhum");
            Servicos exameDeSangue = new Servicos(2, "Exame de sangue", 30, 60, "Amitriptilina, Citalopram , Escitalopram");
            Servicos coproparasitologico = new Servicos(3, "Exame coproparasitologico", 15, 30, "Amitriptilina, Citalopram , Escitalopram");
            Servicos Eletrocardiograma = new Servicos(4, "Exame eletrocardiograma", 30, 60, "Amitriptilina, Citalopram , Escitalopram");

            bool repetir = true;
            while (repetir == true)
            {
                Console.WriteLine("\nBem vindo a clinica veterinaria");
                Console.WriteLine("1- Registe um animal");
                Console.WriteLine("2- Registe um cliente");
                Console.WriteLine("3- Realizar um Serviço");
                Console.WriteLine("4- Mostrar empregados");
                Console.WriteLine("5- Mostrar clientes");
                Console.WriteLine("6- Fazer o relatório");
                Console.WriteLine("7- Sair");
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
                            Console.WriteLine("\nEscolha o ID de um cliente para associar o animal:");
                            
                            foreach (Cliente cliente in clientes)
                            {
                                Console.WriteLine("ID: " + cliente.id + " Nome: " + cliente.nome);
                            }

                            int idCliente = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nIntruduza o nome do animal de estimação:");
                            string nomeAnimal = Console.ReadLine();

                            Console.WriteLine("\nIntruduza a idade do animal de estimação:");
                            int idadeAnimal = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nIntruduza o genero do animal de estimação:");
                            string generoAnimal = Console.ReadLine();

                            Console.WriteLine("\nIntruduza o especie do animal de estimação:");
                            string especiAnimal = Console.ReadLine();

                            Console.WriteLine("\nIntruduza o numero de identificação do animal de estimação:");
                            int numeroIdentificacaoAnimal = Convert.ToInt32(Console.ReadLine());

                            foreach (Cliente cliente in clientes)
                            {
                                if (cliente.id == idCliente)
                                {
                                    cliente.adicionaAnimalAoCliente(nomeAnimal, idadeAnimal, generoAnimal, especiAnimal, numeroIdentificacaoAnimal);
                                }
                            }
                            
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
                        
                        Console.WriteLine("\nSelecione um servico");
                        checkUp.printServico();
                        exameDeSangue.printServico();
                        int servicoEscolhido = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("\nEscolha o id do cliente:");

                        //registar um id para cada cliente
                        foreach (Cliente cliente in clientes)
                        {
                            Console.WriteLine(cliente.id + " " + cliente.nome);
                        }
                        int idClienteEscolhido = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("\nEscolha o id do animal:");
                        foreach (Cliente cliente in clientes)
                        {
                            if (cliente.id == idClienteEscolhido)
                            {
                                cliente.printAnimals();
                            }
                        }
                        int idAnimal = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nEscolha um profissional de saude:");
                        int idProfissional = Convert.ToInt32(Console.ReadLine());

                        //foreach (Consulta consulta in Con)
                        //{
                        //    if (cliente.id == idClienteEscolhido)
                        //    {
                        //        cliente.printAnimals();
                        //    }
                        //}

                        //this is scuffed :-)

                        foreach (Cliente cliente in clientes)
                        {
                            foreach(Animal animal in cliente.animais)
                            {
                                if  (animal.numeroIdentificacao == idAnimal)
                                {
                                    if(checkUp.id == servicoEscolhido)
                                    {
                                        animal.adicionaServicoAoAnimal(checkUp);
                                    }
                                    else
                                    {
                                        animal.adicionaServicoAoAnimal(exameDeSangue);
                                    }
                                    
                                }
                            }
                    
                        }
                        break;
                    case 4:
                        Console.WriteLine("Lista de empregados");
                        break;
                    case 5:
                        foreach (var cliente in clientes)
                        {
                            cliente.printClientesEAnimais();
                        }
                        break;
                    case 6:
                        Console.WriteLine("Faz relatorio sobre todas as informações");
                        break;
                    case 7:
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
