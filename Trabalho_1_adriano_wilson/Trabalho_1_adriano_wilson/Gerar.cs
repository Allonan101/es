using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_1_adriano_wilson
{
    public class Gerar
    {
        public static int geraId()
        {
            Random rand = new Random();
            int id = rand.Next(1, 300);
            return id;
        }
        public static void GerarEmpregados(List<Empregado> listaEmpregados)
        {
            //Lista de Empregados
            listaEmpregados.Add(new Empregado(1, "Adalberto", 956689781, "8:00 até 16:00", 0));
            listaEmpregados.Add(new Empregado(2, "Luisa", 91868686, "9:00 até 17:00", 0));
            listaEmpregados.Add(new Empregado(3, "Wilson", 986698666, "17:00 até 8:00", 1));
            listaEmpregados.Add(new Empregado(4, "Ricardo", 989898989, "19:00 até 9:00", 1));

        }
        public static void GerarServicos(List<Servicos> listaServicos)
        {
            listaServicos.Add(new Servicos(1, "checkup", 5, 15, "Nenhum"));
            listaServicos.Add(new Servicos(2, "Exame de sangue", 30, 60, "Amitriptilina, Citalopram , Escitalopram"));
            listaServicos.Add(new Servicos(3, "Exame coproparasitologico", 15, 30, "Amitriptilina, Citalopram , Escitalopram"));
            listaServicos.Add(new Servicos(4, "Exame eletrocardiograma", 30, 60, "Amitriptilina, Citalopram , Escitalopram"));
           
        }

        public static void GerarClientes(List<Cliente> listaClientes)
        {
            listaClientes.Add(new Cliente("Joao das Pontes", 975565898, "Jardim da Serra"));
            listaClientes.Add(new Cliente("Joana", 975565898, "Jardim da Serra"));
            listaClientes.Add(new Cliente("Elon Musk", 975565898, "Jardim da Serra"));
        }

        public static void GerarAnimaisAssociadosAoCliente(List<Cliente> listaAnimais)
        {
            listaAnimais[0].adicionaAnimalAoCliente("Bigodes", 12, "macho", "gato");
            listaAnimais[0].adicionaAnimalAoCliente("Pantufas", 12, "macho", "gato");
            listaAnimais[1].adicionaAnimalAoCliente("Bolachas", 12, "macho", "gato");
 
        }


    }
}
