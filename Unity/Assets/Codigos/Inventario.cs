using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

namespace textgame
{
    class Inventario
    {
        //ATRIBUTOS
        public List<Item> inventario = new List<Item>();
        public Text text_item;
        public Canvas imagem_item;

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
                    text_item.text = item.nome;
                    mostrarImagemItem(item.img_item);

                }
            }
            else
            {
                text_item.text = " Seu inventário está vazio! ";
            }
        }
        public void mostrarImagemItem(String img_item) {
            WWW imagem = new WWW(Path.Combine(Application.streamingAssetsPath, "item_inventario/" + img_item));
            imagem_item.GetComponent<RawImage>().texture = imagem.texture;
        }


    }
}
