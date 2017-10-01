﻿using System.Collections;
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

        [Header("Dados")]
        public Personagem personagem;
        public Text text_profissao;

    #endregion
        void Start()
        {
            personagem = new Personagem();

            medico = GetComponent<Button>();
            advogado = GetComponent<Button>();
            policial = GetComponent<Button>();
            atleta = GetComponent<Button>();

            //Input.GetMouseButtonUp(0)
        }

        // Update is called once per frame
        void Update() {
            //asfasdf
        }

        public void OnClick(String nome) {
            personagem.nome_profissao = nome;
            text_profissao.text = personagem.GetProfissao().Nome;
        }
        
    }
}

