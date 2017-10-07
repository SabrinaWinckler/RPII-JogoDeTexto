using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Alinhamento : MonoBehaviour {
 
 public Image BarraMoral, BarraCoragem, BarraVida;
 public float VidaCheia = 100, MoralCheia = 100, CoragemCheia = 100;// tem que decidir a quantidadede cada barrinha 
 [HideInInspector]
 public float VidaAtual, MoralAtual, CoragemAtual;
 public object CoragemAtua;
 public bool semMoral = false;
 public float cronometroMoral, cronometroCoragem;

    void Start()
    {
        VidaAtual = VidaCheia;
        CoragemAtual = CoragemCheia;
        MoralAtual = MoralCheia;
        SistemaDeVida();
        SistemaDeMoral();
        SistemaDeCoragem();
        Desencorajado();
        Desmoralizado();
        
    }
    void SistemaDeMoral(){
         if (MoralAtual >= MoralCheia) {
                MoralAtual = MoralCheia;
         }
         if (MoralAtual <= 0) {
                MoralAtual = 0;
         if (cronometroMoral >= 3) {
                VidaAtual += (VidaCheia * 0.005f);
                cronometroMoral = 0;
         }
         } else {
         cronometroMoral = 0;
            Desmoralizado(); 
         }
    }
    void SistemaDeCoragem(){
         if (CoragemAtual >= CoragemCheia) {
                CoragemAtual = CoragemCheia;
         }
         if (CoragemAtual <= 0) {
                CoragemAtual = 0;
         if (cronometroCoragem >= 3) {
                VidaAtual += (VidaCheia * 0.005f);
         }
         } else {
         cronometroCoragem = 0;
            Desencorajado();
         }
    } 
    void SistemaDeVida(){
         if (VidaAtual >= VidaCheia) {
                VidaAtual = VidaCheia;
         }
        else if (VidaAtual <= 0) {
                VidaAtual = 0;
                Morreu ();
        }
    }
    //decidir o que vai aumentar a vida, moral e coragem
    void AplicarBarras(){
         BarraVida.fillAmount = ((1/VidaCheia) * VidaAtual);
         BarraMoral.fillAmount = ((1/MoralCheia) * MoralAtual);
         BarraCoragem.fillAmount = ((1/CoragemCheia) * CoragemAtual);
    }
    void Morreu (){
         Debug.Log("Morreu por falta de .....");
    }
    //decidir o que vai acontecer quando a barra de coragem acabar
    void Desencorajado() { }
    //decidir o que vai acontecer quando a barra de moral acabar
    void Desmoralizado() { }
}