using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace textgame
{
    class Personagem : Profissao
    {
        //ATRIBUTOS
        private String nome;
        private float saldo;

        //COMPORTAMENTOS E METODOS
        public string Nome { get; private set; }
        public float Saldo { get; set; }
    }
}
