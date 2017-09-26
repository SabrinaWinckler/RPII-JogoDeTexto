using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace textgame
{
    class Profissao
    {
        //ATRIBUTOS
        public String profissao;
        public float bonus;

        public String Profi { 
            get { return profissao; }
            set { profissao = value; }
        }

        public float Bonus {
            get { return bonus; }
            set { bonus = value;}
        }

        public void Extra() {
            if (String.Equals(Profi, "MEDICO", StringComparison.OrdinalIgnoreCase))
                //Implementar Habilidades
                Bonus = 300f;
            else if (String.Equals(Profi, "ADVOGADO", StringComparison.OrdinalIgnoreCase))
                //Implementar Habilidades
                Bonus = 300f;
            else if (String.Equals(Profi, "POLICIAL", StringComparison.OrdinalIgnoreCase))
                //Implementar Habilidades
                Bonus = 250f;
            else if (String.Equals(Profi, "PSICOLOGO", StringComparison.OrdinalIgnoreCase))
                //Implementar Habilidades
                Bonus = 250f;
            else if (String.Equals(Profi, "PROFESSOR", StringComparison.OrdinalIgnoreCase))
                //Implementar Habilidades
                Bonus = 100f;
            else if (String.Equals(Profi, "ATOR", StringComparison.OrdinalIgnoreCase))
                //Implementar Habilidades
                Bonus = 100f;
        }
    }
}
