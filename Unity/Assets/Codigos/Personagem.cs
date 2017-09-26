using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace textgame
{
    class Personagem
    {
        public float saldo;
        public Profissao profissao = new Profissao();
        public Personagem() {
            Saldo = 0.0f;
        }

        public float Saldo {
            get {return saldo; }
            set {saldo = value; }
        }

        public void setprofissao(String profi) {
            profissao.Profi = profi;
        }

        public String getprofissao() {
            return profissao.Profi;
        }

        public void AtualizaSaldo() {
            profissao.Extra();
            Saldo += profissao.Bonus;
        }
    }
}
