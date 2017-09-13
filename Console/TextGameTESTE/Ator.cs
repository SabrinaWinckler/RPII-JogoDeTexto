using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameTESTE
{
    class Ator
    {
        //ATRIBUTOS
        private ArrayList habilidades = new ArrayList();

        //COMPORTAMENTOS E METODOS
        public Ator()
        {
            this.habilidades.Add("1 - DRAMATIZACAO.");
            this.habilidades.Add("2 - ARTE DA PERSUASAO.");
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
