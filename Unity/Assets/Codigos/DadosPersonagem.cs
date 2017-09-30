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
        //public String profissao;
        #endregion
        void Start()
        {
            medico.onClick = new Button.ButtonClickedEvent();
            atleta.onClick = new Button.ButtonClickedEvent();
            advogado.onClick = new Button.ButtonClickedEvent();
            policial.onClick = new Button.ButtonClickedEvent();
            personagem = new Personagem();
                                          
        }

        // Update is called once per frame
        void Update()
        {
            medico.onClick.AddListener(definirProfissao);
            atleta.onClick.AddListener(definirProfissao);
            advogado.onClick.AddListener(definirProfissao);
            policial.onClick.AddListener(definirProfissao);
        }
        public void definirProfissao() {
            for (int i = 0; i < personagem.profissoes.Length; i++) {
                if (personagem.profissoes[i].Nome.Equals("medico", StringComparison.OrdinalIgnoreCase)) {
                    personagem.posicao_vetor = i;
                    break;
                }
                if (personagem.profissoes[i].Nome.Equals("atleta", StringComparison.OrdinalIgnoreCase))
                {
                    personagem.posicao_vetor = i;
                    break;
                }
                if (personagem.profissoes[i].Nome.Equals("policial", StringComparison.OrdinalIgnoreCase))
                {
                    personagem.posicao_vetor = i;
                    break;
                }
                if (personagem.profissoes[i].Nome.Equals("advogado", StringComparison.OrdinalIgnoreCase))
                {
                    personagem.posicao_vetor = i;
                    break;
                }

            }
                if (medico.name.Equals(personagem.profissoes[personagem.posicao_vetor].Nome, StringComparison.OrdinalIgnoreCase))
                {
                    personagem.nome_profissao = medico.name;
                    text_profissao.text = personagem.nome_profissao;
                    
                }
              
                if (atleta.name.Equals(personagem.profissoes[personagem.posicao_vetor].Nome, StringComparison.OrdinalIgnoreCase))
                {
                    personagem.nome_profissao = atleta.name;
                    text_profissao.text = personagem.nome_profissao;
                    
                }
                if (policial.name.Equals(personagem.profissoes[personagem.posicao_vetor].Nome, StringComparison.OrdinalIgnoreCase))
                {
                    personagem.nome_profissao = policial.name;
                    String aux = personagem.GetProfissao().Nome;
                    text_profissao.text = aux;
                    
                }
                if (advogado.name.Equals(personagem.profissoes[personagem.posicao_vetor].Nome, StringComparison.OrdinalIgnoreCase))
                {
                    personagem.nome_profissao = advogado.name;
                    String aux = personagem.GetProfissao().Nome;
                    text_profissao.text = aux;
                }
            }
        }
    }

