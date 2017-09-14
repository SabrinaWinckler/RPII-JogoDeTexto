using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameTESTE
{
    class Psicologo
    {
        //ATRIBUTOS
        private ArrayList habilidades = new ArrayList();

        //COMPORTAMENTOS E METODOS
        public Psicologo()
        {
            this.habilidades.Add("1 - CAPACIDADE RACIONAL FACIL.");
            this.habilidades.Add("2 - INTUICAO DIFERENCIADA.");
            this.habilidades.Add("3 - CAPACIDADE DE ANALISE.");
            this.habilidades.Add("4 - CAPACIDADE DE COMUNICACAO.");

        }

        public void getHabilidades()
        {
            foreach (var item in habilidades)
            {
                Console.WriteLine(item);
            }
        }
    }
}
