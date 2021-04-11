using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_1_adriano_wilson
{
    class Cliente : Pessoa
    {
        public List<Animal> animais = new List<Animal>();
        
        public Cliente(string nome, int contacto, string endereco)
        {
            this.nome = nome;
            this.contacto = contacto;
            this.endereco = endereco;
            this.id = Gerar.geraId();
        }

        public void adicionaAnimalAoCliente(string nomeAnimal, int idadeAnimal, string generoAnimal, string especiAnimal)
        {
            animais.Add(new Animal(nomeAnimal, idadeAnimal, generoAnimal, especiAnimal));
        }
        public void printClientesEAnimais()
        {
            Console.WriteLine("\n################################## ");
            Console.WriteLine("\nInformação sobre o cliente: ");
            Console.WriteLine("\tNome     : " + nome);
            Console.WriteLine("\tContacto : " + contacto);
            Console.WriteLine("\tEndereço : " + endereco);
            foreach (Animal animal in animais)
            {
                animal.printAnimais();
                animal.printServicoseEmpregadosAssociadosAoAnimal();
            }

        }
        public void printAnimals()
        {
            foreach (Animal animal in animais)
            {
                Console.WriteLine("\nID : " + animal.numeroIdentificacao + "\nNome : " + animal.nome);

            }
            
        }

        public bool temAnimal()
        {
            if (animais.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
    }
}
