using System;
using System.Collections.Generic;
using UnityEngine;

namespace textgame
{
    [Serializable]
    public class Cenario
    {
        [SerializeField]
        public string nomeCenario;
        public string bg_cenario;
        public List<Cena> cenas;

    }
}