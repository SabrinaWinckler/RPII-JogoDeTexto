using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace textgame
{
    class Personagem
    {
        //ATRIBUTOS
        public Profissao profissao; 
        public float saldo;
        public Text text_img_Avatar;
        public Text text_habilidades;
        public Canvas img_Avatar;

        //COMPORTAMENTOS E METODOS
        public void setProfissao(String p) {
            profissao = new Profissao(p);
            Saldo += profissao.getBonus();
        }

        public string Nome { get; private set; }
        public float Saldo { get; set; }

        public String getProfissao() {
            return profissao.Prof;
        }

        public void setHabilidades(String h) {
            if (h != null)
                profissao.Habilidades.Add(h);
        }

        public void getHabilidades() {
            foreach (var h in profissao.Habilidades) {
                text_habilidades.text = h;
            }
        }

        public void MostrarAvatar(String person) {
            text_img_Avatar.text = person;
            WWW avatarPersonagem = new WWW(Path.Combine(Application.streamingAssetsPath, "Img_Personagem/" + person));
            img_Avatar.GetComponent<RawImage>().texture = avatarPersonagem.texture;
        }

    }
}
