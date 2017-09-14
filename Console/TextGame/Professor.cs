using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameTESTE
{
    class Professor
    {
        //ATRIBUTOS
        private ArrayList habilidades = new ArrayList();

        //COMPORTAMENTOS E METODOS
        public Professor()
        {
            this.habilidades.Add("1 - CONHECIMENTOS DE DIVERSAS AREAS.");
            this.habilidades.Add("2 - CAPACIDADE RAPIDA DE RACIOCINIO LOGICO.");

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
