using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

namespace textgame
{
    class Personagem
    {
        public float saldo;
        public Profissao profissao = new Profissao();
        public Text text_img_Avatar;
        public Canvas img_Avatar;

        public Personagem() {
            Saldo = 0.0f;
        }

        public float Saldo {
            get {return saldo; }
            set {saldo = value; }
        }

        public void setprofissao(String profi) {
            profissao.Profi = profi;
        }

        public String getprofissao() {
            return profissao.Profi;
        }

        public void AtualizaSaldo() {
            profissao.Extra();
            Saldo += profissao.Bonus;
        }

        public void MostrarAvatar(String person) {

            text_img_Avatar.text = person;

            WWW avatarPersonagem = new WWW(Path.Combine(Application.streamingAssetsPath, "Img_Personagem/" + person));
            img_Avatar.GetComponent<RawImage>().texture = avatarPersonagem.texture;
        }
    }
}
