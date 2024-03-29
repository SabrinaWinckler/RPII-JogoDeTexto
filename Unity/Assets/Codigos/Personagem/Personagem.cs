﻿using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protagonista {

    public class Personagem : MonoBehaviour {

        public float saldo;
        private Profissao[] profissoes = new Profissao[6];
        public String nome_profissao;
        public String text_img_Avatar;
        public GameObject img_Avatar;
        public Image imagem;
        public Text text_nome_profissao;
        public Text text_saldo;

        public Personagem() {
            Profissao medico = new Profissao("Medico", 300f);
            Profissoes[0] = medico;
            Profissao advogado = new Profissao("Advogado", 300f);
            Profissoes[1] = advogado;
            Profissao policial = new Profissao("Policial", 200f);
            Profissoes[2] = policial;
            Profissao atleta = new Profissao("Atleta", 100f);
            Profissoes[3] = atleta;

            Saldo = 0.0f;
        }
        void Awake() {
            text_nome_profissao.text = nome_profissao;
            text_saldo.text = "  $ " + Saldo;
        }
        public void setAvatar(Button avatar) {

            this.text_img_Avatar = avatar.image.name;
            this.img_Avatar = avatar.image.gameObject;
            imagem = avatar.image;
        }
        public GameObject getAvatar() {
            return this.img_Avatar;
        }
        public Image getAvatarImg() {
            return this.imagem;
        }
        public float Saldo {
            get { return saldo; }
            set { saldo = value; }
        }

        internal Profissao[] Profissoes {
            get {
                return profissoes;
            }

            set {
                profissoes = value;
            }
        }

        //public Profissao GetProfissao() {
        //    for (int i = 0; i < Profissoes.Length; i++) {
        //        if (Profissoes[i] != null) {
        //            if (Profissoes[i].Nome.Equals(nome_profissao, StringComparison.OrdinalIgnoreCase)) {
        //                //RETORNA O OBJETO PROFISSAO COM TODOS SEUS ATRIBUTOS/MÉTODOS
        //                return Profissoes[i];
        //            }
        //        }
        //    }

            //RETORNA NULO SE NÃO ENCONTRAR A PROFISSAO PELA STRING
        //    return null;
        //}
        public void setHabilidades(String habilidade) {
            //GetProfissao().List_Habilidades.Add(habilidade);
        }
        public void AtualizaSaldo() {
            //ATUALIZA SALDO COM ACRÉSCIMO DO BONUS DE CADA PROFISSÃO
           // Saldo += GetProfissao().Bonus;
        }
        public void MostrarAvatar(String person) {

            text_img_Avatar = person;

            WWW avatarPersonagem = new WWW(Path.Combine(Application.streamingAssetsPath, "Img_Personagem/" + person));
            img_Avatar.GetComponent<RawImage>().texture = avatarPersonagem.texture;
        }
    }
}
