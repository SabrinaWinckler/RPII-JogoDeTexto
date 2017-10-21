using Catalogo;
using System;
using UnityEngine;

namespace Serializaveis {

    [Serializable]
    public class Opcao {

        [SerializeField]
        public string resposta;
        public Segmento segmento;
        public string permissao;
        public float descontar;
        public ItemData item;
    }
}