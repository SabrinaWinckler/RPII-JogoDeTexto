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

        public Canvas canvas;

        public Text historia;
        public Text nomeCenario;
        public Scrollbar scrollbar_historia;

        private AudioSource audios;

        private AudioClip fxAtual;

        private bool interacao;
        private string jsonGerenciador;
        private string filePath;
        private Gerenciador gerenciador;

        private int cenarioAtual;
        private int cenaAtual;

        public Button obj;
        public Transform painelOpc;

        private Personagem personagem;
        private Inventario inventario;

        // Use this for initialization
        void Start()
        {
            DontDestroyOnLoad(gameObject);

            audios = GetComponent<AudioSource>();

            this.jsonGerenciador = "json/Gerenciador.json";
            //this.jsonGerenciador = "json/Teste.json";
            this.filePath = Path.Combine(Application.streamingAssetsPath, this.jsonGerenciador);

            historia.text = "";
            personagem = new Personagem();
            inventario = new Inventario();

            personagem.setProfissao("Ator");
            personagem.Saldo = 200;

            interacao = false;

            gerenciador = new Gerenciador();

            cenarioAtual = 0;
            cenaAtual = 0;

            if (File.Exists(filePath))
            {
                string arquivo = File.ReadAllText(filePath);

                gerenciador = JsonUtility.FromJson<Gerenciador>(arquivo);
                Debug.Log("JSON CARREGADO");
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
            if (!interacao)
            {
                Debug.Log("Entrou em '!interacao' ");
                StartCoroutine(
                    Engrenagem(gerenciador.cenarios[cenarioAtual].cenas[cenaAtual])
                );

                this.interacao = true;
            }
        }


        IEnumerator Engrenagem(Cena cena)
        {
            Debug.Log("Entrou em 'Engrenagem' ");
            nomeCenario.text = gerenciador.cenarios[cenarioAtual].nomeCenario;
            WWW textura = new WWW(Path.Combine(Application.streamingAssetsPath, "bg_cenario_cena/" + cena.bg_cena));
            canvas.GetComponent<RawImage>().texture = textura.texture;

            for (int i = 0; i < cena.enredos.Count; i++)
            {

                if(cena.enredos[i].fx != null)
                {
                    WWW wwwAudioFX = new WWW(Path.Combine(Application.streamingAssetsPath, "musicas/" + cena.enredos[i].fx));
                    Debug.LogError(Path.Combine(Application.streamingAssetsPath, "musicas/" + cena.enredos[i].fx));
                    fxAtual = wwwAudioFX.GetAudioClip(false, true, AudioType.OGGVORBIS);
                    Debug.LogError(fxAtual);
                    Debug.Log("Deveria ter FX");
                }
                   

                for (int j = 0; j < cena.enredos[i].texto.Length; j++)
                {
                    historia.text += cena.enredos[i].texto[j];
                    yield return new WaitForSeconds(0.04f);
                    scrollbar_historia.value = 0;
                }

                if (fxAtual != null)
                {
                    audios.PlayOneShot(fxAtual, 1);
                    fxAtual = null;
                }

                historia.text += "\n";
            }

            gerarBotao(cena.opcoes);
        }

        public void gerarBotao(List<Opcao> qntOpc)
        {
            Button novoBotao;
            int x = 38;
            int y = 125;
            int z = 0;

            for(int i = 0; i < qntOpc.Count; i++)
            {
                if((qntOpc[i].permissao == "todos" || String.Equals(personagem.getHabilidades(), qntOpc[i].permissao, StringComparison.OrdinalIgnoreCase))
                    && personagem.Saldo > qntOpc[i].descontar)
                {
                    novoBotao = Instantiate(obj, painelOpc); 
                    novoBotao.transform.position = new Vector3(x, y, z);
                    novoBotao.gameObject.SetActive(true);

                    novoBotao.GetComponentsInChildren<Text>()[0].text = qntOpc[i].resposta;

                    novoBotao.onClick = new Button.ButtonClickedEvent();

                    AddListener(novoBotao, qntOpc[i].segmento.idCenario, qntOpc[i].segmento.idCena, qntOpc[i].descontar, qntOpc[i].item);

                    y -= 32;
                }
            }
        }

        private void eventoBtn(Button b, int cenarioAtual, int cenaAtual, float saldo, Item item)
        {
            this.cenarioAtual = cenarioAtual;
            this.cenaAtual = cenaAtual;
            this.personagem.Saldo -= saldo;
            
            if(item != null)
            {
                inventario.Add(item);
            }

            Destroy(b);

            for (int i = 0; i < painelOpc.GetComponentsInChildren<Button>().Length; i++)
            {
                Destroy(painelOpc.GetComponentsInChildren<Button>()[i].gameObject);
            }
            
            interacao = false;
        }

        void AddListener(Button b, int cenarioAtual, int cenaAtual, float saldo, Item item)
        {
            b.onClick.AddListener(() => eventoBtn(b, cenarioAtual, cenaAtual, saldo, item));
        }
    }
}
