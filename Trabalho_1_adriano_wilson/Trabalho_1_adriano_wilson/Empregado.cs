using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_1_adriano_wilson
{   
    class Empregado : Pessoa
    {
        public string horario { get; set; }
        public int turno { get; set; }

        public Empregado(string nome,int contacto, string horario, int turno)
        {
            this.nome = nome;
            this.contacto = contacto;
            this.horario = horario;
            this.turno = turno;
        }
        public void printDisponibilidade()
        {
            Console.WriteLine("Turno:\n");
            if (turno == 0) 
            {
                Console.WriteLine("\tDiurno\n");
                Console.WriteLine("\tHorario:"  + horario + "\n");

            }
            else
            {
                Console.WriteLine("\tNoturno\n");
                Console.WriteLine("\tHorario:" + horario + "\n");
            }
        }


    }
}
