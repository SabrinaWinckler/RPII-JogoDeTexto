using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace textgame
{
    class Profissao
    {
        //ATRIBUTOS
        private String prof;
        private ArrayList habilidades = new ArrayList();
        private bool encontrar = false;

        //COMPORTAMENTOS E METODOS
        public void setProfissao(String profissao)
        {
            if (!encontrar)
            {
                prof = profissao;
                if (String.Equals(prof, "POLICIAL", StringComparison.OrdinalIgnoreCase))
                {
                    this.habilidades.Add("1 - HABILIDADES POLICIAL.");
                    encontrar = true;
                }
                else if (String.Equals(prof, "MEDICO", StringComparison.OrdinalIgnoreCase))
                {
                    this.habilidades.Add("1 - HABILIDADES MEDICO.");
                    encontrar = true;
                }
                else if (String.Equals(prof, "PSICOLOGO", StringComparison.OrdinalIgnoreCase))
                {
                    this.habilidades.Add("1 - HABILIDADES PSICOLOGO.");
                    encontrar = true;
                }
                else if (String.Equals(prof, "PROFESSOR", StringComparison.OrdinalIgnoreCase))
                {
                    this.habilidades.Add("1 - HABILIDADES PROFESSOR.");
                    encontrar = true;
                }
                else if (String.Equals(prof, "ATOR", StringComparison.OrdinalIgnoreCase))
                {
                    this.habilidades.Add("1 - HABILIDADES ATOR.");
                    encontrar = true;
                }
                else if (String.Equals(prof, "ADVOGADO", StringComparison.OrdinalIgnoreCase))
                {
                    this.habilidades.Add("1 - ADVOGADO.");
                    encontrar = true;
                }
                else
                {
                    Console.WriteLine("Profissao nao disponivel");
                }
            }
            else
            {
                Console.WriteLine("Voce ja possui uma profissao -> " + this.prof);
            }
        }

        public string getHabilidades()
        {
            return this.prof;
        }
    }
}
