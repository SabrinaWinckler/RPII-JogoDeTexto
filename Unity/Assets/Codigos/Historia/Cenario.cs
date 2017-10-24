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
        public List<Cena> cenas;

    }
}