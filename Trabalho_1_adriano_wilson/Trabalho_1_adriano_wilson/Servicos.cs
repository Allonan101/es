using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_1_adriano_wilson
{
    class Servicos
    {
        public Servicos(double preco, double duracao, string medicamentos)
        {
            this.preco = preco;
            this.duracao = duracao;
            this.medicamentos = medicamentos;
        }
        public double preco { get; set; }
        public double duracao { get; set; }
        public string medicamentos { get; set; }

        public void printServico()
        {
            Console.WriteLine("\n########################### ");
            Console.WriteLine("\nInformação sobre este serviço: ");
            Console.WriteLine("\tPreco        : " + preco + " Euros");
            Console.WriteLine("\tduracao      : " + duracao + " minutos");
            Console.WriteLine("\tmedicamentos : " + medicamentos);
            Console.WriteLine("\n########################### ");
        }
    }
}
