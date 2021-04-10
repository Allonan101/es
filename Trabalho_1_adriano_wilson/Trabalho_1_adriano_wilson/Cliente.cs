using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_1_adriano_wilson
{
    class Cliente : Pessoa
    {
        List<Animal> animais = new List<Animal>();
        public Cliente(string nome, int contacto, string endereco)
        {
            this.nome = nome;
            this.contacto = contacto;
            this.endereco = endereco;
            this.id = geraId();
        }

        public int id { get; set; }

        public void adicionaAnimalAoCliente(string nomeAnimal, int idadeAnimal, string generoAnimal, string especiAnimal, int numeroIdentificacaoAnimal)
        {
            animais.Add(new Animal(nomeAnimal, idadeAnimal, generoAnimal, especiAnimal, numeroIdentificacaoAnimal));
        }
        public void printClientesEAnimais()
        {
            Console.WriteLine("\n########################### ");
            Console.WriteLine("\nInformação sobre o cliente: ");
            Console.WriteLine("\tNome     : " + nome);
            Console.WriteLine("\tContacto : " + contacto);
            Console.WriteLine("\tEndereço : " + endereco);
            foreach (Animal animal in animais)
            {
                animal.printAnimais();
            }
            Console.WriteLine("\n########################### ");
        }
        public void printAnimals()
        {
            foreach (Animal animal in animais)
            {
                Console.WriteLine("ID : " + animal.numeroIdentificacao + " Nome : " + animal.nome);
                
            }
        }

        public int geraId()
        {
            Random rand = new Random();
            int id = rand.Next(1,300);
            return id;
        }
       
    }
}
