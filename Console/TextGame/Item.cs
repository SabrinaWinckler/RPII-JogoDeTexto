using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameTESTE
{
    class Item
    {
        //ATRIBUTOS
        private String nome;
        private String[] item = { "FACA", "GRANADA", "ARMA", "REMEDIO", "LUVA", "BUSSOLA", "IDENTIDADES FALSAS", "PASSAPORTES FALSOS", "OCULOS", "CANETA" };
        private Random r = new Random();

        //COMPORTAMENTOS E METODOS
        public Item()
        {
            nome = item[r.Next(10)];
        }

        public string Nome { get => nome; set => nome = value; }
    }
}
