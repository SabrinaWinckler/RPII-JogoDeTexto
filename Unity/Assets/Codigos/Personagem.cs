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
    class Personagem : MonoBehaviour
    {

        public float saldo;
        public int posicao_vetor;
        public Profissao[] profissoes = new Profissao[6];
        public String nome_profissao;
        public String text_img_Avatar;
        public GameObject img_Avatar;
        public Image imagem;
        public Text text_profissao;
        public Text text_saldo;

        public Personagem() {
            Profissao medico = new Profissao("Medico", 300f);
            profissoes[0] = medico;
            Profissao advogado = new Profissao("Advogado", 300f);
            profissoes[1] = advogado;
            Profissao policial = new Profissao("Policial", 200f);
            profissoes[2] = policial;
            Profissao atleta = new Profissao("Atleta", 100f);
            profissoes[3] = atleta;

            Saldo = 0.0f;
        }

        void Awake() {
            text_profissao.text = profissoes[posicao_vetor].nome;
            text_saldo.text = "$ " + (profissoes[posicao_vetor].Bonus + Saldo);
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
            get {return saldo; }
            set {saldo = value; }
        }

        public String Nome_profissao {
            get { return nome_profissao; }
            set { nome_profissao = value; }
        }

        public Profissao GetProfissao() {
            for (int i = 0; i < profissoes.Length; i++) {
                if (profissoes[i] != null) {
                    if (profissoes[i].Nome.Equals(Nome_profissao, StringComparison.OrdinalIgnoreCase)) {
                        this.posicao_vetor = i;
                        //RETORNA O OBJETO PROFISSAO COM TODOS SEUS ATRIBUTOS/MÉTODOS
                        return profissoes[i];
                    }
                }
            }

            //RETORNA NULO SE NÃO ENCONTRAR A PROFISSAO PELA STRING
            return null;
        }

        public void setHabilidades(String habilidade) {
            profissoes[posicao_vetor].Add_Habilidades(habilidade);
        }

        public void AtualizaSaldo() {
            //ATUALIZA SALDO COM ACRÉSCIMO DO BONUS DE CADA PROFISSÃO
            Saldo += profissoes[posicao_vetor].Bonus;
        }

        public void MostrarAvatar(String person) {

            text_img_Avatar = person;

            WWW avatarPersonagem = new WWW(Path.Combine(Application.streamingAssetsPath, "Img_Personagem/" + person));
            img_Avatar.GetComponent<RawImage>().texture = avatarPersonagem.texture;
        }
    }
}
