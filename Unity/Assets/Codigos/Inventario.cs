using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace textgame
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

        public bool Remove(string item_remover)
        {
            foreach (var item in inventario)
            {
                if (String.Equals(item.nome, item_remover, StringComparison.OrdinalIgnoreCase))
                {
                    inventario.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public bool IsEmpty()
        {
            return (inventario.Count == 0);
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
                    Console.WriteLine("    " + item.nome);
                }
            }
            else
            {
                //Voce ainda nao capturou itens no jogo!
            }
        }

    }
}
