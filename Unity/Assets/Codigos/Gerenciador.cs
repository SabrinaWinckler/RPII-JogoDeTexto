using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace textgame
{
    [Serializable]
    public class Gerenciador
    {
        [SerializeField]
        public List<Cenario> cenarios = new List<Cenario>();
    }
}
