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
        //public String profissao;
        #endregion
        void Start()
        {
            
            personagem = new Personagem();
            click = false;
            interacao = false;
       
            
        }

        // Update is called once per frame
        void Update()
        {
            if (!interacao)
            {
                escolhida();

                this.interacao = true;
            }

        }
        public void definirProfissao()
        {
            for (int i = 0; i < personagem.profissoes.Length; i++)
            {

            }
            
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
        public void escolhida()

        {
            
           
            if (medico.IsActive())
            {
                click = true;
                personagem.posicao_vetor = 0;
                medico.onClick.AddListener(definirProfissao);
            }
            if (atleta.IsActive())
            {
                click = true;
                personagem.posicao_vetor = 1;
                atleta.onClick.AddListener(definirProfissao);
            }
            if (policial.IsActive())
            {
                click = true;
                personagem.posicao_vetor = 0;
                policial.onClick.AddListener(definirProfissao);
            }
            if (advogado.IsActive())
            {
                click = true;
                personagem.posicao_vetor = 3;
                advogado.onClick.AddListener(definirProfissao);
            }
        }
    }

}

