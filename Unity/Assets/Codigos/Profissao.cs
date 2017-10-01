using System;
using System.Collections;
using System.Collections.Generic;

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
        public List<String> List_Habilidades {
            get { return listHabilidades; }
        }
        public void Add_Habilidades(String h) {
            listHabilidades.Add(h);
        }
    }
}
