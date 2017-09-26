using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameTESTE {
    class ProfissaoTest{
        String profissao;
        float bonus;

        public string Profissao { get => profissao; set => profissao = value; }
        public float Bonus { get => bonus; set => bonus = value; }

        public void Extra() {
            if (String.Equals(Profissao, "MEDICO", StringComparison.OrdinalIgnoreCase))
                //Implementar Habilidades
                Bonus = 300f;
            else if (String.Equals(Profissao, "ADVOGADO", StringComparison.OrdinalIgnoreCase))
                //Implementar Habilidades
                Bonus = 300f;
            else if (String.Equals(Profissao, "POLICIAL", StringComparison.OrdinalIgnoreCase))
                //Implementar Habilidades
                Bonus = 250f;
            else if (String.Equals(Profissao, "PSICOLOGO", StringComparison.OrdinalIgnoreCase))
                //Implementar Habilidades
                Bonus = 250f;
            else if (String.Equals(Profissao, "PROFESSOR", StringComparison.OrdinalIgnoreCase))
                //Implementar Habilidades
                Bonus = 100f;
            else if (String.Equals(Profissao, "ATOR", StringComparison.OrdinalIgnoreCase))
                //Implementar Habilidades
                Bonus = 100f;
        }

    }
}
