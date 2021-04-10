using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_1_adriano_wilson
{   
    class Servicos
    {   
        List<String> Medicamentos = new List<String>();

        public Servicos(int id, string nome, double preco, double duracao, string medicamentos)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
            this.duracao = duracao;

            //Adiciona medicamentos separado por virgulas
            string[] words = medicamentos.Split(',');

            foreach (var word in words)
            {
                this.Medicamentos.Add(word);
            }
        }
        public int id { get; set; }
        public string nome { get; set; }
        public double preco { get; set; }
        public double duracao { get; set; }

        public void printServico()
        {
            Console.WriteLine("\n########################### ");
            Console.WriteLine("\nInformação sobre os serviços: ");
            Console.WriteLine("\tID           : " + id);
            Console.WriteLine("\tnome         : " + nome);
            Console.WriteLine("\tPreco        : " + preco + " euros");
            Console.WriteLine("\tDuracao      : " + duracao + " minutos");
            Console.Write("\tMedicamentos :");
            foreach (var Medicamento in Medicamentos)
            {
                Console.Write(" " + Medicamento + ", ");
            }

            Console.WriteLine("\n########################### ");
        }
    }
}
