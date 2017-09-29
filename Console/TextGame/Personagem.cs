using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TextGameTESTE
{
    class Personagem
    {
        //ATRIBUTOS
        private float saldo;
        private Profissao profissao;

        //COMPORTAMENTOS E MÉTODOS
        public Personagem() => Saldo = 300.0f;

        public float Saldo { get => saldo; set => saldo = value; }

        public void setProfissao(String p) {
            profissao = new Profissao(p);
            Saldo += profissao.getBonus();
        }

        public String getProfissao() => profissao.Prof;

        public void setHabilidades(String h) {
            if (h!=null)
                profissao.Habilidades.Add(h);
        }

        public void getHabilidades() {
            foreach (var item in profissao.Habilidades) {
                WriteLine(item);
            }
        }

    }
}
