using System;
using System.Collections;
using System.Collections.Generic;

namespace TextGame
{
    class Npc : Personagem
    {
        public char genero { get; }
        public bool antagonista { get; }
        private ArrayList falas = new ArrayList();

    public Npc(String nome, String ocupacao, char genero, bool antagonista)
        {
            this.nome = nome;
            this.ocupacao = ocupacao;
            this.genero = genero;
            this.antagonista = antagonista;
        }

        public void adicionarFala(String fala)
        {
            this.falas.Add(fala.ToString());
        }

        public ArrayList Falas
        {
            get { return this.falas; }
        }
    }
}
