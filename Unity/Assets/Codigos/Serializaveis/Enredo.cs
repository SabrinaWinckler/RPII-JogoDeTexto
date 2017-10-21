using System;
using UnityEngine;

namespace Serializaveis {

    [Serializable]
    public class Enredo {

        [SerializeField]
        public string texto;
        public string fx;
        public string img_avatar;
        public string habilidade;
    }
}