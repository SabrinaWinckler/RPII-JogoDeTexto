using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


namespace Inventario {
    public class ItemJson : MonoBehaviour {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Valor { get; set; }
        public bool Stackable { get; set; }
        public string Slug { get; set; }
        public Sprite Sprite { get; set; }

        public ItemJson(int id, string nome, string descricao, int valor, bool stackable, string slug) {
            this.ID = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Valor = valor;
            this.Stackable = stackable;
            this.Slug = slug;
            this.Sprite = Resources.Load<Sprite>("Sprites/Items/" + slug);

        }

        public ItemJson() {
            this.ID = -1;
        }

    }
}
