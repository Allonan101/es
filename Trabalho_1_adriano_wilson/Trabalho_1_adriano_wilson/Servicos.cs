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
        List<Empregado> Empregados = new List<Empregado>();

      
        public Servicos(int id, string nome, double preco, double duracao, string medicamentos)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
            this.duracao = duracao;
            this.frequencia = 0;

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

        public int frequencia { get; set; }

        public void printServicos()
        {
            Console.WriteLine("\nInformação sobre os serviços: ");
            Console.WriteLine("\tID           : " + id);
            Console.WriteLine("\tnome         : " + nome);
            Console.WriteLine("\tPreco        : " + preco + " euros");
            Console.WriteLine("\tDuracao      : " + duracao + " minutos");
            Console.WriteLine("\tFrequencia   : " + frequencia);
            Console.Write("\tMedicamentos :");
            foreach (var Medicamento in Medicamentos)
            {
                Console.Write(" " + Medicamento + ",");
            }
            Console.Write("\n");
        }
        public void printEmpregadosAssociadosServicos()
        {
            Console.WriteLine("\nServiços prestados: ");
            Console.WriteLine("\tID           : " + id);
            Console.WriteLine("\tnome         : " + nome);
            Console.WriteLine("\tPreco        : " + preco + " euros");
            Console.WriteLine("\tDuracao      : " + duracao + " minutos");
            Console.WriteLine("\tFrequencia   : " + frequencia);
            Console.Write("\tMedicamentos :");
            foreach (var Medicamento in Medicamentos)
            {
                Console.Write(" " + Medicamento + ",");
            }
            Console.Write("\n");
            foreach (var empregado in Empregados)
            {
                empregado.printEmpregado();
            }
  
        }
        public void adicionaEmpregadoAServico(Empregado empregado)
        {
            Empregados.Add(empregado);

        }
    }
}
