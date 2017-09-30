using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace textgame
{
    class Profissao
    {
        //ATRIBUTOS
        public String nome;
        public float bonus;
        public List<String> listHabilidades = new List<String>();


        //COMPORTAMENTOS E METODOS
        public Profissao(String n, float b) {
            Nome = n;
            Bonus = b;
        }
        public String Nome { 
            get { return nome; }
            set { nome = value; }
        }
        public float Bonus {
            get { return bonus; }
            set { bonus = value;}
        }
        public List<String> ListHabilidades {
            get { return listHabilidades; }
            set { listHabilidades = value; }
        }
    }
}
