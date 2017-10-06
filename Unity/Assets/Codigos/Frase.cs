using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace textgame {
    public class Frase {

        private string palavra;
        private string frase;

        public Frase(string palavra, string frase) {
            this.palavra = palavra;
            this.frase = frase;
        }

        public string getPalavra() { 
            return this.palavra;
        }

        public string getFrase() {
            return this.frase;
        }
    }
}
