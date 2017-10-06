using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace textgame {
    [Serializable]
    class StatsBar {
        //ESTATISTICAS PADRÃO PARA CADA BARRA
        [SerializeField]
        private Alinhamento confBar;

        [SerializeField]
        private float valMax;
        [SerializeField]
        private float valAtual;

        public float ValAtual {
            get {
                return valAtual;
            }

            set {
                this.valAtual = Mathf.Clamp(value, 0, ValMax);
                confBar.Value = valAtual;
            }
        }

        public float ValMax {
            get {
                return valMax;
            }

            set {
                valMax = value;
                confBar.MaxValue = valMax;
            }
        }

        public void IniciarConf() {
            this.ValMax = valMax;
            this.ValAtual = valAtual;
        }
    }

}
