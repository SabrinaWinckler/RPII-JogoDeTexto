using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TextGameTESTE
{
    class Jogo
    {
        #region Teste2Atualizado
        public static void Main(String[] args) {
            Personagem p = new Personagem();

            WriteLine("Inserir Profissao -> ");
            p.setProfissao(ReadLine());

            WriteLine("Inserir Habilidade -> ");
            p.setHabilidades(ReadLine());


            WriteLine($"Profissao : {p.getProfissao()}");

            WriteLine($"Saldo : {p.Saldo}");

            WriteLine($"Habilidades adicionais -> ");
            p.getHabilidades();

            ReadKey();
        }
        #endregion
    }
}