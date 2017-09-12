using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameTESTE
{
    class Inventario
    {
        //ATRIBUTOS
        private List<Item> inventario = new List<Item>();

        //COMPORTAMENTOS E METODOS
        public Inventario()
        {
            inventario.Capacity = 10;
        }

        public void Add(Item item)
        {
            if (!IsFull())
            {
                inventario.Add(item);
            }
        }

        public bool Remove()
        {
            String item_remover;
            Console.Write("Digite o item que deseja remover -> ");
            item_remover = Console.ReadLine();
            foreach (var item in inventario)
            {
                if ( String.Equals(item.Nome, item_remover, StringComparison.OrdinalIgnoreCase) )
                {
                    inventario.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public bool IsEmpty()
        {
            return (inventario.Count == 0) ;
        }

        public bool IsFull()
        {
            return (inventario.Count == 10);
        }

        public void Abrir()
        {
            if (!IsEmpty())
            {
                foreach (var item in inventario)
                {
                    Console.WriteLine("    " + item.Nome);
                }
            }
            else { Console.WriteLine("Voce ainda nao capturou itens no jogo!"); }
        }

    }
}
