using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameTESTE
{
    class Policial
    {
        //ATRIBUTOS
        private ArrayList habilidades = new ArrayList();

        //COMPORTAMENTOS E METODOS
        public Policial()
        {
            this.habilidades.Add("1 - ACESSO AO SISTEMA POLICIAL.");
            this.habilidades.Add("2 - LUTAR.");
            this.habilidades.Add("3 - RACIOCINIO INVESTIGACIONAL.");
        }

        public void getHabilidades()
        {
            foreach (var item in habilidades)
            {
                Console.WriteLine( item );
            }
        }
    }
}
