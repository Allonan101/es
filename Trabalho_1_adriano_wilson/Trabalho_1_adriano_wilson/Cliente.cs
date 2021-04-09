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

        }
        
        public void adicionaAnimalAoCliente(string nomeAnimal, int idadeAnimal, string generoAnimal, string especiAnimal, int numeroIdentificacaoAnimal)
        {
            animais.Add(new Animal(nomeAnimal, idadeAnimal, generoAnimal, especiAnimal, numeroIdentificacaoAnimal));
        }
        public void printClientes()
        {
            Console.WriteLine("\n########################### ");
            Console.WriteLine("\nInformação sobre o cliente: ");
            Console.WriteLine("\tNome     : " + nome);
            Console.WriteLine("\tContacto : " + contacto);
            Console.WriteLine("\tEndereço : " + endereco);
            foreach(Animal animal in animais)
            {
                
                Console.WriteLine("\nInformação sobre o animal: ");
                Console.WriteLine("\tNome     : " + animal.nome);
                Console.WriteLine("\tidade    : " + animal.idade);
                Console.WriteLine("\tgenero   : " + animal.genero);
                Console.WriteLine("\tespecie  : " + animal.especie);
                Console.WriteLine("\tnumero de Identificacao : " + animal.numeroIdentificacao);
                
            }
            Console.WriteLine("\n########################### ");

        }
       
    }
}
