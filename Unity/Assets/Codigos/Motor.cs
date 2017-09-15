using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace textgame
{
    [Serializable]
    public class Motor : MonoBehaviour
    {

        public Text historia;
        public Scrollbar scrollbar_historia;

        bool interacao;
        private string jsonGerenciador;
        private string filePath;
        Gerenciador gerenciador;

        private int cenarioAtual;
        private int cenaAtual;
        private int escolha;

        // Use this for initialization
        void Start()
        {
            DontDestroyOnLoad(gameObject);
            //  this.jsonGerenciador = "../Codigos/json/Gerenciador.json";
            this.jsonGerenciador = "../Codigos/json/Teste.json";
            this.filePath = Path.Combine(Application.streamingAssetsPath, this.jsonGerenciador);

            gerenciador = new Gerenciador();

            cenarioAtual = 0;
            cenaAtual = 0;
            escolha = 0;

            if (File.Exists(filePath))
            {
                string arquivo = File.ReadAllText(filePath);
                
                gerenciador = JsonUtility.FromJson<Gerenciador>(arquivo);

                // StartCoroutine(Ditado(gerenciador.cenarios[0].cenas[0].enredos[0].texto));
                for (int i = 0; i < gerenciador.cenarios[cenarioAtual].cenas[cenarioAtual].enredos.Count; i++)
                {
                    Debug.Log(gerenciador.cenarios[cenarioAtual].cenas[cenarioAtual].enredos[i].texto);
                    Debug.Log(gerenciador.cenarios[cenarioAtual].cenas[cenarioAtual].enredos[i].fx);
                }

                for (int i = 0; i < gerenciador.cenarios[cenarioAtual].cenas[cenaAtual].opcoes.Count; i++)//mostra todas opções
                {
                    Debug.Log((gerenciador.cenarios[cenarioAtual].cenas[cenaAtual].opcoes[i].resposta));
               
                }

                


            }
            else
            {
                Debug.LogError("Não foi possivel carregar o arquivo JSON!");
            }
            Debug.Log("Motor inicializado.");

        }

        // Update is called once per frame
        void Update()
        {
            for (int i = 0; i < gerenciador.cenarios[cenarioAtual].cenas[cenarioAtual].enredos.Count; i++)
            {
                Debug.Log(gerenciador.cenarios[cenarioAtual].cenas[cenarioAtual].enredos[i].texto);
                Debug.Log(gerenciador.cenarios[cenarioAtual].cenas[cenarioAtual].enredos[i].fx);
            }

            for (int i = 0; i < gerenciador.cenarios[cenarioAtual].cenas[cenaAtual].opcoes.Count; i++)//mostra todas opções
            {
                Debug.Log((gerenciador.cenarios[cenarioAtual].cenas[cenaAtual].opcoes[i].resposta));

            }

            //Debug.Log(gerenciador.cenarios[cenarioAtual].cenas[cenaAtual].enredos[gerenciador.cenarios[cenarioAtual].cenas[cenaAtual].opcoes[escolha].segmento.idCenario].texto);
            //(gerenciador.cenarios[cenarioAtual].cenas[cenaAtual].opcoes[escolha].segmento.idCena)


        }

        IEnumerator Ditado(string frase)
        {
            int letra = 0;
            historia.text = "";
            while (letra < frase.Length)
            {
                historia.text += frase[letra];
                letra++;
                yield return new WaitForSeconds(0.001f);
                scrollbar_historia.value = 0;
            }
        }
    }
}
