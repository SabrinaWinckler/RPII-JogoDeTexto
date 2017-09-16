using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

namespace textgame
{
    [Serializable]
    public class Motor : MonoBehaviour
    {

        public Text historia;
        public Scrollbar scrollbar_historia;
        public Button[] btn_opcs;

        private AudioSource audios;
        private float inicioTempo;

        [Space(20)]
        [Header("Efeitos sonoros")]
        //public AudioClip ;
        private AudioClip fxAtual;

        bool interacao;
        bool ditado_rodando;
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

            audios = GetComponent<AudioSource>();

            //this.jsonGerenciador = "../Codigos/json/Gerenciador.json";
            this.jsonGerenciador = "../Codigos/json/Teste.json";
            this.filePath = Path.Combine(Application.streamingAssetsPath, this.jsonGerenciador);

            interacao = false;

            btn_opcs = new Button[4];

            gerenciador = new Gerenciador();

            cenarioAtual = 0;
            cenaAtual = 0;
            escolha = 0;

            if (File.Exists(filePath))
            {
                string arquivo = File.ReadAllText(filePath);

                gerenciador = JsonUtility.FromJson<Gerenciador>(arquivo);
                // StartCoroutine(Ditado(gerenciador.cenarios[0].cenas[0].enredos[0].texto));
                //for (int i = 0; i < gerenciador.cenarios[cenarioAtual].cenas[cenarioAtual].enredos.Count; i++)
                //{
                //    Debug.Log(gerenciador.cenarios[cenarioAtual].cenas[cenarioAtual].enredos[i].texto);
                //    Debug.Log(gerenciador.cenarios[cenarioAtual].cenas[cenarioAtual].enredos[i].fx);
                //}

                //for (int i = 0; i < gerenciador.cenarios[cenarioAtual].cenas[cenaAtual].opcoes.Count; i++)//mostra todas opções
                //{
                //    Debug.Log((gerenciador.cenarios[cenarioAtual].cenas[cenaAtual].opcoes[i].resposta));

                //}




            }
            else
            {
                Debug.LogError("Não foi possivel carregar o arquivo JSON!");
            }


            StartCoroutine(Ditado(gerenciador.cenarios[cenarioAtual].cenas[cenaAtual].enredos[0].texto));

            if (gerenciador.cenarios[cenarioAtual].cenas[cenaAtual].enredos[0].fx != null)
            {
                fxAtual = Resources.Load(gerenciador.cenarios[cenarioAtual].cenas[cenaAtual].enredos[0].fx, typeof(AudioClip)) as AudioClip;

                do
                {
                    audios.PlayOneShot(fxAtual, 1);
                } while (isPlaying());

                Debug.Log("oi");
                
                interacao = true;
            }

            Debug.Log("Motor inicializado.");

        }

        // Update is called once per frame
        void Update()
        {
            #region CODIGO ANTIGO
            //for (int i = 0; i < gerenciador.cenarios[cenarioAtual].cenas[cenarioAtual].enredos.Count; i++)
            //{
            //    Debug.Log(gerenciador.cenarios[cenarioAtual].cenas[cenarioAtual].enredos[i].texto);
            //    Debug.Log(gerenciador.cenarios[cenarioAtual].cenas[cenarioAtual].enredos[i].fx);
            //}

            //for (int i = 0; i < gerenciador.cenarios[cenarioAtual].cenas[cenaAtual].opcoes.Count; i++)//mostra todas opções
            //{
            //    Debug.Log((gerenciador.cenarios[cenarioAtual].cenas[cenaAtual].opcoes[i].resposta));

            //}

            ////Debug.Log(gerenciador.cenarios[cenarioAtual].cenas[cenaAtual].enredos[gerenciador.cenarios[cenarioAtual].cenas[cenaAtual].opcoes[escolha].segmento.idCenario].texto);
            ////(gerenciador.cenarios[cenarioAtual].cenas[cenaAtual].opcoes[escolha].segmento.idCena)
            #endregion

            if (!interacao)
            {
                //for (int i = 0; i < gerenciador.cenarios[cenarioAtual].cenas[cenaAtual].enredos.Count; i++)
                //{
                    
                //}

            }
            


            //for(int i = 0; i < gerenciador.cenarios[cenarioAtual].cenas[cenaAtual].opcoes.Count; i++)
            //{
            //    btn_opcs[i].
            //}
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


        private void PlayOneShot(AudioClip clip, float volume)
        {
            audios.PlayOneShot(clip, volume);
            inicioTempo = Time.time;
        }

        public bool isPlaying()
        {
            if ((Time.time - inicioTempo) >= fxAtual.length)
                return false;
            return true;
        }

    }
}
