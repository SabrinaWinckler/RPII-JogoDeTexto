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
        #region Teste1
        /*
        //ATRIBUTOS
        private static Personagem p;

        //COMPORTAMENTOS E METODOS
        public static void CriarPersonagem()
        {
            p = new Personagem();
            //Inserir personagem
            Console.WriteLine("Digite o nome do seu personagem -> ");
            p.Nome = Console.ReadLine();
        }

        public static void CriarProfissao()
        {
            Console.WriteLine("Digite a profissao desejada -> ");
            p.setProfissao(Console.ReadLine());
        }

        public static void VerHabilidades()
        {
            Console.WriteLine("**Habilidades do jogador**");
            p.getHabilidades();
        }

        public static void Menu()
        {
            Console.WriteLine("... MENU ...");
            Console.WriteLine("1 - Inserir Personagem.");
            Console.WriteLine("2 - Inserir Profissao.");
            Console.WriteLine("3 - Ver habilidades.");
            Console.WriteLine("4 - SAIR");
            Console.WriteLine(); Console.Write("Informe a opcao desejada -> ");
        }

        public static void Main(String[] args)
        {
            int opc = 0;
            do
            {
                Console.Clear();
                Menu();
                opc = Int32.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        CriarPersonagem();
                        break;
                    case 2:
                        CriarProfissao();
                        break;
                    case 3:
                        VerHabilidades();
                        break;
                }
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opc != 4);
        }
    */
        #endregion

        #region Teste2
        public static void Main(String[] args) {
            PersonagemTest p = new PersonagemTest();
            String pr;

            p.setProfissaoTest(ReadLine());
            WriteLine($"Profissao : {p.getProfissaoTest()}");
            p.AtualizaSaldo();
            WriteLine($"Saldo : {p.Saldo}");

            ReadKey();
        }
        #endregion
    }
}