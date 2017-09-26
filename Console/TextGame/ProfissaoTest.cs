using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameTESTE {
    class ProfissaoTest : PersonagemTest{
        String profissao;

        public string Profissao { get => profissao; set => profissao = value; }

        public void Bonus_e_Habilidades() {
            if (String.Equals(Profissao, "MEDICO", StringComparison.OrdinalIgnoreCase))
                Saldo = Saldo + 300f;
            else if (String.Equals(Profissao, "POLICIAL", StringComparison.OrdinalIgnoreCase))
                Saldo = Saldo + 250f;
            else if (String.Equals(Profissao, "ADVOGADO", StringComparison.OrdinalIgnoreCase))
                Saldo = Saldo + 250f;
            else if (String.Equals(Profissao, "PSICOLOGO", StringComparison.OrdinalIgnoreCase))
                Saldo = Saldo + 200f;
            else if (String.Equals(Profissao, "PROFESSOR", StringComparison.OrdinalIgnoreCase))
                Saldo = Saldo + 100f;
            else if (String.Equals(Profissao, "ATOR", StringComparison.OrdinalIgnoreCase))
                Saldo = Saldo + 100f;
        }

    }
}
