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

        bool interacao;
        private string jsonGerenciador;
        private string filePath;

        // Use this for initialization
        void Start()
        {
            DontDestroyOnLoad(gameObject);
            this.jsonGerenciador = "../Codigos/json/Gerenciador.json";
            this.filePath = Path.Combine(Application.streamingAssetsPath, this.jsonGerenciador);

            if (File.Exists(filePath))
            {
                string arquivo = File.ReadAllText(filePath);

                Gerenciador gerenciador = new Gerenciador();
                gerenciador = JsonUtility.FromJson<Gerenciador>(arquivo);

                StartCoroutine(Ditado(gerenciador.cenarios[0].cenas[0].enredos[0].texto));
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

        }

        IEnumerator Ditado(string frase)
        {
            int letra = 0;
            historia.text = "";
            while (letra < frase.Length)
            {
                historia.text += frase[letra];
                letra++;
                yield return new WaitForSeconds(0.005f);
            }
        }
    }
}
