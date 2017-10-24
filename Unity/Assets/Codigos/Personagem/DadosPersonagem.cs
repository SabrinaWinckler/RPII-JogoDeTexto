using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

namespace textgame
{
    class DadosPersonagem : MonoBehaviour
    {
        #region Atributos 
        [Header("Botões")]
        public Button medico;
        public Button policial;
        public Button advogado;
        public Button atleta;
        public Button proximo;
        public Button fechar;
        public Button avatar1;
        public Button avatar2;
        public Button avatar3;

        [Header("Dados")]
        public Personagem personagem;
        public Text text_profissao;
        public Canvas profissao;
        public GameObject painel_inicial;
        public GameObject img_Avatar;
        public GameObject painelescolha;

        #endregion
        void Start()
        {
            personagem = new Personagem();
            painel_inicial = new GameObject();
            img_Avatar = new GameObject();
            painelescolha = new GameObject();
            
            

            medico = GetComponent<Button>();
            advogado = GetComponent<Button>();
            policial = GetComponent<Button>();
            atleta = GetComponent<Button>();

            proximo = GetComponent<Button>();

            avatar1 = GetComponent<Button>();
            avatar2 = GetComponent<Button>();
            avatar3 = GetComponent<Button>();

            //img_Avatar.gameObject.SetActive(false);
            painel_inicial.SetActive(true);
            //painelimagem.SetActive(false);
                     
            //Input.GetMouseButtonUp(0)
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public void OnClick(String nome)
        {
            personagem.nome_profissao = nome;
            text_profissao.text = "Profissão selecionada -> " + personagem.GetProfissao().Nome;
        }
        public void OnClick() {
             SceneManager.LoadScene("Jogo");
        }
        public void OnClick(GameObject painel) {
            painel.gameObject.SetActive(false);
        }
        public void OnClick(Button avatar) {

            personagem.setAvatar(avatar);
            img_Avatar = personagem.getAvatar();

            //Image imagem = GameObject.Find("img_avatar").GetComponent<Image>();
            
            //painelescolha.SetActive(true);
            //imagem.gameObject.SetActive(true);

            //Debug.Log(personagem.text_img_Avatar);

        }
    }
}

