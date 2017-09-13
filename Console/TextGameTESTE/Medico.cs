using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameTESTE
{
    class Medico
    {
        //ATRIBUTOS
        private ArrayList habilidades = new ArrayList();

        //COMPORTAMENTOS E METODOS
        public Medico()
        {
            this.habilidades.Add("1 - AUTÓPSIA.");
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
