using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

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
        [Header("Dados")]
        public Personagem personagem;
        public Text text_profissao;
        public bool click;
        public bool interacao;
        Button[] btn;
        int escolhido;
        //public String profissao;
        #endregion
        void Start()
        {
            personagem = new Personagem();
            Button[]  btn = {medico, advogado, policial, atleta };
            click = false;
            interacao = false;
            
        }

        // Update is called once per frame
        void Update()
        {
            if (!interacao)
            {
                ButtonQualquer_Click(medico);
                this.interacao = true;
            }


        }
                
        public void definirProfissao()
        {
            
            
                if (medico.name.Equals(personagem.profissoes[personagem.posicao_vetor].Nome, StringComparison.OrdinalIgnoreCase))
                {
                    personagem.nome_profissao = medico.name;
                    text_profissao.text = personagem.nome_profissao;
                                  
                   
                }

                else if (atleta.name.Equals(personagem.profissoes[personagem.posicao_vetor].Nome, StringComparison.OrdinalIgnoreCase))
                {
                    personagem.nome_profissao = atleta.name;
                    text_profissao.text = personagem.nome_profissao;
                   

                }
                else if (policial.name.Equals(personagem.profissoes[personagem.posicao_vetor].Nome, StringComparison.OrdinalIgnoreCase))
                {
                    personagem.nome_profissao = policial.name;
                    String aux = personagem.GetProfissao().Nome;
                    text_profissao.text = aux;
                    

                }
                else if (advogado.name.Equals(personagem.profissoes[personagem.posicao_vetor].Nome, StringComparison.OrdinalIgnoreCase))
                {
                    personagem.nome_profissao = advogado.name;
                    String aux = personagem.GetProfissao().Nome;
                    text_profissao.text = aux;
                    
                }
         
        }
        public void escolhermedico()

        {
            if (!click) {
                medico.onClick = new Button.ButtonClickedEvent();
                medico.onClick.AddListener(() => definirProfissao());
                personagem.posicao_vetor = 0;
                click = true;
            }
            
            
            
        }
        public void ButtonQualquer_Click(object sender)
        {
            personagem.posicao_vetor = 0;
            Button btnClicado = (Button)sender;
            text_profissao.text = btnClicado.name;
        }
        public void selecionado() {

          
        }
        public void escolheratleta() {
            if (!click)
            {
                click = true;
                personagem.posicao_vetor = 1;
                atleta.onClick = new Button.ButtonClickedEvent();
                atleta.onClick.AddListener(() => definirProfissao());
            }
        }
        public void escolherpolicial() {
            if (!click)
            {
                click = true;
                personagem.posicao_vetor = 2;
                policial.onClick = new Button.ButtonClickedEvent();
                policial.onClick.AddListener(() => definirProfissao());
            }
        }
        public void escolherAdvogado() {
            if (!click)
            {
                click = true;
                personagem.posicao_vetor = 3;
                advogado.onClick = new Button.ButtonClickedEvent();
                advogado.onClick.AddListener(() => definirProfissao());
            }
        }
    }
}

