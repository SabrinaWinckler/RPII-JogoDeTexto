using System;
using System.Collections.Generic;
using UnityEngine;

namespace Serializaveis {

    [Serializable]
    public class Gerenciador {

        [SerializeField]
        public List<Cenario> cenarios = new List<Cenario>();
    }
}
