using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_1_adriano_wilson
{   
    public class Empregado : Pessoa
    {
        public string horario { get; set; }
        public int turno { get; set; }

        public Empregado(int id, string nome,int contacto, string horario, int turno)
        {
            this.id = id;
            this.nome = nome;
            this.contacto = contacto;
            this.horario = horario;
            this.turno = turno;
        }
        public void printEmpregado()
        {
            Console.WriteLine("\nInformacao sobre os Empregados:");
            Console.WriteLine("\tID: " + id);
            Console.WriteLine("\tNome:" + nome);
            Console.WriteLine("\tContacto:" + contacto);
            Console.Write("\tTurno:");
            if (turno == 0)
            {
                Console.WriteLine("\tDiurno");
            }
            else
            {
                Console.WriteLine("\tNoturno");
            }
            Console.WriteLine("\tHorario:" + horario + "\n");
        }

    }
}
