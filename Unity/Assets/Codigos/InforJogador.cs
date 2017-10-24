using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// PERSONAGEM: Dante Telles
/// IDADE: 33
/// PROFISSAO ANTERIOR: Escolha do usuário
/// 
/// </summary>

namespace textgame {
    public class InforJogador : MonoBehaviour {
        //ATRIBUTOS UNITY
        [SerializeField]
        private StatsBar vida;

        [SerializeField]
        private StatsBar moral;

        //COMPORTAMENTOS E MÉTODOS
        void Awake() {
            vida.IniciarConf();
            moral.IniciarConf();
        }

        void Update() {
            //TESTE DAS BARRAS DE MORAL E VIDA COM O TECLADO
            if ( Input.GetKeyDown( KeyCode.LeftArrow)) {
                moral.ValAtual -= 5;
            } else if (Input.GetKeyDown(KeyCode.RightArrow)){
                moral.ValAtual += 5;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow)) {
                vida.ValAtual -= 5;
            } else if (Input.GetKeyDown(KeyCode.UpArrow)) {
                vida.ValAtual += 5;
            }
        }
    }

}
