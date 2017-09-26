using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameTESTE {
    class PersonagemTest {
        private float saldo;
        private static ProfissaoTest profissaoTest = new ProfissaoTest();

        public PersonagemTest() => Saldo = 0.0f;

        public float Saldo { get => saldo; set => saldo = value; }

        public void setProfissaoTest(String profissao)
        => profissaoTest.Profissao = profissao;

        public String getProfissaoTest() => profissaoTest.Profissao;

        public void AtualizaSaldo() {
            profissaoTest.Extra();
            Saldo += profissaoTest.Bonus;
        }
    }
}
