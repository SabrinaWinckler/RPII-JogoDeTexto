using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    class Personagem
    {
        private String nome;

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public String getNome()
        {
            return this.nome;
        }
    }
}
