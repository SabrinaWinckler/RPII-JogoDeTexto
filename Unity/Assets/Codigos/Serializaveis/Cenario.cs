using System;
using System.Collections.Generic;
using UnityEngine;

namespace Serializaveis {

    [Serializable]
    public class Cenario {

        [SerializeField]
        public string nomeCenario;
        public List<Cena> cenas;
    }
}