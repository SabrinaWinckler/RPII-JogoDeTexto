using System;
using System.Collections;
using System.Collections.Generic;

namespace textgame
{
    class Profissao
    {
        //ATRIBUTOS
        public String profissao;
        public List<String> habilidades = new List<String>();
        public float bonus;

        //COMPORTAMENTOS E METODOS
        public Profissao(String p) {
            Prof = p;
            bonus = getBonus();
        }

        public String Prof {
            get { return profissao; }
            set { profissao = value; }
        }
        public List<String> Habilidades {
            get { return habilidades; }
            set { habilidades = value; }
        }

        public float getBonus() {
            if (String.Equals(Prof, "MEDICO", StringComparison.OrdinalIgnoreCase)) {
                return bonus = 300f;
            } else if (String.Equals(Prof, "ADVOGADO", StringComparison.OrdinalIgnoreCase)) {
                return bonus = 300f;
            } else if (String.Equals(Prof, "POLICIAL", StringComparison.OrdinalIgnoreCase)) {
                return bonus = 250f;
            } else if (String.Equals(Prof, "PSICOLOGO", StringComparison.OrdinalIgnoreCase)) {
                return bonus = 250f;
            } else if (String.Equals(Prof, "PROFESSOR", StringComparison.OrdinalIgnoreCase)) {
                return bonus = 100f;
            } else if (String.Equals(Prof, "ATOR", StringComparison.OrdinalIgnoreCase)) {
                return bonus = 100f;
            } else {
                return 0;
            }
        }
    }
}
