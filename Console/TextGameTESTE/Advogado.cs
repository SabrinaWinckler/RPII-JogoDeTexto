using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameTESTE
{
    class Advogado
    {
        //ATRIBUTOS
        private ArrayList habilidades = new ArrayList();

        //COMPORTAMENTOS E METODOS
        public Advogado()
        {
            this.habilidades.Add("1 - CONHECIMENTO DE LEIS.");
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
