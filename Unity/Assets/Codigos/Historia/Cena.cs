using System;
using System.Collections.Generic;
using UnityEngine;

namespace textgame
{
    [Serializable]
    public class Cena
    {
        [SerializeField]
        public string nomeCena;
        public string bg_cena;
        public List<Enredo> enredos;
        public List<Opcao> opcoes;
    }
}