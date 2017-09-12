using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameTESTE
{
    class Historia
    {
        //ATRIBUTOS
        private ArrayList enredo = new ArrayList();

        //COMPORTAMENTOS E MÉTODOS
        public Historia()
        {
            enredo.Add("OCORRENCIA DE");
            enredo.Add("UM ASSASSINATO");
            enredo.Add("NO CONDOMINIO CARDOSO");
            enredo.Add(" ");
            enredo.Add("Possivel suspeita encontrada!");
        }

        public void getEnredo()
        {
            foreach (var item in enredo)
            {
                Console.WriteLine(item);
            }
        }

        public void iniciarHistoria()
        {
            Console.Clear();
            Console.WriteLine("******************** INICIANDO HISTORIA ******************");
            getEnredo();
        }

    }
}
