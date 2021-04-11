using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Trabalho_1_adriano_wilson;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Verifica_Funcao_Gera_Empregados()
        {
            
            List<Empregado> empregados = new List<Empregado>();
            Gerar.GerarEmpregados(empregados);

            int expectedLength = 4;

            int actualLength = empregados.Count;

            Assert.AreEqual(expectedLength, actualLength);
        }

        [TestMethod]
        public void Verifica_Funcao_Gera_Servicos()
        {

            List<Servicos> servicos = new List<Servicos>();
            Gerar.GerarServicos(servicos);

            int expectedLength = 4;

            int actualLength = servicos.Count;

            Assert.AreEqual(expectedLength, actualLength);
        }


        [TestMethod]
        public void Testar_Gerar_Clientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            Gerar.GerarClientes(clientes);
            Assert.IsNotNull(clientes);
        }

        [TestMethod]
        public void Testar_Associacao_De_Clientes_E_Animais()
        {
        
            Cliente cliente1 = new Cliente("Joao das Pontes", 975565898, "Jardim da Serra");
            cliente1.adicionaAnimalAoCliente("Bigodes", 12, "macho", "gato");
            Assert.IsNotNull(cliente1.animais);
 
        }

        [TestMethod]
        public void Testar_Associacao_de_Servico_E_Empregado()
        {
            Servicos servico1 = new Servicos(1, "checkup", 5, 15, "Nenhum");
            Empregado empregado1 = new Empregado(1, "Adalberto", 956689781, "8:00 até 16:00", 0);
            servico1.adicionaEmpregadoAServico(empregado1);
            Assert.IsNotNull(servico1.Empregados);
        }

    }
}
