using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameTESTE {
    class PersonagemTest {
        private float saldo;
        private ProfissaoTest profissaoTest;

        public float Saldo { get => saldo; set => saldo = value; }

        public PersonagemTest() {
            profissaoTest = new ProfissaoTest();
            Saldo = 100f;
        }

        public void setProfissaoTest(String profissao)
        => profissaoTest.Profissao = profissao;

        public String getProfissaoTest() => profissaoTest.Profissao;

        public void AtualizaSaldo() => Saldo += profissaoTest.Saldo;
    }
}
