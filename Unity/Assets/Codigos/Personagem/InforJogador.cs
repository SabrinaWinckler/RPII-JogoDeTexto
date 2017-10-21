using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Protagonista {

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
                vida.ValAtual -= 5;
            } else if (Input.GetKeyDown(KeyCode.RightArrow)){
                vida.ValAtual += 5;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow)) {
                moral.ValAtual -= 5;
            } else if (Input.GetKeyDown(KeyCode.UpArrow)) {
                moral.ValAtual += 5;
            }
        }
    }

}
