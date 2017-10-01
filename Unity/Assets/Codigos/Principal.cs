using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace textgame
{
    public class Principal : MonoBehaviour
    {

        #region Botão iniciar
        public Button btn_iniciar;
        public String cena_jogo = "Jogo";
        #endregion

        // Use this for initialization
        void Start()
        {

            btn_iniciar.onClick = new Button.ButtonClickedEvent();


            btn_iniciar.onClick.AddListener(() => {
               SceneManager.LoadScene("DadosPersonagem");
            });
            

            Debug.Log("Jogo inicializou");
        }

        // Update is called once per frame
        void Update()
        {

        }
      
    }
}
