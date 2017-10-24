using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace textgame {
    [Serializable]
    public class Motor : MonoBehaviour {

        #region Objetos Unity
        [Header("Canvas principal")]
        public Canvas canvas;

        [Space(5)]

        [Header("Titulo do cenário")]
        public Text text_tituloCenario;

        [Space(5)]

        [Header("Objetos e componentes do texto")]
        public Text text_historia;
        public Scrollbar scrollbar_historia;
        public AudioSource audios;
        AudioClip fxAtual;
        WWW wwwAudioFX;

        [Space(5)]

        [Header("Objeto e componentes das opções")]
        public Button btn_opcaoModelo;
        public Transform panel_opcoes;

        [Space(5)]

        [Header("Arquivo JSON")]
        public TextAsset json_arquivo;
        #endregion

        //private AudioSource audios;

        private bool interacao;
        private Gerenciador gerenciador;

        private int cenarioAtual;
        private int cenaAtual;

        private Personagem personagem;
     //   private Inventario inventario;

        // Método de inicialização do Unity
        void Start() {
            DontDestroyOnLoad(gameObject);
            audios = GetComponent<AudioSource>();

            personagem = new Personagem();
      //      inventario = new Inventario();


            gerenciador = new Gerenciador();

            interacao = false;

            cenarioAtual = 0;
            cenaAtual = 0;

            if (json_arquivo.text.Length > 0) {
                gerenciador = JsonUtility.FromJson<Gerenciador>(json_arquivo.text);
                Debug.Log("JSON carregado com sucesso!");
            } else {
                Debug.LogError("Não foi possivel carregar o arquivo JSON!");
            }

        }

        // O método UPDATE é chamado por frame do jogo
        void Update() {
            #region Verifica e espera a interação do usuário
            if (!interacao) {
                Cenario cenario = gerenciador.cenarios[cenarioAtual];

                alterarNomeCenario(cenario.nomeCenario);
                alterarFundo(cenario.cenas[cenaAtual].bg_cena);

                StartCoroutine(
                    Engrenagem(cenario.cenas[cenaAtual])
                );



                this.interacao = true;
            }
            #endregion
        }

        private void alterarNomeCenario(string nomeCenario) {
            text_tituloCenario.text = nomeCenario;
        }

        private void alterarFundo(String imagem) {
            WWW textura = new WWW(Path.Combine(Application.streamingAssetsPath, "bg_cenario_cena/" + imagem));
            canvas.GetComponent<RawImage>().texture = textura.texture;
        }

        IEnumerator Engrenagem(Cena cena) {

            for (int i = 0; i < cena.enredos.Count; i++) {
             
                fxAtual = null;
                wwwAudioFX = null;

                if (cena.enredos[i].fx != "") {
                    wwwAudioFX = new WWW(Path.Combine(Application.streamingAssetsPath, "musicas/" + cena.enredos[i].fx));
                    fxAtual = wwwAudioFX.GetAudioClip(false, false, AudioType.OGGVORBIS);
                    Debug.Log("Deveria ter FX");
                }

                for (int j = 0; j < cena.enredos[i].texto.Length; j++) {
                    text_historia.text += cena.enredos[i].texto[j];
                    yield return new WaitForSeconds(0.00f);
                    scrollbar_historia.value = 0;
                }

                if (fxAtual != null) {
                    audios.PlayOneShot(fxAtual, 1);

                }

                text_historia.text += "\n";
            }

            gerarBotao(cena.opcoes);
        }

        public void gerarBotao(List<Opcao> qntOpc) {
            Button novoBotao;
            int x = 245;
            int y = 130;
            int z = 0;

            for (int i = 0; i < qntOpc.Count; i++) {

                if ((qntOpc[i].permissao.Equals("todos") || String.Equals(personagem.Nome_profissao, qntOpc[i].permissao, StringComparison.OrdinalIgnoreCase))
                    && personagem.Saldo >= qntOpc[i].descontar) {

                    novoBotao = Instantiate(btn_opcaoModelo, panel_opcoes);
                    novoBotao.transform.position = new Vector3(x, y, z);
                    novoBotao.gameObject.SetActive(true);

                    novoBotao.GetComponentsInChildren<Text>()[0].text = qntOpc[i].resposta;

                    novoBotao.onClick = new Button.ButtonClickedEvent();

                    AddListener(novoBotao, qntOpc[i].segmento.idCenario, qntOpc[i].segmento.idCena, qntOpc[i].descontar, qntOpc[i].item, qntOpc[i].resposta);

                    y -= 32;
                }
            }
        }

        private void eventoBtn(int cenarioAtual, int cenaAtual, float saldo, Item item, string resposta) {
            this.cenarioAtual = cenarioAtual;
            this.cenaAtual = cenaAtual;
            this.personagem.Saldo -= saldo;

            text_historia.text += resposta + "\n";
            text_historia.text += "\n";


            //if (item != null) {
            //    inventario.Add(item);
            //}

            for (int i = 0; i < panel_opcoes.GetComponentsInChildren<Button>().Length; i++) {
                Destroy(panel_opcoes.GetComponentsInChildren<Button>()[i].gameObject);
            }

            interacao = false;
        }

        void AddListener(Button button, int cenarioAtual, int cenaAtual, float saldo, Item item, string resposta) {
            button.onClick.AddListener(() => eventoBtn(cenarioAtual, cenaAtual, saldo, item, resposta));
        }
    }
}