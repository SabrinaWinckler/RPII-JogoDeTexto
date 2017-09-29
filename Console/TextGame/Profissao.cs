using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameTESTE
{
    class Profissao
    {
        //ATRIBUTOS
        private String profissao;
        private ArrayList habilidades = new ArrayList();
        private float bonus;

        //COMPORTAMENTOS E MÉTODOS

        public Profissao(String p) {
            Prof = p;
            bonus = getBonus();
        }

        public String Prof { get => profissao; set => profissao = value; }
        public ArrayList Habilidades { get => habilidades; set => habilidades = value; }

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
