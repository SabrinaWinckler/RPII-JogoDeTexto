using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameTESTE
{
    class Jogo
    {
        //ATRIBUTOS
        private static Personagem personagem;
        private static Historia enredo = new Historia();
        private static Inventario inventario = new Inventario();
        private static int opcao;

        //METODOS
        public static void menuGame()
        {
            Console.WriteLine(" --------------------------------");
            Console.WriteLine("|     WELCOME TO textGAME        |");
            Console.WriteLine(" --------------------------------");
            Console.WriteLine("| 1 - Nome do jogador.           |"); 
            Console.WriteLine("| 2 - Inserir profissao.         |");
            Console.WriteLine("| 3 - Add itens no inventario.   |");
            Console.WriteLine("| 4 - Remover itens do invetario.|");
            Console.WriteLine("| 5 - Ver inventario.            |");
            Console.WriteLine("| 6 - Iniciar jogo               |");
            Console.WriteLine("|--------------------------------");
            Console.WriteLine("| 7 - Sair do jogo.              |");    
            Console.WriteLine(" --------------------------------");
            Console.WriteLine();
            Console.Write("Informe uma opcao - > ");
        }

        public static void inforJogador()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("{0}, seja bem-vindo ao textGAME.", personagem.Nome);
            Console.WriteLine("Sua profissao de {0} fara com que voce ganhe ", personagem.Profissao);
            Console.WriteLine("algumas habilidades durante o jogo, que sao: ");
            Console.WriteLine(); personagem.getHabilidades(); Console.WriteLine();
            Console.WriteLine("De inicio, vc recebera alguns itens: ");
            Console.WriteLine(); inventario.Abrir(); Console.WriteLine();
            Console.WriteLine("Divirta-se...");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public static void Main(String[] args)
        {
            //MINIMOTOR CONSOLE
            do
            {

                Console.Clear();
                menuGame();
                opcao = ValidarOpc( Console.ReadLine() ); Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        if ( personagem == null)
                        {
                            personagem = new Personagem();
                            Console.Write("DIGITE O NOME DO SEU PERSONAGEM: ");
                            personagem.Nome = Console.ReadLine();
                        }
                        else { Console.WriteLine("Voce ja possui um personagem!"); }
                        break;
                    case 2:
                        if ( personagem != null)
                        {
                            Console.WriteLine("PROFISSOES DISPONIVEIS: ");
                            Console.WriteLine("{ Policial, Professor, Medico, Psicologo, Ator, Advogado }");
                            Console.Write("DIGITE UMA PROFISSAO DISPONIVEL -> ");
                            personagem.Profissao = Console.ReadLine();
                        }
                        else { Console.WriteLine("Voce nao possui um personagem ainda!"); }
                        break;
                    case 3:
                        if (personagem != null)
                        {
                            if (!inventario.IsFull())
                            {
                                inventario.Add(new Item());
                                Console.WriteLine("Itens adicionados no inventario..");
                            }
                            else{ Console.WriteLine("Seu inventario esta cheio, descarte algo \npara adicionar novos Itens"); }
                        }
                        else { Console.WriteLine("Voce nao possui um personagem ainda!"); }
                        break;
                    case 4:
                        if (!inventario.IsEmpty())
                        {
                            if (inventario.Remove()) { Console.WriteLine("Removido com sucesso"); }
                            else { Console.WriteLine("Falha ao remover um Item!"); }
                        }
                        else { Console.WriteLine("Seu inventario esta vazio"); }
                        break;
                    case 5:
                        if (!inventario.IsEmpty())
                        {
                            Console.WriteLine("-------- Inventario --------");
                            Console.WriteLine(); inventario.Abrir(); Console.WriteLine();
                            Console.WriteLine("\n-------------------------");
                        }
                        else { Console.WriteLine("Seu inventario esta vazio!"); }
                        break;
                    case 6:
                        if (personagem != null)
                        {
                            inforJogador();
                            enredo.iniciarHistoria();
                        }
                        else { Console.WriteLine("Voce nao possui um personagem ainda!"); }
                        break;
                    default:
                        Console.WriteLine("Entrada inválida. Tente novamente!"); Console.WriteLine();
                        break;
                }
                Console.WriteLine();
                Console.Write("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 7);
        }

        public static int ValidarOpc(String opc)
        {
            try
            {
                opcao = Int32.Parse(opc);
                return opcao;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

    }
}
