using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameTESTE
{
    class Ocupacao
    {
        //ATRIBUTOS
        private String profissao;

        //CONPORTAMENTOS E METODOS
        public Ocupacao()
        {
            this.profissao = Profissao;
        }

        public string Profissao { get => profissao; set => profissao = value; }

        public void getHabilidades()
        { 
            if (String.Equals(this.Profissao, "POLICIAL", StringComparison.OrdinalIgnoreCase))
            {
                Policial policial = new Policial();
                policial.getHabilidades();
            }
            else if (String.Equals(this.Profissao, "MEDICO", StringComparison.OrdinalIgnoreCase))
            {
                Medico medico = new Medico();
                medico.getHabilidades();
            }
            else if (String.Equals(this.Profissao, "PSICOLOGO", StringComparison.OrdinalIgnoreCase))
            {
                Psicologo psicologo = new Psicologo();
                psicologo.getHabilidades();
            }
            else if (String.Equals(this.Profissao, "PROFESSOR", StringComparison.OrdinalIgnoreCase))
            {
                Professor professor = new Professor();
                professor.getHabilidades();

            }
            else if (String.Equals(this.Profissao, "ATOR", StringComparison.OrdinalIgnoreCase))
            {
                Ator ator = new Ator();
                ator.getHabilidades();
            }
            else if (String.Equals(this.Profissao, "ADVOGADO", StringComparison.OrdinalIgnoreCase))
            {
                Advogado advogado = new Advogado();
                advogado.getHabilidades();
            }
            else
            {
                Console.WriteLine("Nao ha habilidades para essa ocupacao!!!!!");
            }
        }

    }
}
