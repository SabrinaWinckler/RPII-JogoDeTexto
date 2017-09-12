using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameTESTE
{
    class Personagem : Ocupacao
    {
        //ATRIBUTOS
        private String nome;
        private Ocupacao ocupacao;

        //COMPORTAMENTOS E METODOS
        public string Nome { get => nome; set => nome = value; }

        public void setOcupacao(String ocupacao)
        {
            this.ocupacao = new Ocupacao();
            this.ocupacao.Profissao = ocupacao;
            this.ocupacao.getHabilidades();
        }
    }
}
