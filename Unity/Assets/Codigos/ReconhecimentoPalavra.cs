using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace textgame {
    public class ReconhecimentoPalavra : MonoBehaviour {

        private ArrayList frasesTestes;
        private ArrayList palavras;
        private ArrayList palavrasResposta;

        private ArrayList frases;

        public InputField texto_entrada;
        public Text texto_dica;

        string teste;

        // Use this for initialization
        void Start() {

            frasesTestes = new ArrayList();
            palavras = new ArrayList();
            palavrasResposta = new ArrayList();
            frases = new ArrayList();

            frasesTestes.Add("Abrir a porta");
            frasesTestes.Add("Mandar para a puta que pariu");
            frasesTestes.Add("O JUDSON É GAY");
        }

        // Update is called once per frame
        void Update() {
            this.separarFrase(frasesTestes);
            this.separarResposta();
            this.mostrarDica();
        }

        private void separarFrase(ArrayList frase) {
            string sentenca;
            this.palavras.Clear();
            for (int i = 0; i < frase.Count; i++) {
                sentenca = (string) frase[i];
                this.separarPalavra(sentenca.ToUpper());
            }
        }

        private void separarPalavra(string frase) {
            string[] sentenca = frase.Split(' ');
            for (int i = 0; i < sentenca.Length; i++) {
                frases.Add(new Frase(sentenca[i], frase));
                palavras.Add(sentenca[i]);
            }
        }

        private void separarResposta() {
            string[] sentenca = texto_entrada.text.Split(' ');
            for (int i = 0; i < sentenca.Length; i++) {
                palavrasResposta.Add(sentenca[i]);
            }
        }

        private void mostrarFrases() {
            string termo;
            for (int i = 0; i < frases.Count; i++) {
                termo = ((Frase) frases[i]).getPalavra();
                if ((texto_entrada.text).ToUpper().Equals(termo)) {
                    texto_dica.text = ((Frase)frases[i]).getFrase();
                    Debug.Log("Entrada reconhecida.");
                }
            }
        }

        private void mostrarDica() {
            if (texto_entrada.text.Length > 2) {
                this.mostrarFrases();
            } else {
                texto_dica.text = "";
            }
        }
    }
}