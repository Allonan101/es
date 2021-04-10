using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_1_adriano_wilson
{
    
    class Animal
    {
        List<Servicos> servicos = new List<Servicos>();

        public string nome { get; set; }
        public int idade { get; set; }
        public string genero { get; set; }
        public string especie { get; set; }
        public int numeroIdentificacao { get; set; }

        public Animal(string nome, int idade, string genero, string especie, int numeroIdentificacao)
        {
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
            this.especie = especie;
            this.numeroIdentificacao = numeroIdentificacao;

        }

        public void printAnimais()
        {
            Console.WriteLine("\nInformação sobre o animal: ");
            Console.WriteLine("\tNome     : " + nome);
            Console.WriteLine("\tidade    : " + idade);
            Console.WriteLine("\tgenero   : " + genero);
            Console.WriteLine("\tespecie  : " + especie);
            Console.WriteLine("\tnumero de Identificacao : " + numeroIdentificacao);
        }

        public void printServicos()
        {
            foreach(Servicos servico in servicos)
            {

                servico.printServico();

            }
        }

    }
}
