using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_1_adriano_wilson
{
    class Menus
    {
        public static void Caso1(List<Cliente> clientes)
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("\nPrecisa de adicionar um cliente primeiro");

            }
            else
            {
                Console.WriteLine("\nEscolha o ID de um cliente para associar o animal:");

                imprimeClientes(clientes);

                int idCliente = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nIntruduza o nome do animal de estimação:");
                string nomeAnimal = Console.ReadLine();

                Console.WriteLine("\nIntruduza a idade do animal de estimação:");
                int idadeAnimal = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nIntruduza o genero do animal de estimação:");
                string generoAnimal = Console.ReadLine();

                Console.WriteLine("\nIntruduza o especie do animal de estimação:");
                string especiAnimal = Console.ReadLine();

                adicionaAnimal(clientes,idCliente,nomeAnimal,idadeAnimal,generoAnimal,especiAnimal);

                Console.WriteLine("\nRegistou um animal");
            }

        }

        public static void Caso2(List<Cliente> clientes)
        {
            Console.WriteLine("\nIntruduza o nome:");
            string nomeCliente = Console.ReadLine();

            Console.WriteLine("\nIntruduza o contacto:");
            int contactoCliente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIntruduza o endereço:");
            string enderecoCliente = Console.ReadLine();

            clientes.Add(new Cliente(nomeCliente, contactoCliente, enderecoCliente));
            Console.WriteLine("\nRegistou um cliente");

        }

        public static void Caso3(List<Cliente> clientes, List<Servicos> servicos, List<Empregado> empregados)
        {
            Console.WriteLine("\nSelecione um servico \n");
            imprimeServicos(servicos);
            int servicoEscolhido = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEscolha o id do cliente:");
            imprimeClientes(clientes);
            int idClienteEscolhido = Convert.ToInt32(Console.ReadLine());
            
            if(verificaAnimaisDoCliente(clientes, idClienteEscolhido))
            {
                Console.WriteLine("\nEscolha o id do animal:");
                imprimeAnimaisDoCliente(clientes, idClienteEscolhido);
                int idAnimalEscolhido = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nEscolha um profissional de saude:");
                imprimeEmpregados(empregados);
                int idEmpregadoEscolhido = Convert.ToInt32(Console.ReadLine());

                adicionaServico(clientes, servicos, empregados, servicoEscolhido, idAnimalEscolhido, idEmpregadoEscolhido);
            }
            
            
           
        }

        public static void Caso4(List<Empregado> empregados)
        {
            foreach (Empregado empregado in empregados)
            {

                empregado.printEmpregado();

            }
        }

        public static void Caso5(List<Cliente> clientes, List<Servicos> servicos, List<Empregado> empregados)
        {
            Console.WriteLine("Relatorio:");
            foreach (var cliente in clientes)
            {
                cliente.printClientesEAnimais();
            }
        }


        public static void imprimeClientes(List<Cliente> clientes)
        {
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine("ID: " + cliente.id + " Nome: " + cliente.nome);
            }
            Console.Write("=>");
        }

        public static void adicionaAnimal(List<Cliente> clientes, int idCliente, string nomeAnimal, int idadeAnimal, string generoAnimal, string especiAnimal)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.id == idCliente)
                {
                    cliente.adicionaAnimalAoCliente(nomeAnimal, idadeAnimal, generoAnimal, especiAnimal);
                }
            }
        }

        public static void imprimeServicos(List<Servicos> servicos)
        {
            foreach (Servicos servico in servicos)
            {
                servico.printServicos();
            }
            Console.Write("=>");
        }

        public static bool verificaAnimaisDoCliente(List<Cliente> clientes, int idCliente)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.id == idCliente && cliente.temAnimal())
                {
                    return true;

                }
            }
            Console.WriteLine("Este cliente não tem animais associados");
            return false;
        }
        public static void imprimeAnimaisDoCliente(List<Cliente> clientes,int idCliente)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.id == idCliente )
                {
                    cliente.printAnimals();
                    
                }

            }
            Console.Write("=>");
        }

        public static void imprimeEmpregados(List<Empregado> empregados)
        {
            foreach(Empregado empregado in empregados)
            {
                empregado.printEmpregado();

            }
            Console.Write("=>");
        }

        public static void adicionaServico(List<Cliente> clientes, List<Servicos> servicos, List<Empregado> empregados, int servicoEscolhido, int idAnimalEscolhido, int idEmpregadoEscolhido)
        {
            foreach (Cliente cliente in clientes)
            {
                foreach (Animal animal in cliente.animais)
                {
                    if (animal.numeroIdentificacao == idAnimalEscolhido)
                    {
                        foreach (Servicos servico in servicos)
                        {
                            if (servico.id == servicoEscolhido)
                            {
                                animal.adicionaServicoAoAnimal(servico);
                                foreach (Empregado empregado in empregados)
                                {
                                    if (empregado.id == idEmpregadoEscolhido)
                                    {
                                        servico.adicionaEmpregadoAServico(empregado);
                                    }

                                }

                            }
                        }

                    }
                }

            }
        }

    }
}
