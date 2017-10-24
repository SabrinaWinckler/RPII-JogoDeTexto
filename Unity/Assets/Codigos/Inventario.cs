//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.SceneManagement;
//using System.IO;

//namespace textgame
//{
//    class Inventario
//    {
//        //ATRIBUTOS
//        public List<Item> inventario = new List<Item>();
//        public Text text_item;
//        public Canvas imagem_item;
//        public Vector3 posicao;

//        //COMPORTAMENTOS E METODOS
//        public Inventario()
//        {
//            inventario.Capacity = 10;
//        }

//        public void Add(Item item)
//        {
//            if (!IsFull())
//            {
//                inventario.Add(item);
//            }
//        }

//        public bool Remove(string item_remover)
//        {
//            foreach (var item in inventario)
//            {
//                if (String.Equals(item.nome, item_remover, StringComparison.OrdinalIgnoreCase))
//                {
//                    inventario.Remove(item);
//                    return true;
//                }
//            }
//            return false;
//        }

//        public bool IsEmpty()
//        {
//            return (inventario.Count == 0);
//        }

//        public bool IsFull()
//        {
//            return (inventario.Count == 10);
//        }

//        public void Abrir()
//        {
//            if (!IsEmpty())
//            {
//                foreach (var item in inventario)
//                {
//                    text_item.text = item.nome;
//                    mostrarImagemItem(item.img_item);
//                    //montarInventario(item);            

//                }
//            }
//            else
//            {
//                text_item.text = " Seu inventário está vazio! ";
//            }
//        }
//        public void mostrarImagemItem(String img_item) {
//            WWW imagem = new WWW(Path.Combine(Application.streamingAssetsPath, "item_inventario/" + img_item));
//            imagem_item.GetComponent<RawImage>().texture = imagem.texture;
//        }
//        public Item Pegar(String nome) {
//            Item item_pego = null;
//            foreach (var item in inventario)
//            {
               
//                if ( nome == item.nome) {
//                    item_pego = item;
//                    break;
//                }
//            }
//            return item_pego;
         
//        }
//        //public void montarInventario(Item item) {
//        //    for (int i = 0; i < inventario.Count; i++)
//        //    {
//        //        this.posicao = new Vector3(UnityEngine.Random.Range(-5, 5), 1, UnityEngine.Random.Range(-5, 5));
//        //        //Instantiate(item, posicao);  // vai no mootor
//        //    }

//        //}
//        public Vector3 pegarPosicao() {
//            return this.posicao;
//        }
//        public List<Item> pegarLista() {
//            return this.inventario;
//        }
//    }
//}