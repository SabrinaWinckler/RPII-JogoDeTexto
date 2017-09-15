using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameTESTE
{
    class Personagem : Profissao
    {
        //ATRIBUTOS
        private String nome;

        //COMPORTAMENTOS E METODOS
        public string Nome { get => nome; set => nome = value; }
    }
}
