using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Trabalho_1_adriano_wilson
{
    class Cliente : Pessoa
    {
        
        public Cliente(string nome, int contacto, string endereco)
        {
            this.nome = nome;
            this.contacto = contacto;
            this.endereco = endereco;

        }
        public void printClientes()
        {
            Console.WriteLine("\n########################### ");
            Console.WriteLine("\nInformação sobre o cliente: ");
            Console.WriteLine("\tNome     : " + nome);
            Console.WriteLine("\tContacto : " + contacto);
            Console.WriteLine("\tEndereço : " + endereco);
            Console.WriteLine("\n########################### ");
        }
       
    }
}
