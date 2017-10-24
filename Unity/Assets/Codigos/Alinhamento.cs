using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace textgame {
    public class Alinhamento : MonoBehaviour {
        [SerializeField]
        private float velocidade;
        //VALOR PARA INCREMENTAR OU DECREMENTAR VIDA/MORAL
        private float ValorAtual;

        //ATRIBUTOS UNITY
        [SerializeField]
        private Image Bar;

        [SerializeField]
        private Text text_BarraAtual;

        [SerializeField]
        private Text text_Status;

        [SerializeField]
        private Color fullColor;

        [SerializeField]
        private Color lowColor;

        [SerializeField]
        private bool lerpColors;

        //COMPORTAMENTOS E MÉTODOS
        void Start() {
            if (lerpColors) {
                Bar.color = fullColor;
            }
        }

        void Update() { Barra(); }

        #region Metodos para test no Unity fucionando
        public float MaxValue { get; set; }

        public float Value {
            set {
                ValorAtual = MapBar(value, 0, MaxValue, 0, 1);
                // MoralAtual = MapBar(value, 0, MaxValue, 0, 1);
            }
        }

        private void Barra() {
            //ALTERA O VALOR DA BARRA NO TEXTO NO UNITY
            text_BarraAtual.text = (this.ValorAtual * 100) + "%";
            if (ValorAtual != Bar.fillAmount) {
                //FUNCIONAMENTO DA BARRA COM FILLAMOUNT
                Bar.fillAmount = Mathf.Lerp(Bar.fillAmount, ValorAtual, Time.deltaTime * velocidade);
            }
            if (lerpColors) {
                //SLIDE DE CORES QUANDO AS BARRAS DECREMENTAM
                Bar.color = Color.Lerp(lowColor, fullColor, ValorAtual);
            }
            //SITUAÇÕES PARA TESTE DE ACORDO COM O DECREMENTO DAS BARRAS
            //RESTA IMPLEMENTAÇÃO COMPLEXA E ELIMINAR/DIMINUIR OS if's
            if (ValorAtual == 0.0f) {
                text_Status.text = GetNomeBar() + " Zerou!";
            } else if (ValorAtual > 0 && ValorAtual <= 0.2f) {
                text_Status.text = GetNomeBar() + " muito baixo!";
            } else if (ValorAtual <= 0.5f) {
                text_Status.text = GetNomeBar() + " diminuindo!";
            } else if (ValorAtual <= 1f) {
                text_Status.text = GetNomeBar() + " estável!";
            }
        }

        //RETORNA MAPEAMENTO DA BARRA PARA FAZER ALTERAÇÃO NO FILLAMOUNT
        private float MapBar(float value, float inMin, float inMax, float outMin, float outMax) {
            return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
        }

        //RETORNA O NOME DE CADA BARRA QUE ESTÁ SENDO ALTERADA
        private String GetNomeBar() {
            if (Bar.name.Equals("barvida", StringComparison.OrdinalIgnoreCase)) return "Moral";
            else return "Vida";
        }


        #endregion

        #region Metodos para implementar com o motor
        //public void SistemaDeMoral() { 
        ////    if (BarraMoral != null) {
        //        if (MoralAtual >= MoralCheia) {
        //            MoralAtual = MoralCheia;
        //        }
        //        if (MoralAtual <= 0) {
        //            MoralAtual = 0;
        //            if (cronometroMoral >= 3) {
        //                VidaAtual += (VidaCheia * 0.005f);
        //                cronometroMoral = 0;
        //            }
        //        } else {
        //            cronometroMoral = 0;
        //            Desmoralizado();
        //        }
        ////    } else {
        //        Debug.Log("Moral ainda nao instanciada!");
        ////    }
        //}

        //public void SistemaDeVida() {
        ////    if (BarraVida != null) {
        //        BarVida.fillAmount = 10;
        //        if (VidaAtual >= VidaCheia) {
        //            VidaAtual = VidaCheia;
        //        } else if (VidaAtual <= 0) {
        //            VidaAtual = 0;
        //            Morreu();
        //        }
        ////    } else {
        //        Debug.Log("Vida ainda nao instanciada!");
        ////    }
        //}

        ////decidir o que vai aumentar a vida, moral e coragem
        //public void AplicarBarras() {
        //    //BarraVida.fillAmount -= ((1 / VidaCheia) * VidaAtual);
        //    //BarraMoral.fillAmount -= ((1 / MoralCheia) * MoralAtual);
        //}

        //public void Morreu() {
        //    Debug.Log("Morreu por falta de .....");
        //}

        ////decidir o que vai acontecer quando a barra de moral acabar
        //public void Desmoralizado() { }
        #endregion

    }
}